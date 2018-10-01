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
                new Product {NamaProduct="Buah buahan",Deskripsi="Buah buahan segar",Gambar="gambar1.jpg",Harga=200000},
                new Product {NamaProduct="Makanan Olahan Ayam",Deskripsi="Makanan olahan dengan bahan daging ayam",Gambar="gambar2.jpg",Harga=300000},
                new Product {NamaProduct="Makanan Olahan Ikan",Deskripsi="Makanan olahan dengan bahan dasar ikan",Gambar="gambar3.jpg",Harga=150000}
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
