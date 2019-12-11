using System.ComponentModel.DataAnnotations;

namespace ControleDePedidos.Models
{
    public class Bebida
    {
        public int id { get; set; }

        [Display(Name = "Mesa")]
        public int mesa { get; set; }

        [Display(Name = "Nome Cliente")]
        public string nomeCliente { get; set; }

        [Display(Name = "Bebida")]
        public string bebida { get; set; }

        [Display(Name = "Quantidade Bebida")]
        public int qtd_bebida { get; set; }

        [Display(Name = "Status")]
        public int status { get; set; }
    }
}