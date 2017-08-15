using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TormanDomain
{
    public class Sobre
    {
        [Key]
        public int CodSobre { get; set; }
        public string Titulo { get; set; }

        [Display(Name = "Faça uma leve descrição sua ou da empresa:"),Required(ErrorMessage="Insira uma descrição*")]
        public string Descricao { get; set; }

        [Display(Name = "Insira o corpo descritivo, com suas principais caracteristicas. Lembrando que se trata do corpo principal da Pagina sobre."), Required(ErrorMessage = "Insira uma descrição*")]
        public string Body { get; set; }

        [Display(Name = "Insira uma rodapé:"), Required(ErrorMessage = "Insira uma o rodapé*")]
        public string Type { get; set; }
    }
}
