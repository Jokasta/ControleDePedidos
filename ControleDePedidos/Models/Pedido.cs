using System.ComponentModel.DataAnnotations;

namespace ControleDePedidos.Models
{
    public class Pedido
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

        [Display(Name = "Bebida")]
        public string bebida { get; set; }

        [Display(Name = "Quantidade Bebida")]
        public int qtd_bebida { get; set; }

        [Display(Name = "Status")]
        public StatusPedido status { get; set; }
    }
}