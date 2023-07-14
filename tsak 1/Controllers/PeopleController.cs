using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tsak_1.Database;
using tsak_1.Database.DbModels;
using tsak_1.Models;
using tsak_1.Models.People;

namespace tsak_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly DataContext _dataContext;

        private readonly ILogger<PeopleController> _logger;

        public PeopleController(ILogger<PeopleController> logger, DataContext dataContext)
        {
            _logger = logger;
            _dataContext = dataContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _dataContext.Peoples;
            return Ok($"All People:{JsonConvert.SerializeObject(result)}");
        }

        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
            var people = _dataContext.Peoples.Find(id);
            if (people == null)
            {
                return BadRequest($"People with id:{id} does not exist.");
            }
            return Ok($"Find By Id:{JsonConvert.SerializeObject(people)}");
        }

        [HttpPost]
        public IActionResult Post(PeopleCreate model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var dbModel = new tsak_1.Database.DbModels.People();
            dbModel.FirstName = model.FirstName;
            dbModel.LastName = model.LastName;
            dbModel.MiddleName = model.MiddleName;
            dbModel.Age = model.Age;
            dbModel.DateOfBirth = model.DateOfBirth;

            _dataContext.Add(dbModel);
            _dataContext.SaveChanges();

            return Ok($"Succesful Create People:{JsonConvert.SerializeObject(dbModel)}");
        }

        [HttpPut]
        public IActionResult Put(int id, PeopleUpdate model)
        {
            var people = _dataContext.Peoples.Find(id);
            if (people == null)
            {
                return BadRequest($"People with id:{id} does not exist.");
            }
            people.LastName = model.LastName;
            people.MiddleName = model.MiddleName;
            _dataContext.SaveChanges();
            return Ok($"Succesful Update People:{JsonConvert.SerializeObject(people)}");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var people = _dataContext.Peoples.Find(id);
            if (people==null)
            {
                return BadRequest($"People with id:{id} does not exist.");
            }
            _dataContext.Peoples.Remove(people);
            _dataContext.SaveChanges();
            return Ok($"Succesful Delete People:{JsonConvert.SerializeObject(people)}");
        }


    }
}
