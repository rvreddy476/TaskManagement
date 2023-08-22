using TaskManagement.Persistance.Context;

namespace TaskManagement.Persistance.Repositories
{
    public class UnitOfWork
    {
        private readonly UserMangagementDbContext _userMangagementDbContext;

        public UnitOfWork(UserMangagementDbContext userMangagementDbContext)
        {
            _userMangagementDbContext = userMangagementDbContext;
        }
        public Task Save(CancellationToken cancellationToken)
        {
            return _userMangagementDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
