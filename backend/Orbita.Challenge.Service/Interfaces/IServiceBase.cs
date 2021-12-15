using Orbita.Challenge.Core.Entities;
using System;
using System.Collections.Generic;

namespace Orbita.Challenge.Service.Interfaces
{
    public interface IServiceBase<T> where T : EntityBase
    {
        void Create(T student);

        void Update(T student);

        T GetById(Guid Id);

        IEnumerable<T> GetAll();
    }
}