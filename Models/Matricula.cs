using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PC1.Models
{
    public class Matricula
    {
        [Required]
        [Display(Name ="Nombres",Prompt ="Nombres Completo")]
        public String? Nombres{get;set;}
        [Required]
        [Display(Name ="Apellidos",Prompt ="Apellidos Completo")]
        public String? Apellidos{get;set;}
        [Required]
        [EmailAddress]
        [Display(Name ="Correo",Prompt ="ejmplo@usmp.pe")]
        public String? Correo{get;set;}
        [Display(Name ="Matematica")]
        public bool Matematica{get;set;}
        [Display(Name ="Lenguaje")]
        public bool Lenguaje{get;set;}
        [Display(Name ="Historia")]
        public bool Historia{get;set;}

        
    }
}