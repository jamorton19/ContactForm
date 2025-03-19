using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ContactForm.Data.Models
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }

        public string Prefix { get; set; }

        [Description("First Name")]
        public string FirstName { get; set; }

        [Description("Middle Name")]
        public string MiddleName { get; set; }

        [Description("Last Name")]
        public string LastName { get; set; }

        public Address Address { get; set; }

    }
}