using Cadastro.Modelo;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cadastro.ContextoDataModel {

    /// <summary>
    /// A ContextoUnitOfWork instance that represents the run-time implementation of the IContextoUnitOfWork interface.
    /// </summary>
    public class ContextoUnitOfWork : DbUnitOfWork<Contexto>, IContextoUnitOfWork {

        public ContextoUnitOfWork(Func<Contexto> contextFactory)
            : base(contextFactory) {
        }

        IRepository<CentralAlarme, int> IContextoUnitOfWork.CentralAlarme {
            get { return GetRepository(x => x.Set<CentralAlarme>(), (CentralAlarme x) => x.id); }
        }
    }
}
