using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Titular
{
    public class Cliente
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string profissao { get; set; }

        public static int TotalClientes { get; set; }

        //Método Constrututor (publico)
        public Cliente()
        {
            TotalClientes = TotalClientes + 1;
        }

    }
}