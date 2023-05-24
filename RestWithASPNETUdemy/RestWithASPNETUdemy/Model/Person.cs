using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Model
{

    [Table("person")]
          
    public class Person
    {


        [Column("id")]
        public long Id { get; set; }
        [Column("adress")]
        public string Address { get; set; }

        [Column("firt_name")]
        public string FirstName { get; set; }

        [Column("gender")]

        public string Gender { get; set; }
    
        [Column("last_name")]
        public string LastName { get; set; }

       
    }
}
