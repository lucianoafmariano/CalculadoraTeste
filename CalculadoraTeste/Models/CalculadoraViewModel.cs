using System.ComponentModel.DataAnnotations;

namespace CalculadoraTeste.Models
{
    public class CalculadoraViewModel
    {
        /// <summary>
        /// Número 1
        /// </summary>
        [Display(Name ="Número 1")]
        public int Num1 { get; set; }

        /// <summary>
        /// Número 2
        /// </summary>
        [Display(Name = "Número 2")]
        public int Num2 { get; set; }

        /// <summary>
        /// Operador + - * / 
        /// </summary>
        public string Operador { get; set; }

        /// <summary>
        /// Resultado da operação
        /// </summary>
        public int? Resultado { get; set; }
    }
}