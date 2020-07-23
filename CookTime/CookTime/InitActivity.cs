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
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.InitLayout);

            Button buttonInit = FindViewById<Button>(Resource.Id.buttonToInit);
            buttonInit.Click += ButtonInit_Click;

            // Create your application here
        }

        private void ButtonInit_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(newFeed));
        }
    }
}