﻿using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Smoother.IoC.Dapper.Repository.UnitOfWork.Data;
using Smoother.IoC.Dapper.Repository.UnitOfWork.UoW;

namespace Smoother.IoC.Dapper.Repository.UnitOfWork.Repo
{
    public interface IRepository<TSession, TEntity, TPk>
        where TEntity : class, ITEntity<TPk>
        where TSession : ISession
    {
        TEntity Get(TPk key, IDbConnection session = null);
        Task<TEntity> GetAsync(TPk key, IDbConnection session = null);
        IEnumerable<TEntity>  GetAll(IDbConnection session = null);
        Task<IEnumerable<TEntity>> GetAllAsync(IDbConnection session = null);
        int SaveOrUpdate(TEntity entity, IDbTransaction transaction);
        Task<int> SaveOrUpdateAsync(TEntity entity, IDbTransaction transaction);
    }
}