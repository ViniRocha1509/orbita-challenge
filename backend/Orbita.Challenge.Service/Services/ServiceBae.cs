using Orbita.Challenge.Core.Entities;
using Orbita.Challenge.Infra.Interface;
using Orbita.Challenge.Service.Interfaces;
using System;
using System.Collections.Generic;

namespace Orbita.Challenge.Service.Services
{
    public class ServiceBae<TEntity> : IServiceBase<TEntity> where TEntity : EntityBase
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBae(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void Create(TEntity student)
        {
            _repository.Create(student);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.Get();
        }

        public TEntity GetById(Guid Id)
        {
            return _repository.Get(Id);
        }

        public void Update(TEntity student)
        {
            _repository.Update(student);
        }
    }
}