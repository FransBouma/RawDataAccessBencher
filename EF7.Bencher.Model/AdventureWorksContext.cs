using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EF7.Bencher.Model
{
	public partial class AdventureWorksContext : DbContext
	{
		private string _connectionString = string.Empty;


		public AdventureWorksContext(string connectionString) : base()
		{
			_connectionString = connectionString;
		}


		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			options.UseSqlServer(_connectionString);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AWBuildVersion>(entity =>
			{
				entity.HasKey(e => e.SystemInformationID);

				entity.Property(e => e.Database_Version)
					.IsRequired()
					.HasMaxLength(25)
					.HasColumnName("Database Version");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.VersionDate).HasColumnType("datetime");
			});

			modelBuilder.Entity<Address>(entity =>
			{
				entity.ToTable("Address", "Person");

				entity.HasIndex(e => e.StateProvinceID).HasName("IX_Address_StateProvinceID");

				entity.HasIndex(e => e.rowguid).HasName("AK_Address_rowguid").IsUnique();

				entity.HasIndex(e => new { e.AddressLine1, e.AddressLine2, e.City, e.StateProvinceID, e.PostalCode }).HasName("IX_Address_AddressLine1_AddressLine2_City_StateProvinceID_PostalCode").IsUnique();

				entity.Property(e => e.AddressLine1)
					.IsRequired()
					.HasMaxLength(60);

				entity.Property(e => e.AddressLine2).HasMaxLength(60);

				entity.Property(e => e.City)
					.IsRequired()
					.HasMaxLength(30);

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.PostalCode)
					.IsRequired()
					.HasMaxLength(15);

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");

				entity.HasOne(d => d.StateProvince).WithMany(p => p.Address).HasForeignKey(d => d.StateProvinceID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<AddressType>(entity =>
			{
				entity.ToTable("AddressType", "Person");

				entity.HasIndex(e => e.rowguid).HasName("AK_AddressType_rowguid").IsUnique();
				entity.Property(e => e.Name)
					.HasMaxLength(50);
				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");
			});

			modelBuilder.Entity<BillOfMaterials>(entity =>
			{
				entity.ToTable("BillOfMaterials", "Production");

				entity.HasIndex(e => e.UnitMeasureCode).HasName("IX_BillOfMaterials_UnitMeasureCode");

				entity.HasIndex(e => new { e.ProductAssemblyID, e.ComponentID, e.StartDate }).HasName("AK_BillOfMaterials_ProductAssemblyID_ComponentID_StartDate").IsUnique();

				entity.Property(e => e.EndDate).HasColumnType("datetime");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.PerAssemblyQty).HasColumnType("decimal");

				entity.Property(e => e.StartDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.UnitMeasureCode)
					.IsRequired()
					.HasMaxLength(3);

				entity.HasOne(d => d.Component).WithMany(p => p.BillOfMaterials).HasForeignKey(d => d.ComponentID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.ProductAssembly).WithMany(p => p.BillOfMaterialsNavigation).HasForeignKey(d => d.ProductAssemblyID);

				entity.HasOne(d => d.UnitMeasureCodeNavigation).WithMany(p => p.BillOfMaterials).HasForeignKey(d => d.UnitMeasureCode).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<BusinessEntity>(entity =>
			{
				entity.ToTable("BusinessEntity", "Person");

				entity.HasIndex(e => e.rowguid).HasName("AK_BusinessEntity_rowguid").IsUnique();

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");
			});

			modelBuilder.Entity<BusinessEntityAddress>(entity =>
			{
				entity.HasKey(e => new { e.BusinessEntityID, e.AddressID, e.AddressTypeID });

				entity.ToTable("BusinessEntityAddress", "Person");

				entity.HasIndex(e => e.AddressID).HasName("IX_BusinessEntityAddress_AddressID");

				entity.HasIndex(e => e.AddressTypeID).HasName("IX_BusinessEntityAddress_AddressTypeID");

				entity.HasIndex(e => e.rowguid).HasName("AK_BusinessEntityAddress_rowguid").IsUnique();

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");

				entity.HasOne(d => d.Address).WithMany(p => p.BusinessEntityAddress).HasForeignKey(d => d.AddressID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.AddressType).WithMany(p => p.BusinessEntityAddress).HasForeignKey(d => d.AddressTypeID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.BusinessEntity).WithMany(p => p.BusinessEntityAddress).HasForeignKey(d => d.BusinessEntityID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<BusinessEntityContact>(entity =>
			{
				entity.HasKey(e => new { e.BusinessEntityID, e.PersonID, e.ContactTypeID });

				entity.ToTable("BusinessEntityContact", "Person");

				entity.HasIndex(e => e.ContactTypeID).HasName("IX_BusinessEntityContact_ContactTypeID");

				entity.HasIndex(e => e.PersonID).HasName("IX_BusinessEntityContact_PersonID");

				entity.HasIndex(e => e.rowguid).HasName("AK_BusinessEntityContact_rowguid").IsUnique();

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");

				entity.HasOne(d => d.BusinessEntity).WithMany(p => p.BusinessEntityContact).HasForeignKey(d => d.BusinessEntityID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.ContactType).WithMany(p => p.BusinessEntityContact).HasForeignKey(d => d.ContactTypeID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.Person).WithMany(p => p.BusinessEntityContact).HasForeignKey(d => d.PersonID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<ContactType>(entity =>
			{
				entity.ToTable("ContactType", "Person");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");
			});

			modelBuilder.Entity<CountryRegion>(entity =>
			{
				entity.HasKey(e => e.CountryRegionCode);

				entity.ToTable("CountryRegion", "Person");

				entity.Property(e => e.CountryRegionCode).HasMaxLength(3);

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");
			});

			modelBuilder.Entity<CountryRegionCurrency>(entity =>
			{
				entity.HasKey(e => new { e.CountryRegionCode, e.CurrencyCode });

				entity.ToTable("CountryRegionCurrency", "Sales");

				entity.HasIndex(e => e.CurrencyCode).HasName("IX_CountryRegionCurrency_CurrencyCode");

				entity.Property(e => e.CountryRegionCode).HasMaxLength(3);

				entity.Property(e => e.CurrencyCode)
					.HasMaxLength(3);

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.HasOne(d => d.CountryRegionCodeNavigation).WithMany(p => p.CountryRegionCurrency).HasForeignKey(d => d.CountryRegionCode).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.CurrencyCodeNavigation).WithMany(p => p.CountryRegionCurrency).HasForeignKey(d => d.CurrencyCode).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<CreditCard>(entity =>
			{
				entity.ToTable("CreditCard", "Sales");

				entity.HasIndex(e => e.CardNumber).HasName("AK_CreditCard_CardNumber").IsUnique();

				entity.Property(e => e.CardNumber)
					.IsRequired()
					.HasMaxLength(25);

				entity.Property(e => e.CardType)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");
			});

			modelBuilder.Entity<Culture>(entity =>
			{
				entity.ToTable("Culture", "Production");

				entity.Property(e => e.CultureID)
					.HasMaxLength(6);

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");
			});

			modelBuilder.Entity<Currency>(entity =>
			{
				entity.HasKey(e => e.CurrencyCode);

				entity.ToTable("Currency", "Sales");

				entity.Property(e => e.CurrencyCode)
					.HasMaxLength(3);

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");
			});

			modelBuilder.Entity<CurrencyRate>(entity =>
			{
				entity.ToTable("CurrencyRate", "Sales");

				entity.HasIndex(e => new { e.CurrencyRateDate, e.FromCurrencyCode, e.ToCurrencyCode }).HasName("AK_CurrencyRate_CurrencyRateDate_FromCurrencyCode_ToCurrencyCode").IsUnique();

				entity.Property(e => e.AverageRate).HasColumnType("money");

				entity.Property(e => e.CurrencyRateDate).HasColumnType("datetime");

				entity.Property(e => e.EndOfDayRate).HasColumnType("money");

				entity.Property(e => e.FromCurrencyCode)
					.IsRequired()
					.HasMaxLength(3);

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.ToCurrencyCode)
					.IsRequired()
					.HasMaxLength(3);

				entity.HasOne(d => d.FromCurrencyCodeNavigation).WithMany(p => p.CurrencyRate).HasForeignKey(d => d.FromCurrencyCode).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.ToCurrencyCodeNavigation).WithMany(p => p.CurrencyRateNavigation).HasForeignKey(d => d.ToCurrencyCode).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<Customer>(entity =>
			{
				entity.ToTable("Customer", "Sales");

				entity.HasIndex(e => e.AccountNumber).HasName("AK_Customer_AccountNumber").IsUnique();

				entity.HasIndex(e => e.TerritoryID).HasName("IX_Customer_TerritoryID");

				entity.HasIndex(e => e.rowguid).HasName("AK_Customer_rowguid").IsUnique();

				entity.Property(e => e.AccountNumber)
					.IsRequired()
					.HasMaxLength(10)
					.ValueGeneratedOnAddOrUpdate();

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");

				entity.HasOne(d => d.Person).WithMany(p => p.Customer).HasForeignKey(d => d.PersonID);

				entity.HasOne(d => d.Store).WithMany(p => p.Customer).HasForeignKey(d => d.StoreID);

				entity.HasOne(d => d.Territory).WithMany(p => p.Customer).HasForeignKey(d => d.TerritoryID);
			});

			modelBuilder.Entity<DatabaseLog>(entity =>
			{
				entity.Property(e => e.PostTime).HasColumnType("datetime");

				entity.Property(e => e.TSQL).IsRequired();
			});

			modelBuilder.Entity<Department>(entity =>
			{
				entity.ToTable("Department", "HumanResources");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");
			});

			modelBuilder.Entity<EmailAddress>(entity =>
			{
				entity.HasKey(e => new { e.BusinessEntityID, e.EmailAddressID });

				entity.ToTable("EmailAddress", "Person");

				entity.HasIndex(e => e.EmailAddress1).HasName("IX_EmailAddress_EmailAddress");

				entity.Property(e => e.EmailAddressID).ValueGeneratedOnAdd();

				entity.Property(e => e.EmailAddress1).HasMaxLength(50);

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");

				entity.HasOne(d => d.BusinessEntity).WithMany(p => p.EmailAddress).HasForeignKey(d => d.BusinessEntityID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<Employee>(entity =>
			{
				entity.HasKey(e => e.BusinessEntityID);

				entity.ToTable("Employee", "HumanResources");

				entity.HasIndex(e => e.LoginID).HasName("AK_Employee_LoginID").IsUnique();

				entity.HasIndex(e => e.NationalIDNumber).HasName("AK_Employee_NationalIDNumber").IsUnique();

				entity.HasIndex(e => e.rowguid).HasName("AK_Employee_rowguid").IsUnique();

				entity.Property(e => e.BusinessEntityID).ValueGeneratedNever();

				entity.Property(e => e.BirthDate).HasColumnType("date");

				entity.Property(e => e.Gender)
					.IsRequired()
					.HasMaxLength(1);

				entity.Property(e => e.HireDate).HasColumnType("date");

				entity.Property(e => e.JobTitle)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.LoginID)
					.IsRequired()
					.HasMaxLength(256);

				entity.Property(e => e.MaritalStatus)
					.IsRequired()
					.HasMaxLength(1);

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.NationalIDNumber)
					.IsRequired()
					.HasMaxLength(15);

				entity.Property(e => e.OrganizationLevel).ValueGeneratedOnAddOrUpdate();

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");

				entity.Property(e => e.SickLeaveHours).HasDefaultValue((short)0);

				entity.Property(e => e.VacationHours).HasDefaultValue((short)0);

				entity.HasOne(d => d.BusinessEntity).WithOne(p => p.Employee).HasForeignKey<Employee>(d => d.BusinessEntityID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<EmployeeDepartmentHistory>(entity =>
			{
				entity.HasKey(e => new { e.BusinessEntityID, e.StartDate, e.DepartmentID, e.ShiftID });

				entity.ToTable("EmployeeDepartmentHistory", "HumanResources");

				entity.HasIndex(e => e.DepartmentID).HasName("IX_EmployeeDepartmentHistory_DepartmentID");

				entity.HasIndex(e => e.ShiftID).HasName("IX_EmployeeDepartmentHistory_ShiftID");

				entity.Property(e => e.StartDate).HasColumnType("date");

				entity.Property(e => e.EndDate).HasColumnType("date");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.HasOne(d => d.BusinessEntity).WithMany(p => p.EmployeeDepartmentHistory).HasForeignKey(d => d.BusinessEntityID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.Department).WithMany(p => p.EmployeeDepartmentHistory).HasForeignKey(d => d.DepartmentID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.Shift).WithMany(p => p.EmployeeDepartmentHistory).HasForeignKey(d => d.ShiftID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<EmployeePayHistory>(entity =>
			{
				entity.HasKey(e => new { e.BusinessEntityID, e.RateChangeDate });

				entity.ToTable("EmployeePayHistory", "HumanResources");

				entity.Property(e => e.RateChangeDate).HasColumnType("datetime");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.Rate).HasColumnType("money");

				entity.HasOne(d => d.BusinessEntity).WithMany(p => p.EmployeePayHistory).HasForeignKey(d => d.BusinessEntityID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<ErrorLog>(entity =>
			{
				entity.Property(e => e.ErrorMessage).IsRequired();

				entity.Property(e => e.ErrorProcedure).HasMaxLength(126);

				entity.Property(e => e.ErrorTime)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");
			});

			modelBuilder.Entity<Illustration>(entity =>
			{
				entity.ToTable("Illustration", "Production");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");
			});

			modelBuilder.Entity<JobCandidate>(entity =>
			{
				entity.ToTable("JobCandidate", "HumanResources");

				entity.HasIndex(e => e.BusinessEntityID).HasName("IX_JobCandidate_BusinessEntityID");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.HasOne(d => d.BusinessEntity).WithMany(p => p.JobCandidate).HasForeignKey(d => d.BusinessEntityID);
			});

			modelBuilder.Entity<Location>(entity =>
			{
				entity.ToTable("Location", "Production");

				entity.Property(e => e.Availability).HasColumnType("decimal");

				entity.Property(e => e.CostRate).HasColumnType("smallmoney");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");
			});

			modelBuilder.Entity<Password>(entity =>
			{
				entity.HasKey(e => e.BusinessEntityID);

				entity.ToTable("Password", "Person");

				entity.Property(e => e.BusinessEntityID).ValueGeneratedNever();

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.PasswordHash)
					.IsRequired()
					.HasMaxLength(128)
;

				entity.Property(e => e.PasswordSalt)
					.IsRequired()
					.HasMaxLength(10)
;

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");

				entity.HasOne(d => d.BusinessEntity).WithOne(p => p.Password).HasForeignKey<Password>(d => d.BusinessEntityID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<Person>(entity =>
			{
				entity.HasKey(e => e.BusinessEntityID);

				entity.ToTable("Person", "Person");

				entity.HasIndex(e => e.rowguid).HasName("AK_Person_rowguid").IsUnique();

				entity.Property(e => e.BusinessEntityID).ValueGeneratedNever();

				entity.Property(e => e.EmailPromotion).HasDefaultValue(0);

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.PersonType)
					.IsRequired()
					.HasMaxLength(2);

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");

				entity.Property(e => e.Suffix).HasMaxLength(10);

				entity.Property(e => e.Title).HasMaxLength(8);

				entity.HasOne(d => d.BusinessEntity).WithOne(p => p.Person).HasForeignKey<Person>(d => d.BusinessEntityID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<PersonCreditCard>(entity =>
			{
				entity.HasKey(e => new { e.BusinessEntityID, e.CreditCardID });

				entity.ToTable("PersonCreditCard", "Sales");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.HasOne(d => d.BusinessEntity).WithMany(p => p.PersonCreditCard).HasForeignKey(d => d.BusinessEntityID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.CreditCard).WithMany(p => p.PersonCreditCard).HasForeignKey(d => d.CreditCardID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<PhoneNumberType>(entity =>
			{
				entity.ToTable("PhoneNumberType", "Person");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");
			});

			modelBuilder.Entity<Product>(entity =>
			{
				entity.ToTable("Product", "Production");

				entity.HasIndex(e => e.ProductNumber).HasName("AK_Product_ProductNumber").IsUnique();

				entity.HasIndex(e => e.rowguid).HasName("AK_Product_rowguid").IsUnique();

				entity.Property(e => e.Class)
					.HasMaxLength(2);

				entity.Property(e => e.Color).HasMaxLength(15);

				entity.Property(e => e.DiscontinuedDate).HasColumnType("datetime");

				entity.Property(e => e.ListPrice).HasColumnType("money");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.ProductLine)
					.HasMaxLength(2);

				entity.Property(e => e.ProductNumber)
					.IsRequired()
					.HasMaxLength(25);

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");

				entity.Property(e => e.SellEndDate).HasColumnType("datetime");

				entity.Property(e => e.SellStartDate).HasColumnType("datetime");

				entity.Property(e => e.Size).HasMaxLength(5);

				entity.Property(e => e.SizeUnitMeasureCode)
					.HasMaxLength(3);

				entity.Property(e => e.StandardCost).HasColumnType("money");

				entity.Property(e => e.Style)
					.HasMaxLength(2);

				entity.Property(e => e.Weight).HasColumnType("decimal");

				entity.Property(e => e.WeightUnitMeasureCode)
					.HasMaxLength(3);

				entity.HasOne(d => d.ProductModel).WithMany(p => p.Product).HasForeignKey(d => d.ProductModelID);

				entity.HasOne(d => d.ProductSubcategory).WithMany(p => p.Product).HasForeignKey(d => d.ProductSubcategoryID);

				entity.HasOne(d => d.SizeUnitMeasureCodeNavigation).WithMany(p => p.Product).HasForeignKey(d => d.SizeUnitMeasureCode);

				entity.HasOne(d => d.WeightUnitMeasureCodeNavigation).WithMany(p => p.ProductNavigation).HasForeignKey(d => d.WeightUnitMeasureCode);
			});

			modelBuilder.Entity<ProductCategory>(entity =>
			{
				entity.ToTable("ProductCategory", "Production");

				entity.HasIndex(e => e.rowguid).HasName("AK_ProductCategory_rowguid").IsUnique();

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");
			});

			modelBuilder.Entity<ProductCostHistory>(entity =>
			{
				entity.HasKey(e => new { e.ProductID, e.StartDate });

				entity.ToTable("ProductCostHistory", "Production");

				entity.Property(e => e.StartDate).HasColumnType("datetime");

				entity.Property(e => e.EndDate).HasColumnType("datetime");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.StandardCost).HasColumnType("money");

				entity.HasOne(d => d.Product).WithMany(p => p.ProductCostHistory).HasForeignKey(d => d.ProductID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<ProductDescription>(entity =>
			{
				entity.ToTable("ProductDescription", "Production");

				entity.HasIndex(e => e.rowguid).HasName("AK_ProductDescription_rowguid").IsUnique();

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(400);

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");
			});

			modelBuilder.Entity<ProductInventory>(entity =>
			{
				entity.HasKey(e => new { e.ProductID, e.LocationID });

				entity.ToTable("ProductInventory", "Production");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.Quantity).HasDefaultValue((short)0);

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");

				entity.Property(e => e.Shelf)
					.IsRequired()
					.HasMaxLength(10);

				entity.HasOne(d => d.Location).WithMany(p => p.ProductInventory).HasForeignKey(d => d.LocationID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.Product).WithMany(p => p.ProductInventory).HasForeignKey(d => d.ProductID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<ProductListPriceHistory>(entity =>
			{
				entity.HasKey(e => new { e.ProductID, e.StartDate });

				entity.ToTable("ProductListPriceHistory", "Production");

				entity.Property(e => e.StartDate).HasColumnType("datetime");

				entity.Property(e => e.EndDate).HasColumnType("datetime");

				entity.Property(e => e.ListPrice).HasColumnType("money");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.HasOne(d => d.Product).WithMany(p => p.ProductListPriceHistory).HasForeignKey(d => d.ProductID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<ProductModel>(entity =>
			{
				entity.ToTable("ProductModel", "Production");

				entity.HasIndex(e => e.rowguid).HasName("AK_ProductModel_rowguid").IsUnique();

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");
			});

			modelBuilder.Entity<ProductModelIllustration>(entity =>
			{
				entity.HasKey(e => new { e.ProductModelID, e.IllustrationID });

				entity.ToTable("ProductModelIllustration", "Production");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.HasOne(d => d.Illustration).WithMany(p => p.ProductModelIllustration).HasForeignKey(d => d.IllustrationID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.ProductModel).WithMany(p => p.ProductModelIllustration).HasForeignKey(d => d.ProductModelID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<ProductModelProductDescriptionCulture>(entity =>
			{
				entity.HasKey(e => new { e.ProductModelID, e.ProductDescriptionID, e.CultureID });

				entity.ToTable("ProductModelProductDescriptionCulture", "Production");

				entity.Property(e => e.CultureID)
					.HasMaxLength(6);

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.HasOne(d => d.Culture).WithMany(p => p.ProductModelProductDescriptionCulture).HasForeignKey(d => d.CultureID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.ProductDescription).WithMany(p => p.ProductModelProductDescriptionCulture).HasForeignKey(d => d.ProductDescriptionID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.ProductModel).WithMany(p => p.ProductModelProductDescriptionCulture).HasForeignKey(d => d.ProductModelID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<ProductPhoto>(entity =>
			{
				entity.ToTable("ProductPhoto", "Production");

				entity.Property(e => e.LargePhoto);

				entity.Property(e => e.LargePhotoFileName).HasMaxLength(50);

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.ThumbNailPhoto);

				entity.Property(e => e.ThumbnailPhotoFileName).HasMaxLength(50);
			});

			modelBuilder.Entity<ProductProductPhoto>(entity =>
			{
				entity.HasKey(e => new { e.ProductID, e.ProductPhotoID });

				entity.ToTable("ProductProductPhoto", "Production");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.HasOne(d => d.Product).WithMany(p => p.ProductProductPhoto).HasForeignKey(d => d.ProductID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.ProductPhoto).WithMany(p => p.ProductProductPhoto).HasForeignKey(d => d.ProductPhotoID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<ProductReview>(entity =>
			{
				entity.ToTable("ProductReview", "Production");

				entity.Property(e => e.Comments).HasMaxLength(3850);

				entity.Property(e => e.EmailAddress)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.ReviewDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.HasOne(d => d.Product).WithMany(p => p.ProductReview).HasForeignKey(d => d.ProductID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<ProductSubcategory>(entity =>
			{
				entity.ToTable("ProductSubcategory", "Production");

				entity.HasIndex(e => e.rowguid).HasName("AK_ProductSubcategory_rowguid").IsUnique();

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");

				entity.HasOne(d => d.ProductCategory).WithMany(p => p.ProductSubcategory).HasForeignKey(d => d.ProductCategoryID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<ProductVendor>(entity =>
			{
				entity.HasKey(e => new { e.ProductID, e.BusinessEntityID });

				entity.ToTable("ProductVendor", "Purchasing");

				entity.HasIndex(e => e.BusinessEntityID).HasName("IX_ProductVendor_BusinessEntityID");

				entity.HasIndex(e => e.UnitMeasureCode).HasName("IX_ProductVendor_UnitMeasureCode");

				entity.Property(e => e.LastReceiptCost).HasColumnType("money");

				entity.Property(e => e.LastReceiptDate).HasColumnType("datetime");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.StandardPrice).HasColumnType("money");

				entity.Property(e => e.UnitMeasureCode)
					.IsRequired()
					.HasMaxLength(3);

				entity.HasOne(d => d.BusinessEntity).WithMany(p => p.ProductVendor).HasForeignKey(d => d.BusinessEntityID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.Product).WithMany(p => p.ProductVendor).HasForeignKey(d => d.ProductID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.UnitMeasureCodeNavigation).WithMany(p => p.ProductVendor).HasForeignKey(d => d.UnitMeasureCode).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<PurchaseOrderDetail>(entity =>
			{
				entity.HasKey(e => new { e.PurchaseOrderID, e.PurchaseOrderDetailID });

				entity.ToTable("PurchaseOrderDetail", "Purchasing");

				entity.HasIndex(e => e.ProductID).HasName("IX_PurchaseOrderDetail_ProductID");

				entity.Property(e => e.PurchaseOrderDetailID).ValueGeneratedOnAdd();

				entity.Property(e => e.DueDate).HasColumnType("datetime");

				entity.Property(e => e.LineTotal)
					.HasColumnType("money")
					.ValueGeneratedOnAddOrUpdate();

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.ReceivedQty).HasColumnType("decimal");

				entity.Property(e => e.RejectedQty).HasColumnType("decimal");

				entity.Property(e => e.StockedQty)
					.HasColumnType("decimal")
					.ValueGeneratedOnAddOrUpdate();

				entity.Property(e => e.UnitPrice).HasColumnType("money");

				entity.HasOne(d => d.Product).WithMany(p => p.PurchaseOrderDetail).HasForeignKey(d => d.ProductID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.PurchaseOrderDetail).HasForeignKey(d => d.PurchaseOrderID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<PurchaseOrderHeader>(entity =>
			{
				entity.HasKey(e => e.PurchaseOrderID);

				entity.ToTable("PurchaseOrderHeader", "Purchasing");

				entity.HasIndex(e => e.EmployeeID).HasName("IX_PurchaseOrderHeader_EmployeeID");

				entity.HasIndex(e => e.VendorID).HasName("IX_PurchaseOrderHeader_VendorID");

				entity.Property(e => e.Freight).HasColumnType("money");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.OrderDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.RevisionNumber).HasDefaultValue((byte)0);

				entity.Property(e => e.ShipDate).HasColumnType("datetime");

				entity.Property(e => e.Status).HasDefaultValue((byte)1);

				entity.Property(e => e.SubTotal).HasColumnType("money");

				entity.Property(e => e.TaxAmt).HasColumnType("money");

				entity.Property(e => e.TotalDue)
					.HasColumnType("money")
					.ValueGeneratedOnAddOrUpdate();

				entity.HasOne(d => d.Employee).WithMany(p => p.PurchaseOrderHeader).HasForeignKey(d => d.EmployeeID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.ShipMethod).WithMany(p => p.PurchaseOrderHeader).HasForeignKey(d => d.ShipMethodID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.Vendor).WithMany(p => p.PurchaseOrderHeader).HasForeignKey(d => d.VendorID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<SalesOrderDetail>(entity =>
			{
				entity.HasKey(e => new { e.SalesOrderID, e.SalesOrderDetailID });

				entity.ToTable("SalesOrderDetail", "Sales");

				entity.HasIndex(e => e.ProductID).HasName("IX_SalesOrderDetail_ProductID");

				entity.HasIndex(e => e.rowguid).HasName("AK_SalesOrderDetail_rowguid").IsUnique();

				entity.Property(e => e.SalesOrderDetailID).ValueGeneratedOnAdd();

				entity.Property(e => e.CarrierTrackingNumber).HasMaxLength(25);

				entity.Property(e => e.LineTotal)
					.HasColumnType("numeric")
					.ValueGeneratedOnAddOrUpdate();

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");

				entity.Property(e => e.UnitPrice).HasColumnType("money");

				entity.Property(e => e.UnitPriceDiscount).HasColumnType("money");

				entity.HasOne(d => d.SalesOrder).WithMany(p => p.SalesOrderDetail).HasForeignKey(d => d.SalesOrderID);

				entity.HasOne(d => d.SpecialOfferProduct).WithMany(p => p.SalesOrderDetail).HasForeignKey(d => new { d.SpecialOfferID, d.ProductID }).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<SalesOrderHeader>(entity =>
			{
				entity.HasKey(e => e.SalesOrderID);

				entity.ToTable("SalesOrderHeader", "Sales");

				entity.HasIndex(e => e.CustomerID).HasName("IX_SalesOrderHeader_CustomerID");

				entity.HasIndex(e => e.SalesOrderNumber).HasName("AK_SalesOrderHeader_SalesOrderNumber").IsUnique();

				entity.HasIndex(e => e.SalesPersonID).HasName("IX_SalesOrderHeader_SalesPersonID");

				entity.HasIndex(e => e.rowguid).HasName("AK_SalesOrderHeader_rowguid").IsUnique();

				entity.Property(e => e.AccountNumber).HasMaxLength(15);

				entity.Property(e => e.Comment).HasMaxLength(128);

				entity.Property(e => e.Freight).HasColumnType("decimal").HasDefaultValue(0M);
				entity.Property(e => e.SubTotal).HasColumnType("decimal").HasDefaultValue(0M);
				entity.Property(e => e.TaxAmt).HasColumnType("decimal").HasDefaultValue(0M);
				
				entity.Property(e => e.CreditCardApprovalCode)
					.HasMaxLength(15)
;

				entity.Property(e => e.DueDate).HasColumnType("datetime");

				entity.Property(e => e.Freight).HasColumnType("money");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.OrderDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.PurchaseOrderNumber).HasMaxLength(25);

				entity.Property(e => e.RevisionNumber).HasDefaultValue((byte)0);

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");

				entity.Property(e => e.SalesOrderNumber)
					.IsRequired()
					.HasMaxLength(25)
					.ValueGeneratedOnAddOrUpdate();

				entity.Property(e => e.ShipDate).HasColumnType("datetime");

				entity.Property(e => e.Status).HasDefaultValue((byte)1);

				entity.Property(e => e.SubTotal).HasColumnType("money");

				entity.Property(e => e.TaxAmt).HasColumnType("money");

				entity.Property(e => e.TotalDue)
					.HasColumnType("money")
					.ValueGeneratedOnAddOrUpdate();

				entity.HasOne(d => d.BillToAddress).WithMany(p => p.SalesOrderHeader).HasForeignKey(d => d.BillToAddressID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.CreditCard).WithMany(p => p.SalesOrderHeader).HasForeignKey(d => d.CreditCardID);

				entity.HasOne(d => d.CurrencyRate).WithMany(p => p.SalesOrderHeader).HasForeignKey(d => d.CurrencyRateID);

				entity.HasOne(d => d.Customer).WithMany(p => p.SalesOrderHeader).HasForeignKey(d => d.CustomerID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.SalesPerson).WithMany(p => p.SalesOrderHeader).HasForeignKey(d => d.SalesPersonID);

				entity.HasOne(d => d.ShipMethod).WithMany(p => p.SalesOrderHeader).HasForeignKey(d => d.ShipMethodID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.ShipToAddress).WithMany(p => p.SalesOrderHeaderNavigation).HasForeignKey(d => d.ShipToAddressID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.Territory).WithMany(p => p.SalesOrderHeader).HasForeignKey(d => d.TerritoryID);
			});

			modelBuilder.Entity<SalesOrderHeaderSalesReason>(entity =>
			{
				entity.HasKey(e => new { e.SalesOrderID, e.SalesReasonID });

				entity.ToTable("SalesOrderHeaderSalesReason", "Sales");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.HasOne(d => d.SalesOrder).WithMany(p => p.SalesOrderHeaderSalesReason).HasForeignKey(d => d.SalesOrderID);

				entity.HasOne(d => d.SalesReason).WithMany(p => p.SalesOrderHeaderSalesReason).HasForeignKey(d => d.SalesReasonID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<SalesPerson>(entity =>
			{
				entity.HasKey(e => e.BusinessEntityID);

				entity.ToTable("SalesPerson", "Sales");

				entity.HasIndex(e => e.rowguid).HasName("AK_SalesPerson_rowguid").IsUnique();

				entity.Property(e => e.BusinessEntityID).ValueGeneratedNever();

				entity.Property(e => e.Bonus).HasColumnType("money");

				entity.Property(e => e.CommissionPct).HasColumnType("smallmoney");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");

				entity.Property(e => e.SalesLastYear).HasColumnType("money");

				entity.Property(e => e.SalesQuota).HasColumnType("money");

				entity.Property(e => e.SalesYTD).HasColumnType("money");

				entity.HasOne(d => d.BusinessEntity).WithOne(p => p.SalesPerson).HasForeignKey<SalesPerson>(d => d.BusinessEntityID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.Territory).WithMany(p => p.SalesPerson).HasForeignKey(d => d.TerritoryID);
			});

			modelBuilder.Entity<SalesPersonQuotaHistory>(entity =>
			{
				entity.HasKey(e => new { e.BusinessEntityID, e.QuotaDate });

				entity.ToTable("SalesPersonQuotaHistory", "Sales");

				entity.HasIndex(e => e.rowguid).HasName("AK_SalesPersonQuotaHistory_rowguid").IsUnique();

				entity.Property(e => e.QuotaDate).HasColumnType("datetime");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");

				entity.Property(e => e.SalesQuota).HasColumnType("money");

				entity.HasOne(d => d.BusinessEntity).WithMany(p => p.SalesPersonQuotaHistory).HasForeignKey(d => d.BusinessEntityID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<SalesReason>(entity =>
			{
				entity.ToTable("SalesReason", "Sales");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");
			});

			modelBuilder.Entity<SalesTaxRate>(entity =>
			{
				entity.ToTable("SalesTaxRate", "Sales");

				entity.HasIndex(e => e.rowguid).HasName("AK_SalesTaxRate_rowguid").IsUnique();

				entity.HasIndex(e => new { e.StateProvinceID, e.TaxType }).HasName("AK_SalesTaxRate_StateProvinceID_TaxType").IsUnique();

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");

				entity.Property(e => e.TaxRate).HasColumnType("smallmoney");

				entity.HasOne(d => d.StateProvince).WithMany(p => p.SalesTaxRate).HasForeignKey(d => d.StateProvinceID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<SalesTerritory>(entity =>
			{
				entity.HasKey(e => e.TerritoryID);

				entity.ToTable("SalesTerritory", "Sales");

				entity.HasIndex(e => e.rowguid).HasName("AK_SalesTerritory_rowguid").IsUnique();

				entity.Property(e => e.CostLastYear).HasColumnType("money");

				entity.Property(e => e.CostYTD).HasColumnType("money");

				entity.Property(e => e.CountryRegionCode)
					.IsRequired()
					.HasMaxLength(3);

				entity.Property(e => e.Group)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");

				entity.Property(e => e.SalesLastYear).HasColumnType("money");

				entity.Property(e => e.SalesYTD).HasColumnType("money");

				entity.HasOne(d => d.CountryRegionCodeNavigation).WithMany(p => p.SalesTerritory).HasForeignKey(d => d.CountryRegionCode).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<SalesTerritoryHistory>(entity =>
			{
				entity.HasKey(e => new { e.BusinessEntityID, e.StartDate, e.TerritoryID });

				entity.ToTable("SalesTerritoryHistory", "Sales");

				entity.HasIndex(e => e.rowguid).HasName("AK_SalesTerritoryHistory_rowguid").IsUnique();

				entity.Property(e => e.StartDate).HasColumnType("datetime");

				entity.Property(e => e.EndDate).HasColumnType("datetime");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");

				entity.HasOne(d => d.BusinessEntity).WithMany(p => p.SalesTerritoryHistory).HasForeignKey(d => d.BusinessEntityID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.Territory).WithMany(p => p.SalesTerritoryHistory).HasForeignKey(d => d.TerritoryID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<ScrapReason>(entity =>
			{
				entity.ToTable("ScrapReason", "Production");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");
			});

			modelBuilder.Entity<Shift>(entity =>
			{
				entity.ToTable("Shift", "HumanResources");

				entity.HasIndex(e => new { e.StartTime, e.EndTime }).HasName("AK_Shift_StartTime_EndTime").IsUnique();

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");
			});

			modelBuilder.Entity<ShipMethod>(entity =>
			{
				entity.ToTable("ShipMethod", "Purchasing");

				entity.HasIndex(e => e.rowguid).HasName("AK_ShipMethod_rowguid").IsUnique();

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");

				entity.Property(e => e.ShipBase).HasColumnType("money");

				entity.Property(e => e.ShipRate).HasColumnType("money");
			});

			modelBuilder.Entity<ShoppingCartItem>(entity =>
			{
				entity.ToTable("ShoppingCartItem", "Sales");

				entity.HasIndex(e => new { e.ShoppingCartID, e.ProductID }).HasName("IX_ShoppingCartItem_ShoppingCartID_ProductID");

				entity.Property(e => e.DateCreated)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.Quantity).HasDefaultValue(1);

				entity.Property(e => e.ShoppingCartID)
					.IsRequired()
					.HasMaxLength(50);

				entity.HasOne(d => d.Product).WithMany(p => p.ShoppingCartItem).HasForeignKey(d => d.ProductID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<SpecialOffer>(entity =>
			{
				entity.ToTable("SpecialOffer", "Sales");

				entity.HasIndex(e => e.rowguid).HasName("AK_SpecialOffer_rowguid").IsUnique();

				entity.Property(e => e.Category)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(255);

				entity.Property(e => e.DiscountPct).HasColumnType("smallmoney");

				entity.Property(e => e.EndDate).HasColumnType("datetime");

				entity.Property(e => e.MinQty).HasDefaultValue(0);

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");

				entity.Property(e => e.StartDate).HasColumnType("datetime");

				entity.Property(e => e.Type)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<SpecialOfferProduct>(entity =>
			{
				entity.HasKey(e => new { e.SpecialOfferID, e.ProductID });

				entity.ToTable("SpecialOfferProduct", "Sales");

				entity.HasIndex(e => e.ProductID).HasName("IX_SpecialOfferProduct_ProductID");

				entity.HasIndex(e => e.rowguid).HasName("AK_SpecialOfferProduct_rowguid").IsUnique();

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");

				entity.HasOne(d => d.Product).WithMany(p => p.SpecialOfferProduct).HasForeignKey(d => d.ProductID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.SpecialOffer).WithMany(p => p.SpecialOfferProduct).HasForeignKey(d => d.SpecialOfferID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<StateProvince>(entity =>
			{
				entity.ToTable("StateProvince", "Person");

				entity.HasIndex(e => e.rowguid).HasName("AK_StateProvince_rowguid").IsUnique();

				entity.HasIndex(e => new { e.StateProvinceCode, e.CountryRegionCode }).HasName("AK_StateProvince_StateProvinceCode_CountryRegionCode").IsUnique();

				entity.Property(e => e.CountryRegionCode)
					.IsRequired()
					.HasMaxLength(3);

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");

				entity.Property(e => e.StateProvinceCode)
					.IsRequired()
					.HasMaxLength(3);

				entity.HasOne(d => d.CountryRegionCodeNavigation).WithMany(p => p.StateProvince).HasForeignKey(d => d.CountryRegionCode).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.Territory).WithMany(p => p.StateProvince).HasForeignKey(d => d.TerritoryID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<Store>(entity =>
			{
				entity.HasKey(e => e.BusinessEntityID);

				entity.ToTable("Store", "Sales");

				entity.HasIndex(e => e.SalesPersonID).HasName("IX_Store_SalesPersonID");

				entity.HasIndex(e => e.rowguid).HasName("AK_Store_rowguid").IsUnique();

				entity.Property(e => e.BusinessEntityID).ValueGeneratedNever();

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.rowguid).HasDefaultValueSql("newid()");

				entity.HasOne(d => d.BusinessEntity).WithOne(p => p.Store).HasForeignKey<Store>(d => d.BusinessEntityID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.SalesPerson).WithMany(p => p.Store).HasForeignKey(d => d.SalesPersonID);
			});

			modelBuilder.Entity<TransactionHistory>(entity =>
			{
				entity.HasKey(e => e.TransactionID);

				entity.ToTable("TransactionHistory", "Production");

				entity.HasIndex(e => e.ProductID).HasName("IX_TransactionHistory_ProductID");

				entity.HasIndex(e => new { e.ReferenceOrderID, e.ReferenceOrderLineID }).HasName("IX_TransactionHistory_ReferenceOrderID_ReferenceOrderLineID");

				entity.Property(e => e.ActualCost).HasColumnType("money");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.ReferenceOrderLineID).HasDefaultValue(0);

				entity.Property(e => e.TransactionDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.TransactionType)
					.IsRequired()
					.HasMaxLength(1);

				entity.HasOne(d => d.Product).WithMany(p => p.TransactionHistory).HasForeignKey(d => d.ProductID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<TransactionHistoryArchive>(entity =>
			{
				entity.HasKey(e => e.TransactionID);

				entity.ToTable("TransactionHistoryArchive", "Production");

				entity.HasIndex(e => e.ProductID).HasName("IX_TransactionHistoryArchive_ProductID");

				entity.HasIndex(e => new { e.ReferenceOrderID, e.ReferenceOrderLineID }).HasName("IX_TransactionHistoryArchive_ReferenceOrderID_ReferenceOrderLineID");

				entity.Property(e => e.TransactionID).ValueGeneratedNever();

				entity.Property(e => e.ActualCost).HasColumnType("money");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.ReferenceOrderLineID).HasDefaultValue(0);

				entity.Property(e => e.TransactionDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.TransactionType)
					.IsRequired()
					.HasMaxLength(1);
			});

			modelBuilder.Entity<UnitMeasure>(entity =>
			{
				entity.HasKey(e => e.UnitMeasureCode);

				entity.ToTable("UnitMeasure", "Production");

				entity.Property(e => e.UnitMeasureCode)
					.HasMaxLength(3);

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");
			});

			modelBuilder.Entity<Vendor>(entity =>
			{
				entity.HasKey(e => e.BusinessEntityID);

				entity.ToTable("Vendor", "Purchasing");

				entity.Property(e => e.BusinessEntityID).ValueGeneratedNever();

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.PurchasingWebServiceURL).HasMaxLength(1024);

				entity.HasOne(d => d.BusinessEntity).WithOne(p => p.Vendor).HasForeignKey<Vendor>(d => d.BusinessEntityID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<WorkOrder>(entity =>
			{
				entity.ToTable("WorkOrder", "Production");

				entity.HasIndex(e => e.ProductID).HasName("IX_WorkOrder_ProductID");

				entity.HasIndex(e => e.ScrapReasonID).HasName("IX_WorkOrder_ScrapReasonID");

				entity.Property(e => e.DueDate).HasColumnType("datetime");

				entity.Property(e => e.EndDate).HasColumnType("datetime");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.StartDate).HasColumnType("datetime");

				entity.Property(e => e.StockedQty).ValueGeneratedOnAddOrUpdate();

				entity.HasOne(d => d.Product).WithMany(p => p.WorkOrder).HasForeignKey(d => d.ProductID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.ScrapReason).WithMany(p => p.WorkOrder).HasForeignKey(d => d.ScrapReasonID);
			});

			modelBuilder.Entity<WorkOrderRouting>(entity =>
			{
				entity.HasKey(e => new { e.WorkOrderID, e.ProductID, e.OperationSequence });

				entity.ToTable("WorkOrderRouting", "Production");

				entity.HasIndex(e => e.ProductID).HasName("IX_WorkOrderRouting_ProductID");

				entity.Property(e => e.ActualCost).HasColumnType("money");

				entity.Property(e => e.ActualEndDate).HasColumnType("datetime");

				entity.Property(e => e.ActualResourceHrs).HasColumnType("decimal");

				entity.Property(e => e.ActualStartDate).HasColumnType("datetime");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("getdate()");

				entity.Property(e => e.PlannedCost).HasColumnType("money");

				entity.Property(e => e.ScheduledEndDate).HasColumnType("datetime");

				entity.Property(e => e.ScheduledStartDate).HasColumnType("datetime");

				entity.HasOne(d => d.Location).WithMany(p => p.WorkOrderRouting).HasForeignKey(d => d.LocationID).OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(d => d.WorkOrder).WithMany(p => p.WorkOrderRouting).HasForeignKey(d => d.WorkOrderID).OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<sysdiagrams>(entity =>
			{
				entity.HasKey(e => e.diagram_id);

				entity.Property(e => e.definition);
			});
		}

		public virtual DbSet<AWBuildVersion> AWBuildVersion { get; set; }
		public virtual DbSet<Address> Address { get; set; }
		public virtual DbSet<AddressType> AddressType { get; set; }
		public virtual DbSet<BillOfMaterials> BillOfMaterials { get; set; }
		public virtual DbSet<BusinessEntity> BusinessEntity { get; set; }
		public virtual DbSet<BusinessEntityAddress> BusinessEntityAddress { get; set; }
		public virtual DbSet<BusinessEntityContact> BusinessEntityContact { get; set; }
		public virtual DbSet<ContactType> ContactType { get; set; }
		public virtual DbSet<CountryRegion> CountryRegion { get; set; }
		public virtual DbSet<CountryRegionCurrency> CountryRegionCurrency { get; set; }
		public virtual DbSet<CreditCard> CreditCard { get; set; }
		public virtual DbSet<Culture> Culture { get; set; }
		public virtual DbSet<Currency> Currency { get; set; }
		public virtual DbSet<CurrencyRate> CurrencyRate { get; set; }
		public virtual DbSet<Customer> Customer { get; set; }
		public virtual DbSet<DatabaseLog> DatabaseLog { get; set; }
		public virtual DbSet<Department> Department { get; set; }
		public virtual DbSet<EmailAddress> EmailAddress { get; set; }
		public virtual DbSet<Employee> Employee { get; set; }
		public virtual DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }
		public virtual DbSet<EmployeePayHistory> EmployeePayHistory { get; set; }
		public virtual DbSet<ErrorLog> ErrorLog { get; set; }
		public virtual DbSet<Illustration> Illustration { get; set; }
		public virtual DbSet<JobCandidate> JobCandidate { get; set; }
		public virtual DbSet<Location> Location { get; set; }
		public virtual DbSet<Password> Password { get; set; }
		public virtual DbSet<Person> Person { get; set; }
		public virtual DbSet<PersonCreditCard> PersonCreditCard { get; set; }
		public virtual DbSet<PhoneNumberType> PhoneNumberType { get; set; }
		public virtual DbSet<Product> Product { get; set; }
		public virtual DbSet<ProductCategory> ProductCategory { get; set; }
		public virtual DbSet<ProductCostHistory> ProductCostHistory { get; set; }
		public virtual DbSet<ProductDescription> ProductDescription { get; set; }
		public virtual DbSet<ProductInventory> ProductInventory { get; set; }
		public virtual DbSet<ProductListPriceHistory> ProductListPriceHistory { get; set; }
		public virtual DbSet<ProductModel> ProductModel { get; set; }
		public virtual DbSet<ProductModelIllustration> ProductModelIllustration { get; set; }
		public virtual DbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get; set; }
		public virtual DbSet<ProductPhoto> ProductPhoto { get; set; }
		public virtual DbSet<ProductProductPhoto> ProductProductPhoto { get; set; }
		public virtual DbSet<ProductReview> ProductReview { get; set; }
		public virtual DbSet<ProductSubcategory> ProductSubcategory { get; set; }
		public virtual DbSet<ProductVendor> ProductVendor { get; set; }
		public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetail { get; set; }
		public virtual DbSet<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }
		public virtual DbSet<SalesOrderDetail> SalesOrderDetail { get; set; }
		public virtual DbSet<SalesOrderHeader> SalesOrderHeader { get; set; }
		public virtual DbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReason { get; set; }
		public virtual DbSet<SalesPerson> SalesPerson { get; set; }
		public virtual DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistory { get; set; }
		public virtual DbSet<SalesReason> SalesReason { get; set; }
		public virtual DbSet<SalesTaxRate> SalesTaxRate { get; set; }
		public virtual DbSet<SalesTerritory> SalesTerritory { get; set; }
		public virtual DbSet<SalesTerritoryHistory> SalesTerritoryHistory { get; set; }
		public virtual DbSet<ScrapReason> ScrapReason { get; set; }
		public virtual DbSet<Shift> Shift { get; set; }
		public virtual DbSet<ShipMethod> ShipMethod { get; set; }
		public virtual DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }
		public virtual DbSet<SpecialOffer> SpecialOffer { get; set; }
		public virtual DbSet<SpecialOfferProduct> SpecialOfferProduct { get; set; }
		public virtual DbSet<StateProvince> StateProvince { get; set; }
		public virtual DbSet<Store> Store { get; set; }
		public virtual DbSet<TransactionHistory> TransactionHistory { get; set; }
		public virtual DbSet<TransactionHistoryArchive> TransactionHistoryArchive { get; set; }
		public virtual DbSet<UnitMeasure> UnitMeasure { get; set; }
		public virtual DbSet<Vendor> Vendor { get; set; }
		public virtual DbSet<WorkOrder> WorkOrder { get; set; }
		public virtual DbSet<WorkOrderRouting> WorkOrderRouting { get; set; }
		public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

		// Unable to generate entity type for table 'Production.Document'. Please see the warning messages.
		// Unable to generate entity type for table 'Person.PersonPhone'. Please see the warning messages.
		// Unable to generate entity type for table 'Production.ProductDocument'. Please see the warning messages.
	}
}