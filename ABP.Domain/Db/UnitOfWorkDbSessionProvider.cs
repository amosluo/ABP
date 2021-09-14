using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.NHibernate;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP.Domain.Db
{
    public class UnitOfWorkDbSessionProvider : ISessionProvider, ISingletonDependency
    {
        private readonly ICurrentUnitOfWorkProvider _unitOfWorkProvider;

        public UnitOfWorkDbSessionProvider(ICurrentUnitOfWorkProvider currentUnitOfWorkProvider)
        {
            _unitOfWorkProvider = currentUnitOfWorkProvider;
        }

        public ISession Session => _unitOfWorkProvider.Current?.GetSession();
    }
}
