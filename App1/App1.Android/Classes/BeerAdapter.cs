using Android;
using Android.Content;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Classes
{
    /*public class BeerAdapter : BaseAdapter<BeerDto>
    {
        private List<BeerDto> beerList;
        private Context sContext;
        public BeerAdapter(Context context, List<BeerDto> list)
        {
            beerList = list;
            sContext = context;
        }
        public override BeerDto this[int position]
        {
            get
            {
                return beerList[position];
            }
        }
        public override int Count
        {
            get
            {
                return beerList.Count;
            }
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            try
            {
                if (row == null)
                {
                    row = LayoutInflater.From(sContext).Inflate(Resource.Layout.Main, null, false);
                }
                TextView txtName = row.FindViewById<TextView>(Resource.Id.Name);
                txtName.Text = beerList[position].Name;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            finally { }
            return row;
        }
    }*/
}
