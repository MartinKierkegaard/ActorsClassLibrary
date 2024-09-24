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
        private List<Actor> _actorsList = new List<Actor>() {
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
            return _actorsList;
        }

        /// <summary>
        /// henter en enkelt actor 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Actor GetById(int id)
        {
            return _actorsList.FirstOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// tilføjer en ny actor til listen
        /// </summary>
        /// <param name="actor"></param>
        /// <returns>den actor som er tilføjet listen</returns>
        public Actor Add(Actor actor)
        {
            _actorsList.Add(actor);
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

            _actorsList.Remove(actor);

            return actor;

        }

        /// <summary>
        /// Metoden Get() giver mulighed for at filtrerer på Yearafter og lave sortering 
        /// på enten Name eller BirthYear 
        /// </summary>
        /// <param name="yearAfter">filtrering på BirthYear > YearAfter </param>
        /// <param name="orderBy">sortering på enten name eller BirtYear, angiv hhv "Name" eller "BirthYear"</param>
        /// <returns>en liste af actors</returns>
        public IEnumerable<Actor> Get(int? yearAfter = null, string? orderBy = null)
        {
            IEnumerable<Actor> result = _actorsList;


            if (yearAfter != null)
                result = result.Where(m => m.BirthYear > yearAfter);

            if (orderBy != null)
                if (orderBy == "Name")
                    result = result.OrderBy(m => m.Name);
                if (orderBy == "BirthYear")
                    result = result.OrderBy(m => m.BirthYear);

            return result;
        }
    }







}
