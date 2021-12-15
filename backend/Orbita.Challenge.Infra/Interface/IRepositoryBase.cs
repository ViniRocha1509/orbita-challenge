using System;
using System.Collections.Generic;

namespace Orbita.Challenge.Infra.Interface
{
    public interface IRepositoryBase<T>
    {
        void Create(T entity);

        void Update(T entity);

        IEnumerable<T> Get();

        T Get(Guid id);
    }
}