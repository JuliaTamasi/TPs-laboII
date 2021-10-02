using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        #region "Constructores"
        /// <summary>
        /// Inicializa los campos de la clase Suv
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// ReadOnly: Retornará el tamaño del Suv
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return Vehiculo.ETamanio.Grande;
            }
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Publica todos los datos del Suv.
        /// </summary>
        /// <returns>Los datos del Suv</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine(string.Empty);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
