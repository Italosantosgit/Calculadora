using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraForm
{
    public enum Operacao {Soma, Subtracao, Multiplcacao, Divisao } 

    public class Calculadora
    {
        public double valor1 { get; set; }
        public double valor2 { get; set; }

        private Operacao operacaoEscolhida;

        public void  OperacaoEscolhida(Operacao operacao) 
        {
            this.operacaoEscolhida = operacao;
        }

        private double Somar()
        {
            return this.valor1 + this.valor2;
        }
        private double Subtrair()
        {
            return this.valor1 - this.valor2;
        }
        private double Multiplicar()
        {
            return this.valor1 * this.valor2;
        }
        private double Dividir()
        {
            return this.valor1 / this.valor2;
        }
        public double Resultado()
        {
            switch(this.operacaoEscolhida)
            {
                case Operacao.Soma:
                    return this.Somar();
                    
                case Operacao.Subtracao:
                    return this.Subtrair();
                    
                case Operacao.Multiplcacao:
                    return this.Multiplicar();
                    
                case Operacao.Divisao:
                    return this.Dividir();
                    

                default:
                        return 0;
            }
        }

    }
}
