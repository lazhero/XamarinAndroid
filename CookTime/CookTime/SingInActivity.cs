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
        
        public static string UserName;
        private static string globalusername;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resourceev
            SetContentView(Resource.Layout.SingInLayout);
            //SetContentView(Resource.Layout.OrderView);

            Button buttonSingIn = FindViewById<Button>(Resource.Id.singinButton);
            buttonSingIn.Click += ButtonSingIn_Click;

            Button buttonSingUp = FindViewById<Button>(Resource.Id.singupButton);
            buttonSingUp.Click += ButtonSingUp_Click;

            

            
        }

        private bool verification()
        {
            EditText txt_userName = FindViewById<EditText>(Resource.Id.txtName);
            EditText txt_password = FindViewById<EditText>(Resource.Id.txtPassword);

            

            UserName = txt_userName.Text;

            API api = new API();
            string xd = api.connect("proving", txt_userName.Text, txt_password.Text);
           
            if (xd.Equals(""))
                return false;
            else
                return true;
        }


        private void ButtonSingUp_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(SingUpActivity));
            StartActivity(intent);
            Finish();
        }

        private void ButtonSingIn_Click(object sender, System.EventArgs e)
        {
            if (verification())
            {
                
                var intent = new Intent(this, typeof(InitActivity));
                intent.PutExtra("UserName", UserName);
                StartActivity(intent);
                Finish();
            } 
            else
            {
            }


        }
        public static string getusername
        {
            get { return globalusername; }
            set { globalusername = value; }
        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}