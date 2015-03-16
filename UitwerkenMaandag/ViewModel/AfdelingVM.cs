using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UitwerkenMaandag.Model;

namespace UitwerkenMaandag.ViewModel
{
    public class AfdelingVM : ViewModelBase
    {
        public string AfdelingName { get; set; }

        public ObservableCollection<ProductVM> ProductList { get; set; }

        private ProductVM _selectedProduct;
        public ProductVM SelectedProduct {
            get { return _selectedProduct; }
            set { 
                _selectedProduct = value;
                RaisePropertyChanged();
            }
        }

        public AfdelingVM()
        {
            var repo = new AfdelingRepository();
            var afdeling = repo.GetAfdelingById(1);

            this.AfdelingName = afdeling.Naam;
            
            var productVMLISt = afdeling.Producten.Select(p => new ProductVM(p)).ToList();
            this.ProductList = new ObservableCollection<ProductVM>(productVMLISt);

            this.SelectedProduct = this.ProductList[0];

        }
    }
}
