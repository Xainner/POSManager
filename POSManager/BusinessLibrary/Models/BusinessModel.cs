using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Models
{
    public class BusinessModel
    {
        public int IdBusiness { get; set; }
        public string FantasyName { get; set; }
        public string SocietyName { get; set; }
        public string LegalCertification { get; set; }
        public string Telephone { get; set; }
        public string MainAddress { get; set; }
        public string GeneralAddress { get; set; }
        public string Email { get; set; }
        public string WebPage { get; set; }
        public byte[] Logo { get; set; }
        public int Main { get; set; }
    }
}
