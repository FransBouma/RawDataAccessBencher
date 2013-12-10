using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Massive;
using System.Dynamic;

namespace Oak
{
    public class HasMany : Association
    {
        public string ForeignKey { get; set; }

        public string PropertyContainingIdValue { get; set; }

        public EagerLoadMany EagerLoadMany { get; set; }

        public HasMany(DynamicRepository repository)
            : this(repository, null)
        {

        }

        public HasMany(DynamicRepository repository, string methodName)
        {
            this.Repository = repository;

            this.MethodName = methodName ?? repository.TableName;
        }

        public void Init(dynamic model)
        {
            EagerLoadMany = new EagerLoadMany();

            ForeignKey = ForeignKey ?? SigularId(model);

            PropertyContainingIdValue = PropertyContainingIdValue ?? Id();

            var toTable = Repository.TableName;

            AddAssociationMethods(model, ForeignKey);
        }

        private void AddAssociationMethods(dynamic model, string fromColumn)
        {
            model.SetMember(MethodName, Query(fromColumn, model));

            model.SetMember(Singular(MethodName) + "Ids", QueryIds(fromColumn, model));

            model.SetMember("New" + Singular(MethodName), NewItemDelegate(model));
        }

        private DynamicFunctionWithParam NewItemDelegate(dynamic model)
        {
            var newItemDelegate = new DynamicFunctionWithParam(attributes =>
            {
                return EntityFor(model, attributes);
            });

            return newItemDelegate;
        }

        public override void AddNewAssociationMethod(DynamicModels collection, dynamic model)
        {
            collection.SetMember("New", NewItemDelegate(model));
        }

        private dynamic EntityFor(dynamic model, dynamic attributes)
        {
            var entity = new Gemini(attributes);

            entity.SetMember(ForeignKey, model.GetMember(PropertyContainingIdValue));

            return Repository.Projection(entity);
        }

        private DynamicFunctionWithParam Query(string foreignKey, dynamic model)
        {
            return (options) =>
            {
                if (EagerLoadMany.ShouldDiscardCache(options)) EagerLoadMany.Cache = null;

                if (EagerLoadMany.Cache != null) return EagerLoadMany.Cache;

                EagerLoadMany.Cache = new DynamicModels(Repository.Query(SelectClause(model)));

                AddNewAssociationMethod(EagerLoadMany.Cache, model);

                return EagerLoadMany.Cache;
            };
        }

        private DynamicFunction QueryIds(string foreignKey, dynamic model)
        {
            return () =>
            {
                IEnumerable<dynamic> models = (Query(foreignKey, model) as DynamicFunctionWithParam).Invoke(null);

                return models.Select(s => s.Id).ToList();
            };
        }

        public IEnumerable<dynamic> EagerLoad(IEnumerable<dynamic> models, dynamic options)
        {
            var query = SelectClause(models.ToArray());

            return EagerLoadMany.Execute(options, Repository, MethodName, query, models, ForeignKey);
        }

        private string SelectClause(params dynamic[] models)
        {
            return @"
                select {childTable}.* 
                from {childTable} 
                where {foreignKey} in ({inClause})"
                .Replace("{childTable}", TableName)
                .Replace("{foreignKey}", ForeignKey)
                .Replace("{inClause}", InClause(models, PropertyContainingIdValue));
        }
    }

    public class HasManyThrough : Association
    {
        string toTable;

        string throughTable;

        DynamicRepository through;

        public EagerLoadMany EagerLoadMany { get; set; }

        public string XRefToColumn { get; set; }

        public string XRefFromColumn { get; set; }

        public string ToTableColumn { get; set; }

        public string PropertyContainingIdValue { get; set; }

        public HasManyThrough(DynamicRepository repository, DynamicRepository through)
            : this(repository, through, null)
        {

        }

        public HasManyThrough(DynamicRepository repository, DynamicRepository through, string methodName)
        {
            this.Repository = repository;

            this.through = through;

            this.throughTable = through.TableName;

            this.MethodName = methodName ?? repository.TableName;
        }

