using System;
using System.Collections.Generic;
using System.Text;

namespace ContaOO.dominio
{
    public class conta
    {
        public int Numero { get;  set; }
        public string Titular { get;  set; }
        public double Saldo { get; private set; }

        public conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 100;
        }
        

        public bool saca(double quantidade)
        {
           if( Saldo >= quantidade)
            {
                Saldo -= quantidade;
                return true;
            }
            return false;
        }

        public void deposita(double quantidade)
        {
            Saldo += quantidade;
        }
      
    }
}
