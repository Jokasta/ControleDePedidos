using ControleDePedidos.Models;
using System;
using System.Web.Mvc;

namespace ControleDePedidos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FazerPedido(FormCollection formCollection)
        {
            var pedido = new Pedido();
            pedido.mesa = Convert.ToInt32(formCollection["mesa"]);
            pedido.nomeCliente = formCollection["nomeCliente"];
            pedido.comida = formCollection["comida"];
            pedido.qtd_comida = Convert.ToInt32(formCollection["qtd_comida"]);
            pedido.bebida = formCollection["bebida"];
            pedido.qtd_bebida = Convert.ToInt32(formCollection["qtd_bebida"]);

            var contexto = new Contexto();

            contexto.FazerPedido(pedido);

            var pedidos = contexto.listarPedidos();

            return View("Garcon", pedidos);
        }

        public ActionResult Garcon()
        {
            var contexto = new Contexto();

            var pedidos = contexto.listarPedidos();

            return View(pedidos);
        }

        public ActionResult Cozinha()
        {
            var contexto = new Contexto();

            var pedidos = contexto.listarPedidos();

            return View(pedidos);
        }

        public ActionResult Copa()
        {
            var contexto = new Contexto();

            var pedidos = contexto.listarPedidos();

            return View(pedidos);
        }
    }
}