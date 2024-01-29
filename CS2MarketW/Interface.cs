using CS2MarketL;
using CS2MarketL.Enums;
using CS2MarketL.Logic;
using CS2MarketL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS2MarketW
{
    public partial class Interface : Form
    {
        public Search search = new Search();
        public List<DefaultSearch> searches = new List<DefaultSearch>();

        public Interface()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
        }

        private async void searchButton_ClickAsync(object sender, EventArgs e)
        {
            if (comboBoxChecker(nameBox.Text, skinBox.Text) == false) 
            {
                MessageBox.Show("Please fill out all the boxes!");
            }
            else
            {
                DefaultSearch newSearch = new DefaultSearch(nameBox.SelectedItem.ToString(), skinBox.SelectedItem.ToString(), (Condition)conditionBox.SelectedItem, (Currency)currencyBox.SelectedItem);

                ReformatedSearch reformatedSearch = search.reformatSearch(newSearch);

                await LSIInterface(reformatedSearch);
            }
        }

        private bool comboBoxChecker(string name, string skin)
        {
            if (name == "" || skin == "")
            {
                return false;
            }
            return true;
        }

        private async Task LSIInterface(ReformatedSearch reformatedSearch)
        {
            await ItemProcessor.LoadItem(reformatedSearch);
        }
    }
}
