using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using Xamarin.Forms;
using App1.Classes;
using System.Collections.Generic;

namespace App1
{
    public partial class MainPage : ContentPage
    {

        public List<BeerDto> Beers { get; set; }
        public MainPage(List<BeerDto> list)
        {
            LoadData();
        }

        private async void LoadData()
        {
            string url = "https://api.punkapi.com/v2/beers";
            try
            {
                Beers = new List<BeerDto>();
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(url);
                var response = await client.GetAsync(client.BaseAddress);
                response.EnsureSuccessStatusCode(); 
                var content = await response.Content.ReadAsStringAsync();
                JArray array = JArray.Parse(content);
                foreach(JObject item in array){
                    int id = int.Parse(item.GetValue("id").ToString());
                    String name = item.GetValue("name").ToString();
                    String imageUrl = item.GetValue("image_url").ToString();
                    String tagline = item.GetValue("tagline").ToString();
                    String year = item.GetValue("first_brewed").ToString();
                    String description = item.GetValue("description").ToString();
                    String abv = item.GetValue("abv").ToString();
                    Beers.Add(new BeerDto(id, name, imageUrl, tagline, year, description, abv));
                    Console.WriteLine(name);
                }
                InitializeComponent();
                this.BindingContext = this;


            }
            catch (Exception ex)
            { }
        }

        public async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            BeerDto beer = e.Item as BeerDto;
            var page = new Page1(beer);
            //this.Navigation.PushAsync(page);
            await Navigation.PushAsync(new Page1(beer));
        }
    }
}
