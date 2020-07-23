using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using System;
using System.Net;

namespace CookTime
{
    [Activity(Label = "@string/app_name", Icon = "@mipmap/ic_main", Theme = "@style/AppTheme", MainLauncher = true )]
    public class SingInActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resourceev
            SetContentView(Resource.Layout.SingInLayout);
            //SetContentView(Resource.Layout.OrderView);

            EditText txt_email = FindViewById<EditText>(Resource.Id.txtName);
            EditText txt_password = FindViewById<EditText>(Resource.Id.txtPassword);

            Button buttonSingIn = FindViewById<Button>(Resource.Id.singinButton);
            buttonSingIn.Click += ButtonSingIn_Click;

            Button buttonSingUp = FindViewById<Button>(Resource.Id.singupButton);
            buttonSingUp.Click += ButtonSingUp_Click;



            
        }

        private bool verification()
        {
            EditText txt_email = FindViewById<EditText>(Resource.Id.txtName);
            EditText txt_password = FindViewById<EditText>(Resource.Id.txtPassword);

            WebClient webClient = new WebClient();
            webClient.QueryString.Add("UserName", txt_email.Text);
            webClient.QueryString.Add("Password", txt_password.Text);
            string result = webClient.DownloadString("http://192.168.1.7:9080/proving");
            Console.WriteLine(result.Length);

            if (result.Equals(""))
                return false;
            else
                return true;
        }


        private void ButtonSingUp_Click(object sender, System.EventArgs e)
        {
            if (verification() )
            {

            }
            else
            {
                var intent = new Intent(this, typeof(SingUpActivity));
                StartActivity(intent);
            }


        }

        private void ButtonSingIn_Click(object sender, System.EventArgs e)
        {
            Console.WriteLine("Afuera del if");
            if (verification() )
            {
                Console.WriteLine("entro al if");
                var intent = new Intent(this, typeof(InitActivity));
                StartActivity(intent);
                Finish();
            } 
            else
            {
                Console.WriteLine("Entro al else");
            }


        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}