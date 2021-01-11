using System.Collections.Generic;

namespace ayudarApp.Dao.Interface
{
    interface ICrud<T> where T : class
    {
        T Guardar(T generics);

        T ObtenerPorID(int id);
        T Actualizar(T generics);

        List<T> ObtenerTodos();
    }
}
