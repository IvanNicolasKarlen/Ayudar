using ayudarApp.Dao.Base;
using ayudarApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ayudarApp.Dao
{
    public class NecesidadesDonacionesMonetariasDAO : BaseRepository<NecesidadesDonacionesMonetarias>
    {
        TpDBContext context;
        public NecesidadesDonacionesMonetariasDAO(TpDBContext contexto) : base(contexto)
        {
            context = contexto;
        }

        public List<NecesidadesDonacionesMonetarias> BuscarMonetariasPorIdNecesidad(int id)
        {
            return (List<NecesidadesDonacionesMonetarias>)context.NecesidadesDonacionesMonetarias.Where(o => o.IdNecesidad == id).ToList();
        }
    }
}