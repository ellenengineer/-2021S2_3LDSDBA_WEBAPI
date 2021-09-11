using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoAPI.Model
{
    public abstract class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public DateTime DtNascFund { get; set; }

        public string Email { get; set; }

        public string Endereco { get; set; }

    }
}
