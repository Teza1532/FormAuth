using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JotFormAuthenticator.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace JotFormAuthenticator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JotFormController : ControllerBase
    {
        [HttpPost]
        public void Post([FromForm] JotFormModel Form)
        {
            dynamic form = JsonConvert.DeserializeObject<dynamic>(Form.RawRequest);
            List<FieldModel> fields = new List<FieldModel>();

            foreach(dynamic f in form)
            {
                if ( f.ChildTokens.Count == 0 )
                {
                    fields.Add(new FieldModel {
                        FieldName = f.Name,
                        FieldValue = f.Value
                    });
                    Console.WriteLine(f.Value);
                }
            }
            //FormModel form = new FormModel {
            //    FormID = Form.FormID,
            //    FormName = Form.FormTitle,
            //};
        }
    }
}