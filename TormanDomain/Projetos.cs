using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TormanDomain
{
    public class Projetos
    {
        [Key]
        public int ProjetosCod  { get; set; }
        [Display(Name = "Descreva em qual versão o projeto se encontra")]
        public string ProjetosVersao { get; set; }
        [Display(Name = "Faça uma breje descrção sobre as funcionalidades do seu projeto"), Required(ErrorMessage = "Campo obrigatório")]
        public string ProjetoDescricao { get; set; }
        [Display(Name = "Registro de observações"), Required(ErrorMessage= "Campo obrigatório")]
        public string ProjetoObs { get; set; }
        [Display(Name = "Beneficiente do projeto")]
        public string Cliente { get; set; }
    }
}
