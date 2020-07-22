using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

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

            Button buttonSingIn = FindViewById<Button>(Resource.Id.singinButton);
            Button buttonSingUp = FindViewById<Button>(Resource.Id.singupButton);
            buttonSingIn.Click += ButtonSingIn_Click;
            buttonSingUp.Click += ButtonSingUp_Click;
        }

        private void ButtonSingUp_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(SingUpActivity));
            StartActivity(intent);
        }

        private void ButtonSingIn_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(newFeed));
            StartActivity(intent);
            Finish();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}