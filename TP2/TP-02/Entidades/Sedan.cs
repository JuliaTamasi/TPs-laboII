using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        private ETipo tipo;

        #region "Constructores"

        /// <summary>
        /// Inicializa los campos de la clase Sedan
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : this(marca, chasis, color, ETipo.CuatroPuertas)
        {

        }
        /// <summary>
        /// Inicializa los campos de la clase Sedan
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            : base(chasis, marca, color)
        {
            this.tipo = tipo;
        }

        #endregion

        #region "Propiedades"
        /// <summary>
        /// ReadOnly: Retornará el tamaño del Sedan
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return Vehiculo.ETamanio.Mediano;
            }
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Publica todos los datos del Sedan.
        /// </summary>
        /// <returns>Los datos del Sedan</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}\r\n", this.Tamanio);
            sb.AppendLine($"TIPO : {this.tipo}");
            sb.AppendLine(string.Empty);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion

        #region "Enumerados"
        public enum ETipo
        {
            CuatroPuertas,
            CincoPuertas
        }
        #endregion
    }
}
