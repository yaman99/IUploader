using IUploader_Appilication.Interfaces;
using IUploader_Appilication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IUploader_Api.Controllers.V1
{
    [ApiController]
    [Route("[controller]")]
    public class PersonIdentityController : Controller
    {
        private readonly IPersonIdentityService _personIdentity;

        public PersonIdentityController(IPersonIdentityService personIdentity)
        {
            _personIdentity = personIdentity;
        }

        [HttpGet("get-persons")]
        public async Task<IActionResult> GetPerson()
        {
            return Ok(await _personIdentity.GetPersons());
        }
    }
}
