using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FirstNETMVCWebAppAPI.Models; //Give us access to our Model Class (Person)

namespace FirstNETMVCWebAppAPI.Controllers
{
    public class PeopleController : ApiController
    {

        //This instance is Reset everytime we make a call.  Need text file or DB for POST
        List<Person> People = new List<Person>();

        public PeopleController()
        {
            People.Add(new Person { FirstName = "Bob", LastName = "Saggit", id = 1 });
            People.Add(new Person { FirstName = "Captain", LastName = "Sparrow", id = 2 });
            People.Add(new Person { FirstName = "Nikola", LastName = "Tesla", id = 3 });
        }


        // GET: api/People
        public List<Person> Get()
        {
            return People;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return People.Where(x => x.id == id).FirstOrDefault(); //FirstOrDefault returns 1st elem or default if no elem
        }

        // POST: api/People
        //Takes in a Person object and adds it to People object
        //public void Post([FromBody]string value)
        public void Post(Person val)
        {
            //todo: Test to make sure a valid Person
            People.Add(val);
        }

        //// PUT: api/People/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
