using App1.Classes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1
{
    //public class RateViewModel : INotifyPropertyChanged
    //{
    //    private decimal rate;
    //    private decimal ask;
    //    private decimal bid;

    //    public decimal Rate
    //    {
    //        get { return rate; }
    //        private set
    //        {
    //            rate = value;
    //            OnPropertyChanged("Rate");
    //        }
    //    }

    //    public decimal Ask
    //    {
    //        get { return ask; }
    //        private set
    //        {
    //            ask = value;
    //            OnPropertyChanged("Ask");
    //        }
    //    }
    //    public decimal Bid
    //    {
    //        get { return bid; }
    //        private set
    //        {
    //            bid = value;
    //            OnPropertyChanged("Bid");
    //        }
    //    }

    //    public ICommand LoadDataCommand { protected set; get; }

    //    public RateViewModel()
    //    {
    //        this.LoadDataCommand = new Command(LoadData);
    //    }

    //    private async void LoadData()
    //    {
    //        string url = "https://api.punkapi.com/v2/beers";
    //        try
    //        {
    //            Beers = new List<BeerDto>();
    //            HttpClient client = new HttpClient();
    //            client.BaseAddress = new Uri(url);
    //            var response = await client.GetAsync(client.BaseAddress);
    //            response.EnsureSuccessStatusCode();
    //            var content = await response.Content.ReadAsStringAsync();
    //            JArray array = JArray.Parse(content);
    //            foreach (JObject item in array)
    //            {
    //                int id = int.Parse(item.GetValue("id").ToString());
    //                String name = item.GetValue("name").ToString();
    //                String imageUrl = item.GetValue("image_url").ToString();
    //                String tagline = item.GetValue("tagline").ToString();
    //                String year = item.GetValue("first_brewed").ToString();
    //                String description = item.GetValue("description").ToString();
    //                String abv = item.GetValue("abv").ToString();
    //                Beers.Add(new BeerDto(id, name, imageUrl, tagline, year, description, abv));
    //                Console.WriteLine(name);
    //            }


    //        }
    //        catch (Exception ex)
    //        { }
    //    }

    //    public event PropertyChangedEventHandler PropertyChanged;
    //    public void OnPropertyChanged(string prop = "")
    //    {
    //        if (PropertyChanged != null)
    //            PropertyChanged(this, new PropertyChangedEventArgs(prop));
    //    }
    //}
}
