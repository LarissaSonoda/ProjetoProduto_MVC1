using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoPoduto.Models
{
    public class Produto
    {
        [Required(ErrorMessage ="Campo obrigatório")]
        public int codigo { get; set; }

        [Required()]
        public string nome { get; set; }

        [StringLength(200, MinimumLength = 10, ErrorMessage ="Insira uma descrição de 10 a 200 caracteres")]
        public string desc { get; set; }

        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})$", ErrorMessage = "Valor inválido")]
        public string peso { get; set; }

        [Required(ErrorMessage ="Insira a categoria do produto")]
        public string categoria { get; set; }

        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})$", ErrorMessage="Valor inválido")]
        public string valUnit { get; set;  }
    }
}