

namespace SIM.Database
{
    public sealed class CompanyRepository : EFRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(Context context) : base(context) { }
    }
}
