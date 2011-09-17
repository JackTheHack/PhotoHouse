using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Norm;
using Photoshop.Common;

namespace Photoshop.DataAccess
{
    internal class MongoSession<T> : IDisposable
    {
        private readonly IMongo provider;

        public MongoSession()
        {
            this.provider = Mongo.Create(MainConfiguration.DatabaseConnection);
        }

        public IQueryable<T> Queryable
        {
            get { return provider.GetCollection<T>().AsQueryable(); }
        }

        public IMongo Provider
        {
            get { return this.provider; }
        }

        public void Add<T>(T item) where T : class, new()
        {
            this.provider.GetCollection<T>().Insert(item);
        }

        public void Dispose()
        {
            this.provider.Dispose();
        }
        public void Delete<T>(T item) where T : class, new()
        {
            this.provider.GetCollection<T>().Delete(item);
        }

        public void Drop<T>()
        {
            this.provider.Database.DropCollection(typeof(T).Name);
        }

        public void Save<T>(T item) where T : class,new()
        {
            this.provider.GetCollection<T>().Save(item);
        }


    }   
}
