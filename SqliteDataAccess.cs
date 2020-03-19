using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace DemoApp
{
    public class SqliteDataAccess
    {
        public static List<PersonModel> LoadPeople()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PersonModel>("select * from Person", new DynamicParameters());
                return output.ToList();
            }
        }
        public static bool SavePerson(PersonModel person)
        {
            string sqlStatement = "insert into Person(FirstName, LastName, Email, Role, Info) values(@firstName, @lastName, @email, @role, @info)";
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(sqlStatement, person);
            }
            return true;
        }
        public static List<PersonModel> SearchPerson(PersonModel person)
        {
            string personsData = person.FirstName + person.LastName + person.Email + person.Role + person.Info;
            string sqlQuery;
            if (personsData == "")
            {
                sqlQuery = "select * from Person";
            }
            else
            {
                sqlQuery = SqlFactory.SelectQuery(person);
            }


            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PersonModel>(sqlQuery, new DynamicParameters());
                return output.ToList();
            }
        }
        public static bool DeletePerson(int personId)
        {
            int temp = 0;
            string sqlStatement = "delete from Person where Id = @PerId";
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                temp = cnn.Execute(sqlStatement, new { PerId = personId });
            }
            if (temp == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public static bool ModifyPerson(PersonModel person)
        {
            int rowAffectedCount = 0;
            string sqlStatement = "update Person set FirstName = @FirstName, LastName = @LastName, Email = @Email, Role = @Role, Info = @Info where Id = @Id";
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                rowAffectedCount = cnn.Execute(sqlStatement, person);
            }
            if (rowAffectedCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        
    }
}
