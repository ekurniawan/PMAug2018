using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public MyMasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new MyMasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MyMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MyMasterDetailPageMenuItem> MenuItems { get; set; }
            
            public MyMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MyMasterDetailPageMenuItem>(new[]
                {
                    new MyMasterDetailPageMenuItem { Id = 0, Title = "Hitung Nilai",
                        TargetType =typeof(HitungNilaiPage) },
                    new MyMasterDetailPageMenuItem { Id = 1, Title = "Luas Segitiga",
                        TargetType =typeof(LuasSegitigaPage) },
                    new MyMasterDetailPageMenuItem { Id = 2, Title = "Sample List",
                        TargetType =typeof(SampleListPage) },
                    new MyMasterDetailPageMenuItem { Id = 3, Title = "Sample List Text",
                        TargetType =typeof(SampleListTextPage) },
                    new MyMasterDetailPageMenuItem { Id = 4, Title = "Product List",
                        TargetType =typeof(ProductListPage) },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}