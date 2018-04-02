using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using restapi.Models;

namespace restapi.Controllers
{
    [ApiController]
    public class RootController : ControllerBase
    {
        // GET api/values
        [Route("~/")]
        [HttpGet]
        public IDictionary<string, DocumentLink> Get()
        {
            return new Dictionary<string, DocumentLink>()
            {  
                { 
                    "timesheets", new DocumentLink() 
                    { 
                        Method = Method.Get,
                        Type = ContentTypes.Timesheets,
                        Relationship = DocumentRelationship.Timesheets,
                        Reference = "/timesheets"
                    }   
                }
            };
        }
    }
}
