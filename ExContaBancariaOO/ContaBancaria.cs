using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExContaBancariaOO {
    internal class ContaBancaria {

        //Encapsulamento dos meus atributos
        public int NumeroConta { get; private set; } //Numero não pode ser alterado
        public string NomeTitular { get; set; } //Nome pode ser alterado
        public double Saldo { get; private set; } //Saldo só pode ser alterado por meio de deposito/saque

        //Vou ter um construtor com 3 argumentos e outro com 2 => sobrecarga
        public ContaBancaria(int numero, string titular) {
            NumeroConta = numero;
            NomeTitular = titular;
            Saldo = 0.0;
        }

        //utilizar o this para reaproveitar os dois comandos de cima
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular){
            Deposito(depositoInicial); //Nao precisa reimplementar a lógica, só chamar o método
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + NomeTitular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