        public void Init(dynamic model)
        {
            EagerLoadMany = new EagerLoadMany();

            toTable = Repository.TableName;

            XRefFromColumn = XRefFromColumn ?? SigularId(model);

            XRefToColumn = XRefToColumn ?? SigularId(Repository);

            ToTableColumn = ToTableColumn ?? Id();

            PropertyContainingIdValue = PropertyContainingIdValue ?? Id();

            AddAssociationMethod(model);

            Model = model;
        }

        private void AddAssociationMethod(dynamic model)
        {
            model.SetMember(
                MethodName,
                InnerJoinFor(model));

            model.SetMember(
                Singular(MethodName) + "Ids",
                QueryIds(model));

            model.SetMember("New" + Singular(MethodName), NewItemDelegate());
        }

        private DynamicFunctionWithParam InnerJoinFor(dynamic model)
        {
            return (options) =>
            {
                if (EagerLoadMany.ShouldDiscardCache(options)) EagerLoadMany.Cache = null;

                if (EagerLoadMany.Cache != null) return EagerLoadMany.Cache;

                var models = (Repository.Query(InnerJoinSelectClause(XRefFromColumn, toTable, throughTable, XRefToColumn, ToTableColumn, PropertyContainingIdValue, model)) as IEnumerable<dynamic>).ToList();

                foreach (var m in models) AddReferenceBackToModel(m, model);

                EagerLoadMany.Cache = new DynamicModels(models);

                EagerLoadMany.Cache.SetMember("New", NewItemDelegate());

                return EagerLoadMany.Cache;
            };
        }

        public IEnumerable<dynamic> EagerLoad(IEnumerable<dynamic> models, dynamic options)
        {
            string sql = InnerJoinSelectClause(XRefFromColumn, toTable, throughTable, XRefToColumn, ToTableColumn, PropertyContainingIdValue, models.ToArray());

            return EagerLoadMany.Execute(options, Repository, MethodName, sql, models, XRefFromColumn);
        }

        private DynamicFunction QueryIds(dynamic model)
        {
            return () =>
            {
                IEnumerable<dynamic> models = (InnerJoinFor(model) as DynamicFunctionWithParam).Invoke(null);

                return models.Select(s => s.Id).ToList();
            };
        }
    }

    public class HasManyAndBelongsTo : Association
    {
        public EagerLoadMany EagerLoadMany { get; set; }

        string throughTable;

        DynamicRepository reference;

        string toTable;

        public string XRefTable { get; set; }

        public string XRefToColumn { get; set; }

        public string XRefFromColumn { get; set; }

        public string ToTableColumn { get; set; }

        public string PropertyContainingIdValue { get; set; }

        public HasManyAndBelongsTo(DynamicRepository repository, DynamicRepository reference)
        {
            Repository = repository;

            this.reference = reference;

            var sorted = new[] { repository.TableName, reference.TableName }.OrderBy(s => s);

            throughTable = sorted.First() + sorted.Last();

            MethodName = repository.TableName;
        }

        public void Init(dynamic model)
        {
            EagerLoadMany = new EagerLoadMany();

            throughTable = XRefTable ?? throughTable;

            toTable = Repository.TableName;

            XRefFromColumn = XRefFromColumn ?? SigularId(model);

            XRefToColumn = XRefToColumn ?? SigularId(Repository);

            ToTableColumn = ToTableColumn ?? Id();

            PropertyContainingIdValue = PropertyContainingIdValue ?? Id();

            AddAssociationMethods(model);

            Model = model;
        }

        public void AddAssociationMethods(dynamic model)
        {
            model.SetMember(
                MethodName,
                InnerJoinFor(model));

            model.SetMember(
                Singular(MethodName) + "Ids",
                QueryIds(model));

            model.SetMember("New" + Singular(MethodName), NewItemDelegate());
        }

        private DynamicFunction QueryIds(dynamic model)
        {
            return () =>
            {
                IEnumerable<dynamic> models = (InnerJoinFor(model) as DynamicFunctionWithParam).Invoke(null);

                return models.Select(s => s.Id).ToList();
            };
        }

