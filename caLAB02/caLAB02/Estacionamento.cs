using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLAB02
{
    public class Estacionamento
    {
        private string chapa, marca;
        Tempo entrada = new Tempo();
        Tempo saida = new Tempo();

        public void solicitaDadosCarro()
        {
            Console.WriteLine("\nQual placa do carro? ");
            chapa = Console.ReadLine();
            Console.WriteLine("Qual marca do carro? ");
            marca = Console.ReadLine();
            Console.WriteLine("Horário de entrada");            
            entrada.solicitaHora();
            Console.WriteLine("Horário de saida");       
            saida.solicitaHora();
            Console.Clear();
            
        }

        public void dadosCarro()
        {
            Console.WriteLine("\nPlaca: " + chapa + " Marca: " + marca);
            Console.WriteLine("Horario entrada: ");
            entrada.imprimiHora();
            Console.WriteLine("Horario saida: ");
            saida.imprimiHora();

        }

        public void valorCobrado()
        {
            Tempo total = new Tempo();
            int preço, valor = 7;
            total = saida.subtraiHoras(entrada);
            preço = total.getHora() * valor;

            if (total.getMin() > 0)
                preço += 7;

            Console.WriteLine("Valor cobrado: R$" + preço + ",00");

        }

        
        

        
    }
}
