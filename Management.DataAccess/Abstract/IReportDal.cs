using Management.Entities.Concrete;

namespace Management.DataAccess.Abstract
{
    public interface IReportDal : IRepository<Report>
    {
        Report GetWithWorkId(int id);
        int GetUserReportCount(int id);
        int GetAllUserReportCount();

    }
}
