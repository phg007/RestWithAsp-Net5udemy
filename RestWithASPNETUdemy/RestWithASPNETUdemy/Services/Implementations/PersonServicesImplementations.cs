using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class PersonServicesImplementations : IPersonServices
    {

        private volatile int Count;

        private MySQLContext _context;


        public PersonServicesImplementations(MySQLContext context) {

            _context = context;
        }


        // private List<Person> persons;
        private int count;


        public Person create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
           
            return _context.Persons.ToList();
        }

       

        public Person FindByID(long id)
        {
            return new Person
            {

                Id = 1,
                FirstName = "Leanardo",
                LastName = "Costa",
                Address = "Uberlandia - Minas gerais - Brasil",
                Gender = "Male",
            };
         }

        public Person Update(Person person)
        {
            return person;
        }

      
    }
}
