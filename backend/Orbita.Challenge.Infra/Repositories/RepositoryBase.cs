using Microsoft.EntityFrameworkCore;
using Orbita.Challenge.Core.Entities;
using Orbita.Challenge.Infra.Infra;
using Orbita.Challenge.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Orbita.Challenge.Infra.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : EntityBase
    {
        private readonly ApplicationDbContext _applicationDbContext;

        protected DbSet<T> DbEntity { get; set; }

        public RepositoryBase(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            DbEntity = applicationDbContext.Set<T>();
        }

        public void Create(T entity)
        {
            DbEntity.Add(entity);
            _applicationDbContext.SaveChanges();
        }

        public IEnumerable<T> Get()
        {
            return DbEntity.ToList();
        }

        public T Get(Guid id)
        {
            return DbEntity.Find(id);
        }

        public void Update(T entity)
        {
            DbEntity.Update(entity);
            _applicationDbContext.SaveChanges();
        }
    }
}