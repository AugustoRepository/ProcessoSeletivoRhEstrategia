using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProcessoSeletivo.Presentation.Model
{
    public class PessoaCadastroModel
    {

     
        [Required(ErrorMessage ="Informe seu nome")]
        public string Nome { get; set; }
      
        [Required(ErrorMessage = "Informe seu Sobre nome")]
        public string SobreNome { get; set; }
 
        [Required(ErrorMessage = "Informe sua Cpf")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Informe sua Nacionalidade")]
        public string  Nacionalidade{ get; set; }
        
        [Required(ErrorMessage = "Informe Uma Cep")]
        public string  Cep{ get; set; }
       
        [Required(ErrorMessage = "Informe sua Nacionalidade")]
        public string  Cidade{ get; set; }
    
        [Required(ErrorMessage = "Informe sua Estado")]
        public string Estado { get; set; }
    
        [Required(ErrorMessage = "Informe sua Logradouro")]
        public string  Logradouro{ get; set; }
      
        [Required(ErrorMessage = "Informe sua Email")]
        public string  Email{ get; set; }
 
        [Required(ErrorMessage = "Informe sua Email")]
        public string  Telefone{ get; set; }
    }
}
