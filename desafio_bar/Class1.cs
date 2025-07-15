using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace desafio_bar
{
    internal class Conta
    {
        public char Sexo;
        public int Cerveja;
        public int Espetinho;
        public int Refrigerante; 

        public double Consumo(int Cerveja, int Espetinho, int Refrigerante)
        {
            return Cerveja * 5.0 + Refrigerante * 3.0 + Espetinho * 7.0;
        }

        public double Couvert()
        {
            if (Consumo(Cerveja, Espetinho, Refrigerante) <= 30){
                return 4;
            }
            else
            {
                return 0;
            }
        }

        public double Entrada(char Sexo)
        {
            if (Sexo == 'f' || Sexo == 'F')
            {
                return 8;
            }
            else
            {
                return 10;
            }
        }

        public double Total()
        {
            if (Consumo(Cerveja, Espetinho, Refrigerante) > 30)
            {
                return Consumo(Cerveja, Espetinho, Refrigerante) + Entrada(Sexo);
            }
            else
            {
                return Consumo(Cerveja, Espetinho, Refrigerante) + Entrada(Sexo) + 4;
            }
        }

        public override string ToString()
        {
            return "Relatório: \nConsumo: " + Consumo(Cerveja, Espetinho, Refrigerante) + "\nCouvert: " + Couvert() + "\nIngresso: "
                + Entrada(Sexo) + "\n\nValor a pagar: " + Total();
        }
    }
}