        private DynamicFunctionWithParam InnerJoinFor(dynamic model)
        {
            return (options) =>
            {
                if (EagerLoadMany.ShouldDiscardCache(options)) EagerLoadMany.Cache = null;

                if (EagerLoadMany.Cache != null) return EagerLoadMany.Cache;

                string innerJoinSelectClause = InnerJoinSelectClause(XRefFromColumn, toTable, throughTable, XRefToColumn, ToTableColumn, PropertyContainingIdValue, model);

                var models = (Repository.Query(innerJoinSelectClause) as IEnumerable<dynamic>).ToList();

                foreach (var m in models) AddReferenceBackToModel(m, model);

                EagerLoadMany.Cache = new DynamicModels(models);

                EagerLoadMany.Cache.SetMember("New", NewItemDelegate());

                AddRepository(EagerLoadMany.Cache, new DynamicRepository(throughTable));

                return EagerLoadMany.Cache;
            };
        }

        public IEnumerable<dynamic> EagerLoad(IEnumerable<dynamic> models, dynamic options)
        {
            var sql = InnerJoinSelectClause(XRefFromColumn, toTable, throughTable, XRefToColumn, ToTableColumn, PropertyContainingIdValue, models.ToArray());

            return EagerLoadMany.Execute(options, Repository, MethodName, sql, models, XRefFromColumn);
        }
    }

    public class HasOne : SingleAssociation
    {
        public string ForeignKey { get; set; }

        public HasOne(DynamicRepository repository)
            : this(repository, null)
        {

        }

        public HasOne(DynamicRepository repository, string methodName)
        {
            this.Repository = repository;

            MethodName = methodName ?? Singular(Repository);
        }

        public void Init(dynamic model)
        {
            model.SetMember(
                MethodName,
                new DynamicFunctionWithParam((options) => GetModelOrCache(model, options)));
        }

        public string ForeignKeyName(dynamic model)
        {
            return string.IsNullOrEmpty(ForeignKey) ? SigularId(model) : ForeignKey;
        }

        public IEnumerable<dynamic> EagerLoad(IEnumerable<dynamic> models, dynamic options)
        {
            var foreignKeyName = ForeignKeyName(models.First()) as string;

            var ones = @"
            select * from {fromTable} 
            where {foreignKey}
            in ({inClause})"
                .Replace("{fromTable}", Repository.TableName)
                .Replace("{foreignKey}", foreignKeyName)
                .Replace("{inClause}", InClause(models, Id()));

            return EagerLoadSingleForAll.Execute(models,
                       Repository,
                       MethodName,
                       ones,
                       (result, source) => source.Id == result.GetMember(foreignKeyName));
        }

        public dynamic GetModelOrCache(dynamic model, dynamic options)
        {
            if (DiscardCache(options)) Model = null;

            if (Model != null) return Model;

            Model = Repository.SingleWhere(ForeignKeyName(model) + " = @0", model.GetMember(Id()));

            return Model;
        }
    }

    public class HasOneThrough : SingleAssociation
    {
        private DynamicRepository through;

        public string XRefToColumn { get; set; }

        public string XRefFromColumn { get; set; }

        public string ToTableColumn { get; set; }

        public string PropertyContainingIdValue { get; set; }

        public HasOneThrough(DynamicRepository repository, DynamicRepository through)
            : this(repository, through, null)
        {
        }

        public HasOneThrough(DynamicRepository repository, DynamicRepository through, string methodName)
        {
            this.Repository = repository;
            this.through = through;
            MethodName = methodName ?? Singular(Repository);
        }

        public void Init(dynamic model)
        {
            XRefFromColumn = XRefFromColumn ?? SigularId(model);

            XRefToColumn = XRefToColumn ?? SigularId(Repository);

            ToTableColumn = ToTableColumn ?? Id();

            PropertyContainingIdValue = PropertyContainingIdValue ?? Id();

            model.SetMember(
                MethodName,
                new DynamicFunctionWithParam((options) => GetModelOrCache(model, options)));
        }

        public dynamic GetModelOrCache(dynamic model, dynamic options)
        {
            if (DiscardCache(options)) Model = null;

            if (Model != null) return Model;

            Model = Query(XRefFromColumn,
                Repository.TableName,
                through.TableName,
                XRefToColumn,
                ToTableColumn,
                PropertyContainingIdValue,
                new List<dynamic>() { model })();

            return Model;
        }

