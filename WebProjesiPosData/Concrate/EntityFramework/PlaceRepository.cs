using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WebProjesiDataAccess.Models;
using WebProjesiPosData.Abstract;

namespace WebProjesiPosData.Concrate.EntityFramework
{
    public class PlaceRepository : IPlaceRepository
    {
        protected readonly WebContext DbContext;
        protected readonly DbSet<Place> DbSet;
        public PlaceRepository(WebContext dbContext) : base()
        {
            this.DbContext = dbContext;
            this.DbSet = DbContext.Set<Place>();
        }

        public void Add(Place entity)
        {
            this.DbContext.Entry(entity).State = EntityState.Added;
            this.DbContext.Set<Place>().Add(entity);
            this.Save();
        }

        public void Delete(Place entity)
        {
            this.DbContext.Entry(entity).State = EntityState.Deleted;
            this.Save();
        }

        public Place Get(Expression<Func<Place, bool>> filter = null)
        {
            return this.DbSet.SingleOrDefault(filter);
        }

        public IEnumerable<Place> GetAll(Expression<Func<Place, bool>> filter = null)
        {
            return DbSet.Where(filter).ToList();
            //throw new NotImplementedException();
        }

        public void Save()
        {
            this.DbContext.SaveChanges();
        }

        public void Update(Place entity)
        {
            throw new NotImplementedException();
        }
    }
}
