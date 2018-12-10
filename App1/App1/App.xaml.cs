using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
//using System;
using System.Net.Http;
//using Xamarin.Forms;
using App1.Classes;
using System.Collections.Generic;
using System.Threading.Tasks;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App1
{

    public partial class App : Application
    {
        
        List<BeerDto> Beers;
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage(Beers);
            //MainPage = new NavigationPage(new Page1());
        }

        protected async override void OnStart()
        {
            //await LoadData();
            //if(Beers != null)
            //    MainPage = new MainPage(Beers);
        }

        private async Task< List<BeerDto>> LoadData()
        {
            Beers = new List<BeerDto>();
            string url = "https://api.punkapi.com/v2/beers";
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(url);
                var response = await client.GetAsync(client.BaseAddress);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                JArray array = JArray.Parse(content);
                foreach (JObject item in array)
                {
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
            }
            catch (Exception ex)
            { }
            return Beers;
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