        private DynamicFunction Query(string xRefFromColumn,
            string toTable,
            string xRefTable,
            string xRefToColumn,
            string toTableColumn,
            string propertyContainingIdValue,
            List<dynamic> models)
        {
            return () => Repository.Query(InnerJoinSelectClause(xRefFromColumn,
                                              toTable,
                                              xRefTable,
                                              xRefToColumn,
                                              toTableColumn,
                                              propertyContainingIdValue,
                                              models.ToArray())).FirstOrDefault();
        }

        public IEnumerable<dynamic> EagerLoad(IEnumerable<dynamic> models, dynamic options)
        {
            var xRefFromColumn = XRefFromColumn;

            var sql = InnerJoinSelectClause(xRefFromColumn,
                Repository.TableName,
                through.TableName,
                XRefToColumn,
                ToTableColumn,
                PropertyContainingIdValue, models.ToArray());

            return EagerLoadSingleForAll.Execute(models,
                       Repository,
                       MethodName,
                       sql,
                       (result, source) => source.Id == result.GetMember(xRefFromColumn));
        }
    }

    public class BelongsTo : SingleAssociation
    {
        public string PropertyContainingIdValue { get; set; }

        public string IdColumnOfParentTable { get; set; }

        public BelongsTo(DynamicRepository repository)
            : this(repository, null)
        {

        }

        public BelongsTo(DynamicRepository repository, string methodName)
        {
            this.Repository = repository;

            MethodName = methodName ?? Singular(repository);
        }

        public void Init(dynamic model)
        {
            PropertyContainingIdValue = string.IsNullOrEmpty(PropertyContainingIdValue) ? SigularId(Repository) : PropertyContainingIdValue;

            IdColumnOfParentTable = string.IsNullOrEmpty(IdColumnOfParentTable) ? "Id" : IdColumnOfParentTable;

            model.SetMember(
                MethodName,
                new DynamicFunctionWithParam((options) => GetModelOrCache(model, options)));
        }

        public IEnumerable<dynamic> EagerLoad(IEnumerable<dynamic> models, dynamic options)
        {
            var ones = @"
            select * from {fromTable} 
            where {primaryKey}
            in ({inClause})"
                .Replace("{fromTable}", Repository.TableName)
                .Replace("{primaryKey}", IdColumnOfParentTable)
                .Replace("{inClause}", InClause(models, PropertyContainingIdValue));

            return EagerLoadSingleForAll.Execute(models,
                       Repository,
                       MethodName,
                       ones,
                       (result, source) => result.GetMember(IdColumnOfParentTable) == source.GetMember(PropertyContainingIdValue));
        }

        public dynamic GetModelOrCache(dynamic model, dynamic options)
        {
            if (DiscardCache(options)) Model = null;

            if (Model != null) return Model;

            string whereClause = string.Format("{0} = @0", IdColumnOfParentTable);

            Model = Repository.SingleWhere(whereClause, model.GetMember(PropertyContainingIdValue));

            return Model;
        }
    }

    public class Association : Gemini
    {
        public string MethodName { get; set; }

        public DynamicRepository Repository { get; set; }

        public dynamic Model { get; set; }

        public string TableName
        {
            get { return Repository.TableName; }
        }

        public string Singular(object o)
        {
            var name = o.GetType().Name;

            if (o is string) name = o as string;

            if (!name.EndsWith("s")) return name;

            return name.Substring(0, name.Length - 1);
        }

        public string SigularId(object o)
        {
            return Singular(o) + Id();
        }

        public string Id()
        {
            return Repository.PrimaryKeyField;
        }

        public bool DiscardCache(dynamic options)
        {
            if (options == null) options = new { discardCache = false };

            options = (options as object).ToPrototype();

            return options.discardCache;
        }

        public string InnerJoinSelectClause(string xRefFromColumn,
            string toTable,
            string xRefTable,
            string xRefToColumn,
            string toTableColumn,
            string idProperty,
            params dynamic[] models)
        {
            return @"
            select {toTable}.*, {xRefTable}.{xRefFromColumn}
            from {xRefTable}
            inner join {toTable}
            on {xRefTable}.{xRefToColumn} = {toTable}.{toTableColumn}
            where {xRefTable}.{xRefFromColumn} in ({inClause})"
                .Replace("{xRefFromColumn}", xRefFromColumn)
                .Replace("{toTableColumn}", toTableColumn)
                .Replace("{toTable}", toTable)
                .Replace("{xRefTable}", xRefTable)
                .Replace("{xRefToColumn}", xRefToColumn)
                .Replace("{inClause}", InClause(models, idProperty));
        }

