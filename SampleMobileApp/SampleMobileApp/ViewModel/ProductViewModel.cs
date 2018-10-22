using SampleMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleMobileApp.ViewModel
{
    public class ProductViewModel : BindableObject
    {
        public ProductViewModel()
        {
            listProduct = new List<Product>
            {
                new Product {NamaProduct="Apotik K24",Deskripsi="Apotik K24",Gambar="k24.jpg",Harga=200000},
                new Product {NamaProduct="Laboratorium Pramita",Deskripsi="Laboratorium Pramita",Gambar="pramita.jpg",Harga=300000},
                new Product {NamaProduct="Laboratorium Prodia",Deskripsi="Laboratorium Prodia",Gambar="prodia.jpg",Harga=150000}
            };
        }

        private List<Product> listProduct;
        public List<Product> ListProduct
        {
            get { return listProduct; }
            set { listProduct = value; OnPropertyChanged("ListProduct"); }
        }

        

    }
}
