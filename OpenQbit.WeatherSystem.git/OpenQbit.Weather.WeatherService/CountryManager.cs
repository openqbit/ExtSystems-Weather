﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Weather.WeatherService.Contracts;
using OpenQbit.Weather.DAL.DataAccess.Contracts;

using Microsoft.Practices.Unity;

namespace OpenQbit.Weather.WeatherService
{
    public class CountryManager : ICountryManager
    {
        private IRepository _repository;

        [InjectionConstructor]
        public CountryManager(IRepository repository)
        {
            this._repository = repository;
        }

        public bool Recored<T>(T obj) where T : class
        {
            return _repository.Create(obj);
        }

        public bool Update<T>(T obj) where T : class
        {
            return _repository.Update(obj);
        }

        public bool Delete<T>(T obj) where T : class
        {
            return _repository.Delete(obj);
        }

        public List<T> GetAll<T>() where T : class
        {
            return _repository.GetAll<T>();
        }

        public T Find<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return _repository.Find(predicate);
        }

        public List<T> FindList<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return _repository.FindList(predicate);
        }

        public bool Save()
        {
            return _repository.Save();
        }

       
    }
}
