using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TormanDomain
{
    public class Contato
    {
        [Key]
        public int ContatoCod { get; set; }
        [Display(Name = "Seu nome"), Required(ErrorMessage = "Campo Obrigartorio")]
        public  string ContatoDesc { get; set; }
        [Display(Name = "Seu E-mail"), Required(ErrorMessage = "Campo Obrigartorio")]
        public string ContatoEmail { get; set; }
        [Display(Name = "Seu Telefone"), Required(ErrorMessage = "Campo Obrigartorio")]
        public string ContatoTel { get; set; }
        [Display(Name = "link do seu github"), Required(ErrorMessage = "Campo Obrigartorio")]
        public string ContatoGit { get; set; }
    }
}
