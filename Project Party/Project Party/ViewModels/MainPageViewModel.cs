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
            LoadPartysCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }
        private ObservableCollection<Party> CreateTestList()
        {
            Party party = new Party(1, "Title", "Description", "TestFlyer.jpeg", DateTime.Now, "S-Club", "Fulda", "Leipziger Straße 21");
            
            PartyList.Add(party);
            PartyList.Add(party);
            PartyList.Add(party);

            return PartyList;
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                PartyList.Clear();
                var partys = await DataStore.GetItemsAsync(true);
                foreach (var item in partys)
                {
                    PartyList.Add(item);
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
