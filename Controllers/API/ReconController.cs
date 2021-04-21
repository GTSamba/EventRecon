using EventRecon.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Http;

namespace EventRecon.Controllers.API
{
    public class ReconController : ApiController
    {
        [HttpGet]
        [Route("api/Recon/getRecon")]
        public IEnumerable<Recon> getRecon()
        {
            string path = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/Person.json");
            string jsonResult;

            using (StreamReader streamReader = new StreamReader(path))
            {
                jsonResult = streamReader.ReadToEnd();
            }

            List<Person> objPerson = JsonConvert.DeserializeObject<List<Person>>(jsonResult);

            
            path = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/Event.json");
            
            using (StreamReader streamReader = new StreamReader(path))
            {
                jsonResult = streamReader.ReadToEnd();
            }

            List<Event> objEvent = JsonConvert.DeserializeObject<List<Event>>(jsonResult);


            var objJoin = from p in objPerson
                           join e in objEvent on new { p.Full_Name, p.Birth_Date } equals new {e.Full_Name, e.Birth_Date}
                             select new { p, e };


            List<Recon> objRecon = new List<Recon>();
            foreach (var item in objJoin)
            {
                objRecon.Add(new Recon {Full_Name=item.p.Full_Name,
                                        Birth_Date=item.p.Birth_Date,
                                        Event_Name=item.e.Event_Name});
            }

            return objRecon;
        }
    }
}