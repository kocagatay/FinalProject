using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

//CORE KATMANI DİĞER KATMANLARI REFERANS ALMAZ!!!!
namespace Core.DataAccess
{
    //expression : filtrelemek için bu LAMDA'ya benzer ayrı ayrı yazmanı engeller.
    //generic constraint
    //class : referans tipler
    //IEntity : olabilir  veya IEntity implemente eden bir nesne olabilir
    //new() : new'lenebilir olmalı, çünkü IEntity de yazabiliyorum soyut nesyeni yazmayı engellemek için new()'lenebilir ekliyorum...
    public interface IEntityRepository<T> where T: class, IEntity, new()
    {
        //Expression doğal filtreleme gibi olucak...
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