        public void AddReferenceBackToModel(dynamic association, dynamic model)
        {
            association.SetMember(model.GetType().Name, Model);
        }

        public string InClause(IEnumerable<dynamic> models, string member)
        {
            return string.Join(",", models.Select(s => string.Format("'{0}'", s.GetMember(member))).Distinct());
        }

        public virtual void AddRepository(DynamicModels collection, DynamicRepository repository)
        {
            collection.SetMember("Repository", repository);
        }

        public virtual void AddNewAssociationMethod(DynamicModels collection, dynamic model)
        {
            collection.SetMember("New", NewItemDelegate());
        }

        public DynamicFunctionWithParam NewItemDelegate()
        {
            var newItemDelegate = new DynamicFunctionWithParam(attributes =>
            {
                return EntityFor(attributes);
            });

            return newItemDelegate;
        }

        public dynamic EntityFor(dynamic attributes)
        {
            var entity = new Gemini(attributes);

            return Repository.Projection(entity);
        }
    }

    public class SingleAssociation : Association { }

    public class Associations
    {
        List<dynamic> referencedAssociations = new List<dynamic>();

        public Associations(dynamic mixWith)
        {
            if (!SupportsAssociations(mixWith)) return;

            IEnumerable<dynamic> associations = (mixWith as dynamic).Associates();

            foreach (dynamic association in associations)
            {
                referencedAssociations.Add(association);

                association.Init(mixWith);
            }

            mixWith.SetMember("AssociationNamed", new DynamicFunctionWithParam(AssociationNamed));
        }

        public bool SupportsAssociations(dynamic mixWith)
        {
            return mixWith.GetType().GetMethod("Associates") != null || mixWith.RespondsTo("Associates");
        }

        public dynamic AssociationNamed(dynamic collectionName)
        {
            return AssociationNamed(referencedAssociations, collectionName);
        }

        public static dynamic AssociationNamed(List<dynamic> assocationList, string collectionName)
        {
            var association = assocationList.FirstOrDefault(s => s.MethodName == collectionName || s.MethodName == Singularize(collectionName));

            if (association == null) throw new InvalidOperationException("No association named " + collectionName + " exists.");

            return association;
        }

        public static string Singularize(string collectionName)
        {
            if (!collectionName.EndsWith("s")) return collectionName;

            return collectionName.Substring(0, collectionName.Length - 1);
        }
    }

    public class AssociationByConventions
    {
        public static Dictionary<string, bool> TableCache = new Dictionary<string, bool>();
        public static Dictionary<string, List<string>> ColumnCache = new Dictionary<string, List<string>>();
        public static DynamicRepository SchemaRepository = new DynamicRepository();

        List<dynamic> referencedAssociations;
        public AssociationByConventions(dynamic o)
        {
            referencedAssociations = new List<dynamic>();

            o.MethodMissing = new DynamicFunctionWithParam(EntryPoint);
        }

        void InitAssociation(dynamic association, dynamic instance)
        {
            referencedAssociations.Add(association);

            association.Init(instance);
        }

        void AddConvention(dynamic callInfo)
        {
            string associationName = callInfo.Name;

            VerifyAssociationMatchesConvention(callInfo);

            if (IsHasMany(callInfo)) AddConventionForHasMany(callInfo);

            else if (IsManyToMany(callInfo)) AddConventionForManyToMany(callInfo);

            else if (IsHasOneThrough(callInfo)) AddConventionForHasOneThrough(callInfo);

            else if (IsHasOne(callInfo)) AddConventionForHasOne(callInfo);

            else AddConventionForBelongsTo(callInfo);
        }

        dynamic CallAssocationIdsMethod(dynamic callInfo)
        {
            string original = callInfo.Name;

            callInfo.Name = callInfo.Name.Remove(callInfo.Name.Length - 3);

            callInfo.Name = Pluralize(callInfo.Name);

            AddConvention(callInfo);

            return callInfo.Instance.GetMember(original)();
        }

