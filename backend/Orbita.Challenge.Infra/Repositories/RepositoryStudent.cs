using Orbita.Challenge.Core.Entities;
using Orbita.Challenge.Infra.Infra;
using Orbita.Challenge.Infra.Interface;

namespace Orbita.Challenge.Infra.Repositories
{
    public class RepositoryStudent : RepositoryBase<Student>, IRepositoryStudent
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public RepositoryStudent(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
    }
}