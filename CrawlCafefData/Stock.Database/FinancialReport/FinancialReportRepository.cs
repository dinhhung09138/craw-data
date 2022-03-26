

namespace Stock.Database
{
    public sealed class FinancialReportRepository : EFRepository<FinancialReport>, IFinancialReportRepository
    {
        public FinancialReportRepository(Context context) : base(context) { }
    }
}