        dynamic CallAssocationNamedMethod(dynamic callInfo)
        {
            callInfo.Name = callInfo.Parameters[0];

            if (!callInfo.Instance.RespondsTo(callInfo.Name)) AddConvention(callInfo);

            return Associations.AssociationNamed(referencedAssociations, callInfo.Name);
        }
        
        dynamic CallNewAssocationMethod(dynamic callInfo)
        {
            string original = callInfo.Name;

            callInfo.Name = callInfo.Name.Substring(3);

            callInfo.Name = Pluralize(callInfo.Name);

            AddConvention(callInfo);

            dynamic parametersToPass = callInfo.Parameter;

            bool containsUnnamedParameters = callInfo.ParameterNames.Length == 0 && callInfo.Parameters.Length != 0;

            if (containsUnnamedParameters) parametersToPass = callInfo.Parameters[0];

            return callInfo.Instance.GetMember(original)(parametersToPass);
        }

        dynamic CallAssociationMethod(dynamic callInfo)
        {
            AddConvention(callInfo);

            return callInfo.Instance.GetMember(callInfo.Name)(null);
        }

        dynamic EntryPoint(dynamic callInfo)
        {
            if (callInfo.Name == "AssociationNamed") return CallAssocationNamedMethod(callInfo);

            if (callInfo.Name.EndsWith("Ids")) return CallAssocationIdsMethod(callInfo);

            if (callInfo.Name.StartsWith("New")) return CallNewAssocationMethod(callInfo);

            return CallAssociationMethod(callInfo);
        }

        public static void ApplyProjection(dynamic repository, string connectionString)
        {
            repository.Projection = new Func<dynamic, dynamic>(d =>
            {
                d.Extend<AssociationByConventions>();
                d.__Table__ = new DynamicFunction(() => repository.TableName);
                d.__ConnectionString__ =  new DynamicFunction(() => connectionString);
                return d;
            });
        }

        public static DynamicRepository RepositoryFor(string tableName, string connectionString)
        {
            var repo = new DynamicRepository(new ConnectionProfile { ConnectionString = connectionString }, tableName);

            AssociationByConventions.ApplyProjection(repo, connectionString);

            return repo;
        }

        void AddConventionForHasMany(dynamic callInfo)
        {
            var repoOnTheFly = RepositoryFor(callInfo.Name, callInfo.Instance.__ConnectionString__());

            var hasMany = new HasMany(repoOnTheFly);

            if (callInfo.Instance.RespondsTo("__Table__")) hasMany.ForeignKey = ParentKey(callInfo);

            InitAssociation(hasMany, callInfo.Instance);
        }

        void AddConventionForHasOne(dynamic callInfo)
        {
            var repository = RepositoryFor(Pluralize(callInfo.Name), callInfo.Instance.__ConnectionString__());

            var hasOne = new HasOne(repository, callInfo.Name);

            hasOne.ForeignKey = "Id";

            InitAssociation(hasOne, callInfo.Instance);
        }

        void AddConventionForBelongsTo(dynamic callInfo)
        {
            var repository = RepositoryFor(Pluralize(callInfo.Name), callInfo.Instance.__ConnectionString__());

            var belongsTo = new BelongsTo(repository, callInfo.Name);

            belongsTo.PropertyContainingIdValue = ChildKey(callInfo);

            InitAssociation(belongsTo, callInfo.Instance);
        }

        void AddConventionForHasOneThrough(dynamic callInfo)
        {
            var repo = RepositoryFor(Pluralize(callInfo.Name), callInfo.Instance.__ConnectionString__());

            var throughRepo = RepositoryFor(ManyToManyTableName(callInfo), callInfo.Instance.__ConnectionString__());

            var hasOneThrough = new HasOneThrough(repo, throughRepo, callInfo.Name);

            hasOneThrough.XRefFromColumn = ParentKey(callInfo);

            hasOneThrough.XRefToColumn = ChildKey(callInfo);

            InitAssociation(hasOneThrough, callInfo.Instance);
        }

