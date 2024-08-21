using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class CalculadoraP
    {
        private List<string> historicoCalc;
        public string data { get; set; }
        public CalculadoraP(string data)
        {
            historicoCalc = new List<string>();
            this.data = data;
        }

        public int Somar(int num1, int num2)
        {
            var res = num1 + num2;
            historicoCalc.Insert(0, $"Res {res} em {data}");
            return res;
        }

        public int Subtrair(int num1, int num2)
        {
            var res = num1 - num2;
            historicoCalc.Insert(0, $"Res {res} em {data}");
            return res;
        }

        public int Multiplicar(int num1, int num2)
        {
            var res = num1 * num2;
            historicoCalc.Insert(0, $"Res {res} em {data}");
            return res;
        }

        public int Dividir(int num1, int num2)
        {
            var res = num1 / num2;
            historicoCalc.Insert(0, $"Res {res} em {data}");
            return res;
        }

        public List<string> historico()
        {
            historicoCalc.RemoveRange(3, historicoCalc.Count-3);
            return historicoCalc;
        }
    }
}