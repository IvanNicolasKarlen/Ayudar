using ayudarApp.Dao.Base;
using ayudarApp.Entidades;

namespace ayudarApp.Dao
{
    public class DonacionInsumosDao : BaseRepository<DonacionesInsumos>
    {
        public DonacionInsumosDao(TpDBContext contexto) : base(contexto)
        {
        }
    }
}
