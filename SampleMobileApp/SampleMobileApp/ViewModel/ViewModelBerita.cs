using SampleMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleMobileApp.ViewModel
{
    public class ViewModelBerita :BindableObject
    {
        public ViewModelBerita()
        {
            listBerita = new List<Berita>
            {
                new Berita{Judul="Belajar Xamarin Forms",Deskripsi="Belajar Data Binding dan ListView"},
                new Berita{Judul="Belajar CSharp",Deskripsi="Belajar konsep OOP dan Design Patern"},
                new Berita{Judul=""}
            };
        }

        private List<Berita> listBerita;
        public List<Berita> ListBerita
        {
            get { return listBerita; }
            set { listBerita = value; OnPropertyChanged("ListBerita"); }
        }

    }
}
