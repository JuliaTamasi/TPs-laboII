using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        private string chasis;
        private EMarca marca;
        private ConsoleColor color;

        #region "Propiedades"

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio
        {
            get;
        }
        #endregion

        #region "Constructores"
        /// <summary>
        /// Inicializa los campos de la clase vehiculo
        /// </summary>
        /// <param name="chasis"></param>
        /// <param name="marca"></param>
        /// <param name="color"></param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }
        #endregion

        #region "Metodos"

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns>Los datos del vehiculo</returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Configura el casteo explicito de vehiculo a string para que retorne los datos del vehiculo
        /// </summary>
        /// <param name="p">Instancia de vehiculo que sera casteada</param>
        /// <returns>datos del vehiculo en formato string</returns>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1">vehiculo 1 a ser comparado</param>
        /// <param name="v2">vehiculo 2 a ser comparado</param>
        /// <returns>true si los chasis de los vehiculos son iguales</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if (v1 is null || v2 is null)
                return false;
            return v1.chasis == v2.chasis;
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1">vehiculo 1 a ser comparado</param>
        /// <param name="v2">vehiculo 2 a ser comparado</param>
        /// <returns>true si los chasis de los vehiculos son distintos</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        #endregion

        #region "Enumerados"
        public enum EMarca
        {
            Chevrolet,
            Ford,
            Renault,
            Toyota,
            BMW,
            Honda,
            HarleyDavidson
        }
        public enum ETamanio
        {
            Chico,
            Mediano,
            Grande
        }
        #endregion
    }
}
