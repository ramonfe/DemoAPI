using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    /// <summary>
    /// Aqui es donde te doy toda la infromacion de las personas.
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();
        public PeopleController()
        {
            people.Add(new Person { FirstName = "Ramon", LastName = "Felix", Id = 1 });
            people.Add(new Person { FirstName = "gene", LastName = "felix", Id = 2 });
            people.Add(new Person { FirstName = "Emi", LastName = "Felix", Id = 3 });
        }
        /// <summary>
        /// Da la lista del nombre de todos los usuarios.
        /// </summary>
        /// <param name="userId">Identificador de una persona</param>
        /// <param name="age">La edad de la persona</param>
        /// <returns>Una lista de los nombres</returns>
        [Route("api/People/GetFirstName/{userId:int}/{age:int}")]
        [HttpGet]
        public List<string> GetFirstName(int userId,int age)
        {
            List<string> output = new List<string>();

            foreach (var p in people)
            {
                output.Add(p.FirstName);
            }
            return output;
        }
        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val)
        {
            Random rnd = new Random();
            val.Id = rnd.Next(5, 500);
            people.Add(val);
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
           
        }
    }
}
