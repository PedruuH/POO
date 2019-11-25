using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    public class Vendas
    {
        //Atributos
        private int idcorretor;
        private String empreendimento;
        private Double valor;
        private int comissao;
        private String mes;
        private Double entrada;
        private Double saida;

        //Construtores
        public Vendas()
        {
        }

        public Vendas(int corretor, string empreendimento, double valor, int comissao, string mes)
        {
            this.idcorretor = corretor;
            this.empreendimento = empreendimento;
            this.valor = valor;
            this.comissao = comissao;
            this.mes = mes;
            //this.entrada = ((valor * comissao) / 100);
            //this.saida = entrada * 0.35 * 0.92; //35% da entrada, e o valor resultado subtrai 8% de imposto
        }

        //Metodos
        public Double cadastraEntrada()
        {
            return (valor * comissao) / 100;
        }

        public Double cadastraSaida(Double entrada)
        {
            return entrada * 0.35 * 0.92;
        }

        //Getters
       public int getCorretor()
       {
            return idcorretor;
       }

        public String getEmpreendimento()
        {
            return empreendimento;
        }

        public Double getValor()
        {
            return valor;
        }

        public int getComissao()
        {
            return comissao;
        }

        public String getMes()
        {
            return mes;
        }

        public Double getEntrada()
        {
            return entrada;
        }

        public Double getSaida()
        {
            return saida;
        }

    }
}
