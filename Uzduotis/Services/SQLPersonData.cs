using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uzduotis.Services;

namespace Uzduotis.Services
{
    public class SQLPersonData : IPersonData
    {
        private readonly PersonContext db;

        public SQLPersonData(PersonContext db)
        {
            this.db = db;
        }

        public IEnumerable<Person> GetAll()
        {
            return from r in db.Person
                   select r;
        }
    }
}
