using Management.DataAccess.Abstract;
using Management.Entities.Concrete;

namespace Management.DataAccess.Concrete.EfCore.Repositories
{
    public class EfUrgencyRepository : EfGenericRepository<Urgency>, IUrgencyDal
    {
    }
}
