using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp
{
    public class Movimentacao
    {
        public double Valor { get; set; }
        public string Tipo { get; set; }

        public Movimentacao(double valor, string tipo)
        {
            Valor = valor;
            Tipo = tipo;
        }
    }
}

