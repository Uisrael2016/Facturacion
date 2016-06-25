using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_AccesoDatos
{
    public interface InterfaceDao<T>
    {
        void insertar(T entidad);
        void modificar(T entidad);

        void eliminar(T entidad);

        T consultarPorId(int id);
        IList<T> consultar();

    }
}
