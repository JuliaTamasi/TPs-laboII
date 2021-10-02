using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller
    {
        private List<Vehiculo> vehiculos;
        private int espacioDisponible;

        #region "Constructores"
        /// <summary>
        /// Inicializa el atributo vehiculos e instancia una nueva lista de vehiculos
        /// </summary>
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        /// <summary>
        /// Inicializa el atributo espacioDisponible de la clase Taller
        /// </summary>
        /// <param name="espacioDisponible"></param>
        public Taller(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();
            bool flagAgregar;
            if (!(taller is null))
            {
                sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", taller.vehiculos.Count, taller.espacioDisponible);
                sb.AppendLine(string.Empty);
                foreach (Vehiculo v in taller.vehiculos)
                {
                    switch (tipo)
                    {
                        case ETipo.Ciclomotor:
                            flagAgregar = v is Ciclomotor;
                            break;
                        case ETipo.Sedan:
                            flagAgregar = v is Sedan;
                            break;
                        case ETipo.SUV:
                            flagAgregar = v is Suv;
                            break;
                        default:
                            flagAgregar = true;
                            break;
                    }
                    if (flagAgregar)
                        sb.AppendLine(v.Mostrar());
                }
            }
            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            if (!(taller is null) && !(vehiculo is null) && taller.vehiculos.Count < taller.espacioDisponible)
            {
                foreach (Vehiculo v in taller.vehiculos)
                {
                    if (v == vehiculo)
                        return taller;
                }
                taller.vehiculos.Add(vehiculo);
            }
            return taller;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            if (!(taller is null) && !(vehiculo is null))
            {
                foreach (Vehiculo v in taller.vehiculos)
                {
                    if (v == vehiculo)
                    {
                        taller.vehiculos.Remove(vehiculo);
                        break;
                    }
                }
            }
            return taller;
        }
        #endregion

        #region "Enumerados"
        public enum ETipo
        {
            Ciclomotor,
            Sedan,
            SUV,
            Todos
        }
        #endregion
    }
}
