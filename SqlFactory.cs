using System;


namespace DemoApp
{
    /// <summary>
    /// Contains methods which create SQL queries from given objects
    /// </summary>

    public class SqlFactory
    {
        /// <summary>
        /// Creates SQL select query from PersonModel object, ignores fields which contain an empty string 
        /// </summary>
        public static string SelectQuery(PersonModel person)
        {
            string sqlQuery = "select * from Person where";
            Boolean needAnd = false;
            if (person.FirstName != "")
            {
                sqlQuery += " FirstName = '" + person.FirstName + "'";
                needAnd = true;
            }
            if (person.LastName != "")
            {
                if (needAnd) { sqlQuery += " and"; }
                sqlQuery += " LastName = '" + person.LastName + "'";
                needAnd = true;
            }
            if (person.Email != "")
            {
                if (needAnd) { sqlQuery += " and"; }
                sqlQuery += " Email = '" + person.Email + "'";
                needAnd = true;
            }
            if (person.Role != "")
            {
                if (needAnd) { sqlQuery += " and"; }
                sqlQuery += " Role = '" + person.Role + "'";
                needAnd = true;
            }
            if (person.Info != "")
            {
                if (needAnd) { sqlQuery += " and"; }
                sqlQuery += " Info = '" + person.Info + "'";
            }
            return sqlQuery;
        }
    }
}
