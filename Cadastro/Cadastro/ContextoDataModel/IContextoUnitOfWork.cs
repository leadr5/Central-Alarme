using Cadastro.Modelo;
using DevExpress.Mvvm.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cadastro.ContextoDataModel {

    /// <summary>
    /// IContextoUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IContextoUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The CentralAlarme entities repository.
        /// </summary>
		IRepository<CentralAlarme, int> CentralAlarme { get; }
    }
}
