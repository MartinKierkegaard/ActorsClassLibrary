
namespace ActorsClassLibrary
{
    public interface IActorsRepository
    {
        IEnumerable<Actor> Get(int? yearAfter = null, string? orderBy = null);
        Actor Add(Actor actor);
        Actor DeleteById(int id);
        List<Actor> GetAll();
        Actor GetById(int id);
    }
}