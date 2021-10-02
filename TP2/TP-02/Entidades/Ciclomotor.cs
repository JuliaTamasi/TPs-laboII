using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        
        #region "Constructores"
        /// <summary>
        /// Inicializa los campos de la clase Ciclomotor
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return Vehiculo.ETamanio.Chico;
            }
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Publica todos los datos del ciclomotor.
        /// </summary>
        /// <returns>Los datos del ciclomotor</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine(string.Empty);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
