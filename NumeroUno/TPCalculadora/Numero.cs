using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCalculadora
{
    class Numero
    {
        private double _numero;

        /// <summary>
        /// Constructor de Numero sin parametros.
        /// </summary>
        public Numero()
        {
            this._numero = 0;
        }
        /// <summary>
        /// Constructor de Numero con un parametro double.
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            _numero = numero;
        }
        /// <summary>
        /// Constructor de Numero con un parametro string.
        /// </summary>
        /// <param name="numero"></param>
        public Numero(string numero)
        {
            setNumero(numero);
        }
        
        /// <summary>
        /// Propiedad GetNumero (Getter) devuelve un numero.
        /// </summary>
        /// <returns>Retorna el atributo numero</returns>
        public double getNumero()
        {
            return _numero;
        }

        /// <summary>
        /// Propiedad SetNumero (Setter). 
        /// </summary>
        /// <param name="numero"></param>
        private void setNumero(string numero)
        {
            _numero = validarNumero(numero);
        }

        /// <summary>
        /// Metodo que valida un caracter.
        /// </summary>
        /// <param name="numeroString"></param>
        /// <returns>devuelve un numero sino devuelve 0, utilizando el metodo TryParse.</returns>
        private static double validarNumero(string numeroString)
        {

            double numero = 0;
            if (double.TryParse(numeroString, out numero))
            {
                return numero;
            }
            return 0;
        }




    }
}
