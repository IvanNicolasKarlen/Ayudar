using ayudarApp.Dao.Base;
using ayudarApp.Entidades;
using ayudarApp.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ayudarApp.Dao
{
    public class DenunciasDao : BaseRepository<Denuncias>//Uso de Generics
    {
        TpDBContext context;
        public DenunciasDao(TpDBContext contexto) : base(contexto)
        {
            context = contexto;

        }
        public List<Denuncias> ObtenerDenunciasEnRevision()
        {
            List<Denuncias> listaObtenida = context.Denuncias.Where(o => o.Necesidades.Estado == (int)TipoEstadoNecesidad.Revision).ToList();
            return listaObtenida;
        }

        public List<MotivoDenuncia> ObtenerMotivosDenuncia()
        {
            return context.MotivoDenuncia.ToList();
        }

    }
}