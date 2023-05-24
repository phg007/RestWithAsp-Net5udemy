using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Services
{
    public interface IPersonServices
    {
        Person create(Person person);
        Person FindByID(long id);
        Person Update(Person person);
        List<Person> FindAll();
        void Delete(long id);

    }
}
