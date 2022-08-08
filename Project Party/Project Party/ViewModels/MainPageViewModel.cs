using Project_Party.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Project_Party.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private Party _selectedParty;
        public ObservableCollection<Party> PartyList { get; }

        public Command LoadPartysCommand { get; }

        public MainPageViewModel()
        {
            Title = "Browse";
            PartyList = new ObservableCollection<Party>();
<<<<<<< HEAD
<<<<<<< HEAD
            ExecuteLoadItemsCommand();
=======
>>>>>>> 11120ee0546093d4fb989a8269084f406b55c6be
=======
>>>>>>> 11120ee0546093d4fb989a8269084f406b55c6be
            LoadPartysCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }
        private ObservableCollection<Party> CreateTestList()
        {
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 11120ee0546093d4fb989a8269084f406b55c6be
            Party party = new Party(1, "Title", "Description", "TestFlyer.jpeg", DateTime.Now, "S-Club", "Fulda", "Leipziger Straße 21");
            
            PartyList.Add(party);
            PartyList.Add(party);
            PartyList.Add(party);

<<<<<<< HEAD
>>>>>>> 11120ee0546093d4fb989a8269084f406b55c6be
=======
>>>>>>> 11120ee0546093d4fb989a8269084f406b55c6be
            return PartyList;
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                PartyList.Clear();
                var partys = await DataStore.GetItemsAsync(true);
<<<<<<< HEAD
<<<<<<< HEAD
                foreach (var party in partys)
                {
                    PartyList.Add(party);
=======
                foreach (var item in partys)
                {
                    PartyList.Add(item);
>>>>>>> 11120ee0546093d4fb989a8269084f406b55c6be
=======
                foreach (var item in partys)
                {
                    PartyList.Add(item);
>>>>>>> 11120ee0546093d4fb989a8269084f406b55c6be
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
