using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Massive;

namespace Oak
{
    public class DynamicDb : Gemini
    {
        string connectionString;
        public DynamicDb()
        {
            connectionString = new ConnectionProfile().ConnectionString;
        }

        public DynamicDb(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void LogToConsole()
        {
            DynamicRepository.WriteDevLog = true;
            DynamicRepository.LogSql = DynamicRepository.LogSqlDelegate;
        }

        dynamic MethodMissing(dynamic callInfo)
        {
            var tableName = callInfo.Name;

            if (!AssociationByConventions.TableExists(tableName, connectionString))
            {
                throw new AssociationByConventionsException("Table [" + tableName + "] doesn't exist.");
            }

            var repositoryProperty = tableName + "Repository";

            callInfo.Instance.SetMember(repositoryProperty, AssociationByConventions.RepositoryFor(tableName, connectionString));

            callInfo.Instance.SetMember(
                tableName,
                new DynamicFunction(() => callInfo.Instance.GetMember(repositoryProperty)));

            return callInfo.Instance.GetMember(tableName)();
        }
    }
}
