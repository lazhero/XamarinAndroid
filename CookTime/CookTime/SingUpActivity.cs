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
    [Activity(Label = "SingUnActivity")]
    public class SingUpActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SingUpLayout);
            Button buttonSingIn = FindViewById<Button>(Resource.Id.buttonSingIn2);
            buttonSingIn.Click += ButtonSingIn_Click;

          
           


            // Create your application here
        }

        private void ButtonSingIn_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(SingInActivity));
            StartActivity(intent);
        }
    }
}