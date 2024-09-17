using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActorsClassLibrary
{
    public class ActorsRepository
    {
        private List<Actor> _actors = new List<Actor>() {
            new Actor() { Id=1,BirthYear=2000,Name="Bent"},
            new Actor() { Id=2,BirthYear=2001,Name="Lene"},
            new Actor() { Id=3,BirthYear=1990,Name="Hans"},
            new Actor() { Id=4,BirthYear=1984,Name="Lis"},
            };

        //CRUD Opretions


        /// <summary>
        /// returnerer alle actors i listen 
        /// </summary>
        /// <returns>liste af actors</returns>
        public List<Actor> GetAll() { 
        return _actors;
        }

        /// <summary>
        /// henter en enkelt actor 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Actor GetById(int id)
        {
            return _actors.FirstOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// tilføjer en ny actor til listen
        /// </summary>
        /// <param name="actor"></param>
        /// <returns>den actor som er tilføjet listen</returns>
        public Actor Add(Actor  actor) { 
            _actors.Add(actor);
            return actor;
        }


        /// <summary>
        /// sletter en actor for listen med id  
        /// </summary>
        /// <param name="id">id på den actor som skal slettes</param>
        /// <returns>actor som er slettet</returns>
        public Actor DeleteById(int id) { 
            Actor actor = GetById(id);

            _actors.Remove(actor);

            return actor;

        }



    }







}
