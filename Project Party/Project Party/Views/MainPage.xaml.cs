using Project_Party.Models;
using Project_Party.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project_Party.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
<<<<<<< HEAD
<<<<<<< HEAD
=======
        List<Party> partyList;
>>>>>>> 11120ee0546093d4fb989a8269084f406b55c6be
=======
        List<Party> partyList;
>>>>>>> 11120ee0546093d4fb989a8269084f406b55c6be
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }

       
    }
}