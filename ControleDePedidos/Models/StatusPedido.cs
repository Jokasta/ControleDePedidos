using System.ComponentModel.DataAnnotations;

namespace ControleDePedidos.Models
{
    public enum StatusPedido
    {
        [Display(Name = "Andamento")]
        Andamento = 1,
        [Display(Name = "Pronto")]
        Pronto = 2,
        [Display(Name = "Entregue")]
        Entregue = 3,
        [Display(Name = "Cancelado")]
        Cancelado = 4
    }
}