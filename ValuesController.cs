using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PruebaApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        ////// POST api/values
        //////cuando se desea capturar un solo calor del body hay que enviarlo como una cadena simple 
        //ver imagen [FromBody]string
        //public string Post([FromBody]string value)
        //{
        //    return "entro al post:" + value;
        //}

        //////// POST api/values

        ////////cuando se desea capturar datos complejos se debe definir una clase DTO de transporte 
        //ver imagen DTOTransporte
        //public string Post(DTOTransporte DTO)
        //{
            
        //    string svalue1 = DTO.valor1;
        //    string svalue2 = DTO.valor2;
        //    return "entro al post:" + svalue1 + "valor2" + svalue2;
        //}
        //dinamico y arreglate
        //ver imagen POSTDYNAMICDATA
        public string Post([FromBody] dynamic data)
        {

            string value = data.value;
            return "daleee" + value;
            /* do stuff */
        }

        //public string post(dynamic value1, dynamic value2)
        //{
        //    string svalue1 = value1; string svalue2 = value2;
        //    return "entro al post" + value1;
        //}

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }


    }

    public class DTOTransporte
    {
        public string valor1 { get; set; } 
        public string valor2 { get; set; } 
    }

}

namespace FormEncode.Models { 
    using System;
    using System.ComponentModel.DataAnnotations; 
    public class Update { 
        [Required] [MaxLength(140)]
        public string Status { get; set; } 
        public DateTime Date { get; set; } 
    } 
}
