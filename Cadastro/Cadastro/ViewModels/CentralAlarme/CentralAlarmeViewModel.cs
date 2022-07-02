using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using Cadastro.ContextoDataModel;
using Cadastro.Common;
using Cadastro.Modelo;

namespace Cadastro.ViewModels {

    /// <summary>
    /// Represents the single CentralAlarme object view model.
    /// </summary>
    public partial class CentralAlarmeViewModel : SingleObjectViewModel<CentralAlarme, int, IContextoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CentralAlarmeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CentralAlarmeViewModel Create(IUnitOfWorkFactory<IContextoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CentralAlarmeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CentralAlarmeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CentralAlarmeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CentralAlarmeViewModel(IUnitOfWorkFactory<IContextoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.CentralAlarme, x => x.usuario) {
                }



    }
}