        void AddConventionForManyToMany(dynamic callInfo)
        {
            var repo = RepositoryFor(callInfo.Name, callInfo.Instance.__ConnectionString__());

            var referenceRepo = RepositoryFor(callInfo.Instance.__Table__(), callInfo.Instance.__ConnectionString__());

            var manyToMany = new HasManyAndBelongsTo(repo, referenceRepo);

            manyToMany.XRefFromColumn = ParentKey(callInfo);

            manyToMany.XRefToColumn = ChildKey(callInfo);

            InitAssociation(manyToMany, callInfo.Instance);
        }

        bool IsPlural(string word)
        {
            return word.EndsWith("s");
        }

        void VerifyAssociationMatchesForMany(dynamic callInfo)
        {
            var message =
@"No HasMany or HasManyAndBelongsTo relationships found:
Table [{0}] with column [{1}] doesn't exist (HasMany).
Table [{2}] with schema [Id, {3}, {4}] doesn't exist (HasManyAndBelongsTo).";

            var mergedMessage = string.Format(
                message,
                callInfo.Name,
                ParentKey(callInfo),
                ManyToManyTableName(callInfo),
                ParentKey(callInfo),
                ChildKey(callInfo)
            );

            bool tableExists = TableExists(callInfo.Name, callInfo.Instance.__ConnectionString__());

            bool oneToManyColumnExists = ColumnsFor(callInfo.Name).Contains(ParentKey(callInfo));

            if (!tableExists) throw new AssociationByConventionsException(mergedMessage);

            if (!oneToManyColumnExists && !ManyToManyColumnsExist(callInfo)) throw new AssociationByConventionsException(mergedMessage);
        }

        bool ManyToManyColumnsExist(dynamic callInfo)
        {
            bool manyToManyColumn1Exists = ColumnsFor(ManyToManyTableName(callInfo)).Contains(ParentKey(callInfo));

            bool manyToManyColumn2Exists = ColumnsFor(ManyToManyTableName(callInfo)).Contains(ChildKey(callInfo));

            return manyToManyColumn1Exists && manyToManyColumn2Exists;
        }

        void VerifyAssocationMatchesForOne(dynamic callInfo)
        {
            var message =
@"No BelongsTo, HasOneThrough or HasOne relationships found:
Table [{0}] with column [{1}] doesn't exist (HasOne).
Table [{2}] with column [{3}] doesn't exist (BelongsTo).
Table [{4}] with schema [Id, {3}, {1}] doesn't exist (HasOneThrough).";

            var mergedMessage = string.Format(
                message,
                Pluralize(callInfo.Name),
                ParentKey(callInfo),
                callInfo.Instance.__Table__(),
                ChildKey(callInfo),
                ManyToManyTableName(callInfo)
            );

            var pluralizedTable = Pluralize(callInfo.Name);

            bool tableExists = TableExists(pluralizedTable, callInfo.Instance.__ConnectionString__());

            bool foreignKeyOnMainTableExists = ColumnsFor(callInfo.Instance.__Table__()).Contains(ChildKey(callInfo));

            bool foreignKeyOnChildTableExists = ColumnsFor(pluralizedTable).Contains(ParentKey(callInfo));

            if (!tableExists) throw new AssociationByConventionsException(mergedMessage);

            if (!foreignKeyOnMainTableExists &&
                !foreignKeyOnChildTableExists &&
                !ManyToManyColumnsExist(callInfo)) throw new AssociationByConventionsException(mergedMessage);
        }

        void VerifyAssociationMatchesConvention(dynamic callInfo)
        {
            if (IsPlural(callInfo.Name)) VerifyAssociationMatchesForMany(callInfo);

            else VerifyAssocationMatchesForOne(callInfo);
        }

        string ParentKey(dynamic callInfo)
        {
            return Associations.Singularize(callInfo.Instance.__Table__()) + "Id";
        }

        string ChildKey(dynamic callInfo)
        {
            return Associations.Singularize(callInfo.Name) + "Id";
        }

        bool IsHasMany(dynamic callInfo)
        {
            var foreignKey = ParentKey(callInfo);

            return IsPlural(callInfo.Name) && ColumnsFor(callInfo.Name).Contains(foreignKey);
        }

