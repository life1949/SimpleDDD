using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleDDD.Sample.Controllers
{
    public class UserController : ApiController
    {
        public Models.User Get(string name, string password)
        {            
            var entity = from p in Models.User.All() where p.Name == name && p.Password == password select p;
            return entity.SingleOrDefault();
        }


        public Models.User Get(Guid id)
        {
            var entity = from p in Models.User.All() where p.ID == id select p;
            return entity.SingleOrDefault();
        }

        public IEnumerable<Models.User> Get()
        {
            return Models.User.All();
        }

        
        public void Post([FromBody]string name, [FromBody]string password)
        {
            int i = 0;
        }

        
        public void Put(Guid id, [FromBody]string name)
        {

        }
        
        public void Delete(Guid id)
        {

        }
    }
}