using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCalculadora
{
    class Calculadora
    {
       
        /// <summary>
        /// Realiza operaciones matematicas de suma, resta, multiplicacion y division.
        /// </summary>
        /// <param name="numero1">Recibe el numero1</param>
        /// <param name="numero2">Recibe el numero2</param>
        /// <param name="operador">Recibe el operador</param>
        /// <returns></returns>
        public static double Operar(Numero numero1, Numero numero2, string operador)
        {
            double resultado = 0;
            switch (validarOperador(operador))
            {
                case "+":
                    resultado = numero1.getNumero() + numero2.getNumero();
                    break;
                case "-":
                    resultado = numero1.getNumero() - numero2.getNumero();
                    break;
                case "*":
                    resultado = numero1.getNumero() * numero2.getNumero();
                    break;
                case "/":
                    if (numero2.getNumero() != 0)
                    {
                        resultado = numero1.getNumero() / numero2.getNumero();
                    }
                    else
                        return 0;

                    break;

            }
            return resultado;

        }

        /// <summary>
        /// Valida los operadores.
        /// </summary>
        /// <param name="operador">Recibe un operador</param>
        /// <returns> Devuelve el operador correcto o el operador + en el caso contrario +.</returns>
        public static string validarOperador(string operador)
        {
            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
            {
                return operador;
            }
            return "+";
        }
    }
}

