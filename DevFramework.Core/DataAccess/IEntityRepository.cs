using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DevFramework.Core.DataAccess
{
    public interface IEntityRepository<T>
                     where T:class,IEntity,new()
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter = null);//belirttiğim tipte olacağı için  T veri türü olarak belirlendi
        T Add(T entity);//eklenen nesneyi geri döndürmek için T olarak kullanıldı
        T Update(T entity);
        void Delete(T entity);//bazı tabloların pk alanları uniquindentifier yada int yada string olabiliyor
    }
}
