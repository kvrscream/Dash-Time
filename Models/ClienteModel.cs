using System;
namespace DashTime.Models
{
    public class ClienteModel
    {
        
        public int IdCliente { get; set; }

        public string Nome { get; set; }

        public string Contato { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public bool Ativo { get; set; }


    }
}
