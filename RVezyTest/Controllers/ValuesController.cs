using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RVezyTest.CollectionService;
using RVezyTest.Interfaces;
using RVezyTest.Models;

namespace RVezyTest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        ICsvService _CsvService;

        // would have rather done this through dependency injection, unfortunately ran out of time 
        public ValuesController(ICsvService service)
        {
            _CsvService = service;
        }

        public ValuesController()
        {
            _CsvService = new CsvService();
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Listing>> Get()
        {
            var result = _CsvService.GetValues();

            return new ActionResult<IEnumerable<Listing>>(result);
        }

        // GET api/values/GetByPropertyType
        [HttpGet("{property_type}")]
        public ActionResult<string> GetByPropertyType(string property_type)
        {
            var result = _CsvService.GetValuesByPropertyType(property_type);

            return "getbytype";
        }

    }
}
