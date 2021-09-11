using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoAPI.Model
{
    public interface IConta
    {
        public double Sacar(double valor);

        public double Depositar(double valor);
    }
}
