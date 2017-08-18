using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TormanDomain
{
    public class Email
    {
        [Key]
        public int EmailCod  { get; set; }
        public string EmailRemet { get; set; }
        public string EmailEmail { get; set; }
        public string EmailCorp { get; set; }
    }
}
