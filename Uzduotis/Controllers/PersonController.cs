using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Uzduotis.Services;

namespace Uzduotis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonData db;

        public PersonController(IPersonData db)
        {
            this.db = db;
        }

        [HttpGet]
        public List<Person> GetAll()
        {
            return db.GetAll().ToList();
        }
    }
}
