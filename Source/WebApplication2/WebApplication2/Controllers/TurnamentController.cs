using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2;


namespace Turnament_NameSpace
{
    public class Player
    {
        public string name;
        public int age;
        public Player(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    public class Turnament
    {
        public string name;
        public List<Player> Participants;
        public List<Turnament> subTurnaments;

        public Turnament(string name)
        {
            this.name = name;
            Player temp = new Player("Oskar", 23);
        }
    }


    public class TurnamentController : ApiController
    {

        // GET: api/Turnament
        
       
        
        public IEnumerable<string> Get()
        {
           
            return new string[] { Startup.TurnamentHandler.turnaments.Count.ToString(), "value2" }; ;
        }

        // GET: api/Player/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Player
        public void Post(/*[FromBody]string value*/)
        {
            //create turnament
            Turnament temp = new Turnament("YES");
            Startup.TurnamentHandler.turnaments.Add(temp);
        }

        // PUT: api/Player/5
        public void Put(int id, [FromBody]string value)
        {
            //this.TEST = value;
        }

        // DELETE: api/Player/5
        public void Delete(int id)
        {
        }
    }


}
