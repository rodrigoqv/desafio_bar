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
        public char Gender;
        public int Beer;
        public int Barbecue;
        public int SoftDrink; 

        public double Feeding(int Cerveja, int Espetinho, int Refrigerante)
        {
            return Cerveja * 5.0 + Refrigerante * 3.0 + Espetinho * 7.0;
        }

        public double Cover()
        {
            if (Feeding(Beer, Barbecue, SoftDrink) <= 30){
                return 4;
            }
            else
            {
                return 0;
            }
        }

        public double Ticket(char Sexo)
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
            if (Feeding(Beer, Barbecue, SoftDrink) > 30)
            {
                return Feeding(Beer, Barbecue, SoftDrink) + Ticket(Gender);
            }
            else
            {
                return Feeding(Beer, Barbecue, SoftDrink) + Ticket(Gender) + 4;
            }
        }

        public override string ToString()
        {
            return "Relatório: \nConsumo: " + Feeding(Beer, Barbecue, SoftDrink) + "\nCouvert: " + Cover() + "\nIngresso: "
                + Ticket(Gender) + "\n\nValor a pagar: " + Total();
        }
    }
}
