using System.ComponentModel.DataAnnotations;

namespace ControleDePedidos.Models
{
    public class Comida
    {
        public int id { get; set; }

        [Display(Name = "Mesa")]
        public int mesa { get; set; }

        [Display(Name = "Nome Cliente")]
        public string nomeCliente { get; set; }

        [Display(Name = "Comida")]
        public string comida { get; set; }

        [Display(Name = "Quantidade Comida")]
        public int qtd_comida { get; set; }

        [Display(Name = "Status")]
        public int status { get; set; }
    }
}