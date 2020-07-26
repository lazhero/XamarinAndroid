using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CookTime
{
    [Activity(Label = "InitActivity")]
    public class InitActivity : Activity
    {
        string username = SingInActivity.getusername; //(asi se deberia llamar)

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.InitLayout);

            Button buttonInit = FindViewById<Button>(Resource.Id.buttonToInit);
            buttonInit.Click += ButtonInit_Click;

        }

        


        

        private void ButtonInit_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(newFeed));
            StartActivity(intent);            
        }
    }
}