using Management.Entities.Concrete;
using System.Collections.Generic;

namespace Management.DataAccess.Abstract
{
    public interface INotificationDal : IRepository<Notification>
    {

        List<Notification> GetAllUnViewed(int appUserId);
        int UnDisplayedNotificationCount(int id);

    }
}
