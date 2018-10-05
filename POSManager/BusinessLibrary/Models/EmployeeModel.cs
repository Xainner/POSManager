using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Models
{
    public class EmployeeModel
    {
        public int IdEmployee { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string IdentificationType { get; set; }
        public string Identification { get; set; }
        public string Residence { get; set; }
        public DateTime BornDate { get; set; }
        public string CivilState { get; set; }
        public string Childs { get; set; }
        public string Telephone { get; set; }
        public string Cellphone { get; set; }
        public string EnterStore { get; set; }
        public string Nationality { get; set; }
        public int IdPosition { get; set; }
        public string WorkingState { get; set; }
        public DateTime EnterDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Observation { get; set; }
        public byte[] Image { get; set; }
        public string NameEmergency { get; set; }
        public string CellphoneEmergency { get; set; }
    }
}
