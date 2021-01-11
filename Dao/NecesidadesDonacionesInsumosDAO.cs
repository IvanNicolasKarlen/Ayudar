using ayudarApp.Dao.Base;
using ayudarApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ayudarApp.Dao
{
    public class NecesidadesDonacionesInsumosDAO : BaseRepository<NecesidadesDonacionesInsumos>
    {
        TpDBContext context;
        public NecesidadesDonacionesInsumosDAO(TpDBContext contexto) : base(contexto)
        {
            context = contexto;
        }

        public List<NecesidadesDonacionesInsumos> BuscarPorId(int IdNecesidad)
        {
            List<NecesidadesDonacionesInsumos> listaObtenida = context.NecesidadesDonacionesInsumos.Where(o => o.IdNecesidad == IdNecesidad).ToList();
            return listaObtenida;
        }

        public List<NecesidadesDonacionesInsumos> BuscarInsumosPorIdNecesidad(int id)
        {
            return context.NecesidadesDonacionesInsumos.Where(o => o.IdNecesidad == id).ToList();
        }

    }
}