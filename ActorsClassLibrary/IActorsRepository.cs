
namespace ActorsClassLibrary
{
    public interface IActorsRepository
    {
        Actor Add(Actor actor);
        Actor DeleteById(int id);
        List<Actor> GetAll();
        Actor GetById(int id);
    }
}