        bool IsHasOneThrough(dynamic callInfo)
        {
            return !IsPlural(callInfo.Name) && TableExists(ManyToManyTableName(callInfo), callInfo.Instance.__ConnectionString__());
        }

        bool IsManyToMany(dynamic callInfo)
        {
            return IsPlural(callInfo.Name) && TableExists(ManyToManyTableName(callInfo), callInfo.Instance.__ConnectionString__());
        }

        string Pluralize(string word)
        {
            if (IsPlural(word)) return word;

            return word + "s";
        }

        string ManyToManyTableName(dynamic callInfo)
        {
            var names = new string[] 
                {
                    Pluralize(callInfo.Instance.__Table__()), 
                    Pluralize(callInfo.Name)
                }.OrderBy(s => s);

            return string.Join("", names);
        }

        bool IsHasOne(dynamic callInfo)
        {
            return !IsPlural(callInfo.Name) && !callInfo.Instance.RespondsTo(callInfo.Name + "Id");
        }

        List<string> ColumnsFor(string table)
        {
            if (!ColumnCache.ContainsKey(table))
            {
                var columns = SchemaRepository
                    .Query("select name from syscolumns where id = object_id(@0)", table)
                    .Select(s => (string)s.Name)
                    .ToList();

                ColumnCache.Add(table, columns);
            }

            return ColumnCache[table];
        }

        public static bool TableExists(string table, string connectionString)
        {
            SchemaRepository.ConnectionProfile.ConnectionString = connectionString;

            if (!TableCache.ContainsKey(table))
            {
                var exists = SchemaRepository
                    .Query("select name from sysobjects where name = @0", table)
                    .Any();

                TableCache.Add(table, exists);
            }

            return TableCache[table];
        }
    }

    public class AssociationByConventionsException : Exception
    {
        public AssociationByConventionsException(string message) : base(message) { }
    }

    public class EagerLoadSingleForAll
    {
        static void ConvertToList(string property, dynamic inObject)
        {
            if (inObject.GetMember(property) is List<dynamic>) return;

            var newPropValue = new List<dynamic>();
            newPropValue.Add(inObject.GetMember(property));
            inObject.SetMember(property, newPropValue);
        }

        public static DynamicModels Execute(IEnumerable<dynamic> models,
            DynamicRepository repository,
            string associationName,
            string sql,
            Func<dynamic, dynamic, bool> findClause)
        {
            var belongsResult = new List<dynamic>(repository.Query(sql));

            foreach (var item in belongsResult)
            {
                var relatedModels = models.Where(s => findClause(item, s));

                foreach (var relateModel in relatedModels)
                {
                    var association = relateModel.AssociationNamed(associationName);

                    association.Model = item;

                    var propName = relateModel.GetType().Name;

                    if (item.RespondsTo(propName))
                    {
                        ConvertToList(propName, item);

                        item.GetMember(propName).Add(relateModel);
                    }
                    else
                    {
                        item.SetMember(propName, relateModel);
                    }
                }
            }

            return new DynamicModels(belongsResult);
        }
    }

    public class EagerLoadMany
    {
        public DynamicModels Cache { get; set; }

        public bool ShouldDiscardCache(dynamic options)
        {
            if (options == null) options = new { discardCache = false };

            options = (options as object).ToPrototype();

            return options.discardCache;
        }

        public DynamicModels Execute(dynamic options,
            DynamicRepository repository,
            string associationName,
            string selectClause,
            IEnumerable<dynamic> models,
            string parentMemberName)
        {
            if (ShouldDiscardCache(options)) Cache = null;

            if (Cache != null) return Cache;

            var many = repository.Query(selectClause).ToList();

            foreach (var item in many)
            {
                var model = models.First(s => s.Id == item.GetMember(parentMemberName));

                item.SetMember(model.GetType().Name, model);
            }

            foreach (var model in models)
            {
                var assocation = model.AssociationNamed(associationName);

                var relatedTo = many.Where(s => s.GetMember(model.GetType().Name).Equals(model)).Select(s => s);

                assocation.EagerLoadMany.Cache = new DynamicModels(relatedTo);

                assocation.AddNewAssociationMethod(assocation.EagerLoadMany.Cache, model);
            }

            return new DynamicModels(many);
        }
    }
}
