using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Models
{
    public class ClientModel
    {
        public int IdClient { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string IdentificationType { get; set; }
        public string Identification { get; set; }
        public string Email { get; set; }
        public DateTime BornDate { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
