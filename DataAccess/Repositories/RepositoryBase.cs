﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using UrbanDictionary.DataAccess.Repositories.Contracts;
using UrbanDictionary.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;


namespace UrbanDictionary.DataAccess.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected UrbanDictionaryDBContext UrbanDictionaryDBContext { get; set; }

        public RepositoryBase(UrbanDictionaryDBContext urbanDictionaryDBContext)
        {
            this.UrbanDictionaryDBContext = urbanDictionaryDBContext;
        }

        public IQueryable<T> FindAll()
        {
            return this.UrbanDictionaryDBContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.UrbanDictionaryDBContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            this.UrbanDictionaryDBContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.UrbanDictionaryDBContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.UrbanDictionaryDBContext.Set<T>().Remove(entity);
        }
    }
}
