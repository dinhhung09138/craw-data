

namespace SIM.Database
{
    public sealed class SectorRepository : EFRepository<Sector>, ISectorRepository
    {
        public SectorRepository(Context context) : base(context) { }
    }
}
