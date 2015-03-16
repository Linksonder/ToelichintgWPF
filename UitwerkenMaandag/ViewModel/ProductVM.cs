using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace UitwerkenMaandag.ViewModel
{
    public class ProductVM : ViewModelBase
    {
        private Product _product;

        public String Name { 
            get{ return _product.Name;}
            set { _product.Name = value; }
        }

        public double Price
        {
            get { return _product.Price; }
            set { _product.Price = value; }
        }

        public ICommand PrintProductCommand { get; set; }

        public ProductVM()
        {
           

            PrintProductCommand = new RelayCommand(PrintProduct);
        }

        public void PrintProduct()
        {
            Console.WriteLine("Prodcut " + Name + " costs " + Price + "dollah");
        }

 

    }
}
