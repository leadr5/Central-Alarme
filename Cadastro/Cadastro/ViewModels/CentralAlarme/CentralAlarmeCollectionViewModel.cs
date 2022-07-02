using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using Cadastro.ContextoDataModel;
using Cadastro.Common;
using Cadastro.Modelo;

namespace Cadastro.ViewModels {

    /// <summary>
    /// Represents the CentralAlarme collection view model.
    /// </summary>
    public partial class CentralAlarmeCollectionViewModel : CollectionViewModel<CentralAlarme, int, IContextoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CentralAlarmeCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CentralAlarmeCollectionViewModel Create(IUnitOfWorkFactory<IContextoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CentralAlarmeCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CentralAlarmeCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CentralAlarmeCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CentralAlarmeCollectionViewModel(IUnitOfWorkFactory<IContextoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.CentralAlarme) {
        }
    }
}