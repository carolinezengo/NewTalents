using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> linhahistorico;
        private string data;
                
        public Calculadora (string data)
        {
            linhahistorico = new List<string>();
            this.data = data;
        }
        public int soma(int val1, int val2)
        {
            int res = val1 + val2;
            linhahistorico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }
        public int subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            linhahistorico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }
        public int multiplicacao(int val1, int val2)
        {
            int res = val1 * val2;
            linhahistorico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }
        public int dividir(int val1, int val2)
        {
            int res = val1 / val2;
            linhahistorico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }
        public List<string> historico()
        {
            linhahistorico.RemoveRange(3, linhahistorico.Count -3);
            return linhahistorico;
        }


    }
}
