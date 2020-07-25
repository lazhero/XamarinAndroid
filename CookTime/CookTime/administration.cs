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
    [Activity(Label = "administration")]
    public class administration : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.administration);


            Button BCreate = FindViewById<Button>(Resource.Id.buttoncreatecompany);
            BCreate.Click += BCreate_Click;

            ;

            // Create your application here
        }
        private void CreateCompany()
        {

            EditText txt_userName = FindViewById<EditText>(Resource.Id.editUser);
            EditText txt_CompanyName = FindViewById<EditText>(Resource.Id.editCompanyName);
            EditText txt_ContactNumber = FindViewById<EditText>(Resource.Id.editCompanyNumber);
            EditText txt_InitHour = FindViewById<EditText>(Resource.Id.NumberInitHour);
            EditText txt_IniMinute = FindViewById<EditText>(Resource.Id.NumebrInitMinute);
            EditText txt_FinishHour = FindViewById<EditText>(Resource.Id.NumberFinishHour);
            EditText txt_FinishMinute = FindViewById<EditText>(Resource.Id.NumberFinishMinute);

            API api = new API();
            string Ap = api.connecta("Company", txt_CompanyName.Text, txt_InitHour.Text, txt_IniMinute.Text, txt_FinishHour.Text, txt_FinishMinute.Text, txt_userName.Text);
        }

        private void BCreate_Click(object sender, EventArgs e)
        {
            CreateCompany();
        }
    }
}