using Orbita.Challenge.Core.Entities;
using Orbita.Challenge.Infra.Interface;
using Orbita.Challenge.Service.Interfaces;

namespace Orbita.Challenge.Service.Services
{
    public class StudentService : ServiceBae<Student>, IStudentService
    {
        private readonly IRepositoryStudent _repositoryStudent;

        public StudentService(IRepositoryStudent repositoryStudent) : base(repositoryStudent)
        {
            _repositoryStudent = repositoryStudent;
        }
    }
}