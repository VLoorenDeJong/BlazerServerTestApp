using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class PeopleData : IPeopleData
    {
        private readonly ISQLDataAccess _db;

        public PeopleData(ISQLDataAccess db)
        {
            _db = db;
        }

        public Task<List<PersonModel>> GetPeople()
        {
            string sql = "SELECT * FROM dbo.People";

            return _db.LoadData<PersonModel, dynamic>(sql, new { });
        }

        public Task InsertPerson(PersonModel person)
        {
            string sql = @" INSERT INTO dbo.People (FirstName, LastName, EmailAdress, DateOfBirth) 
                            VALUES (@FirstName, @LastName, @EmailAdress, @DateOfBirth)";

            return _db.SaveData(sql, person);
        }
    }
}
