﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top4HoneyChainsMicroservices.Repository.Abstract
{
    public interface IDatabaseBusiness<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
        List<T> GetAll();
        T GetById(int id);
    }
}