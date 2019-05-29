using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAccess.NHibernate
{
    public class NhQuerableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        NHibernateHelper _nhibernateHelper;
        IQueryable<T> _entities;//oldu bu iş

        public NhQuerableRepository(NHibernateHelper nhibernateHelper)
        {
            _nhibernateHelper = nhibernateHelper;
        }

        public IQueryable<T> Table => this.Entities;
        public virtual  IQueryable<T> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _nhibernateHelper.OpenSession().Query<T>();
                }
                return _entities;
            }
        }
    }
}
