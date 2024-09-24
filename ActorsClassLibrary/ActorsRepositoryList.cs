using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ActorsClassLibrary
{
    public class ActorsRepositoryList : IActorsRepository
    {
        private List<Actor> _actors = new List<Actor>() {
            new Actor("Bent",1,2000) ,
            new Actor("Bente",2,2001) ,
            new Actor("Lene",3,1990) ,
            new Actor("Frank",4,1984) ,
            };

        //CRUD Opretions


        /// <summary>
        /// returnerer alle actors i listen 
        /// </summary>
        /// <returns>liste af actors</returns>
        public List<Actor> GetAll()
        {
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
        public Actor Add(Actor actor)
        {
            _actors.Add(actor);
            return actor;
        }


        /// <summary>
        /// sletter en actor for listen med id  
        /// </summary>
        /// <param name="id">id på den actor som skal slettes</param>
        /// <returns>actor som er slettet</returns>
        public Actor DeleteById(int id)
        {
            Actor actor = GetById(id);

            _actors.Remove(actor);

            return actor;

        }



    }







}
