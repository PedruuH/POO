using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLAB02
{
    class Estacionamento
    {
        private string placa, marca;
        private int valor_hora = 7;
        int h;
        public Tempo entrada = new Tempo();
        public Tempo saida = new Tempo();

        public void novoCarro()
        {
           Console.WriteLine("Insira a Placa");
           placa = Console.ReadLine();
           Console.WriteLine("Insira a marca");
           marca = Console.ReadLine();
           Console.WriteLine("Hora de entrada");
           entrada.setHora(Convert.ToInt32(Console.ReadLine()));
           Console.WriteLine("Minutos");
           entrada.setMin(Convert.ToInt32(Console.ReadLine()));
           Console.WriteLine("Segundos");
           entrada.setSeg(Convert.ToInt32(Console.ReadLine()));
           Console.WriteLine("Hora de saida");
           saida.setHora(Convert.ToInt32(Console.ReadLine()));
           Console.WriteLine("Minutos");
           saida.setMin(Convert.ToInt32(Console.ReadLine()));
           Console.WriteLine("Segundos");
           saida.setSeg(Convert.ToInt32(Console.ReadLine()));
        }
        public int valorCobrado(Tempo k)
        {
            return valor_hora * k.getHora();
        }
        
        public void dadosCarro()
        {
            Console.WriteLine("Carro de placa " + placa + " e marca " + marca);
            Console.WriteLine("Horário entrada");
            entrada.imprimeTempo();
            Console.WriteLine("Horário saida");
            saida.imprimeTempo();
            Console.WriteLine("Valor cobrado: R$");
        }
        
    }
}
