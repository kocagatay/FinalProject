using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new() //referans olmalı, IEntity olmalı, ama soyutolamicagı için new'lenebilir ekledik!!
        where TContext : DbContext, new() // NorthwindContext'deki gibi DbContext olmalı ve new'lenebilir olmalı!!
    {
        public void Add(TEntity entity)
        {
            //1. saat 50. dakika gibi tekrar etmekte fayda var!!!! (8.ders) 9.Derste yeri değişti bu kodların...
            //
            using (TContext context = new TContext())//IDisposable pattern implementation of C#
            {
                var addedEntity = context.Entry(entity); //verikaynağından benim gönderdiğim producttan herhangi bir nesneyi eşle --referansı yakalama
                addedEntity.State = EntityState.Added; // burda da ne yapacağını, ekleme işlemeni yapması gerektiğini
                context.SaveChanges(); //değişikleri kaydet yani yap anlamında artık
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null //filtre null mı?
                    ? context.Set<TEntity>().ToList() //evetse hepsini getir
                    : context.Set<TEntity>().Where(filter).ToList(); // değilse filtre varsa filtreleyip ver
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
