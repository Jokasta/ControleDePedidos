using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ControleDePedidos.Models
{
    public class Contexto
    {
        /*-----É PRECISO TROCAR O connectionString PARA OS DADOS DE LOGIN DO SEU MSSQLSERVER-----*/
        private string connectionString = "Data Source=DESKTOP-N3VGLKN\\MSSQLSERVER_USER;Initial Catalog=jokasta_bd;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True";

        public void FazerPedido(Pedido pedido)
            
        {
            string query = "insert into pedidos values(@mesa, @nomeCliente, @comida, @qtd_comida, @bebida, @qtd_bebida, 1)";

            using (var contexto = new SqlConnection(connectionString))
            {
                contexto.Execute(query, new { pedido.mesa, pedido.nomeCliente, pedido.comida, pedido.qtd_comida, pedido.bebida, pedido.qtd_bebida });
            }
        }

        public List<Pedido> listarPedidos()
        {
            string query = "select id, mesa, nomeCliente, comida, qtd_comida, bebida, qtd_bebida, status from pedidos";

            using (var contexto = new SqlConnection(connectionString))
            {
                return contexto.Query<Pedido>(query).AsList();
            }
        }
    }
}