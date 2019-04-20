using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormModels.Models;
using JotFormParserModels.Models;
using Microsoft.AspNetCore.Mvc;

namespace JotFormAuthenticator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JotFormController : ControllerBase
    {

        [HttpGet]
        public String Get() => ("jotformParse");

        [HttpPost]
        public void Post([FromForm] JotFormModel Form)
        {
            FormModel form = new FormModel {
                FormID = Form.FormID,
                FormName = Form.FormTitle,
            };
        }
    }
}