using App1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
    {
        public BeerDto Beer { get; set; }

        public Page1() { }
        public Page1 (BeerDto beer)
		{
			InitializeComponent ();
		}
	}
}