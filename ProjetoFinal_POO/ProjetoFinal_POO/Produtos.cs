using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal_POO
{
    class Produtos
    {
        private string nome_produto, fornecedor;
        private int quantidade, codigo_produto;
        private double valor;

        public string getNome_produto()
        { return nome_produto; }
        public string getFornecedor()
        { return fornecedor; }
        public int getQuantidade()
        { return quantidade; }
        public int getCodProduto()
        { return codigo_produto; }
        public double getValor()
        { return valor; }

        public void setNome_produto( string n)
        { nome_produto = n; }
        
        public void setFornecedor(string f)
        { fornecedor = f; }
        public void setQuantidade(int q)
        { quantidade = q; }
        
        public void setCodProduto(int c)
        { codigo_produto = c; }
        
        public void setValor(double v)
        { valor = v; }
        


    }
}
