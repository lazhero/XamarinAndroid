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

            Button buttonGetStart = FindViewById<Button>(Resource.Id.buttonGetStarted);
            buttonGetStart.Click += ButtonGetStart_Click;
            

            // Create your application here
        }

        private void ButtonGetStart_Click(object sender, EventArgs e)
        {
            Console.WriteLine("press");
            register();
            
        }

        private void ButtonSingIn_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(SingInActivity));
            StartActivity(intent);
        }
        private void register()
        {
            Console.WriteLine("Registrar");
            EditText FirstName = FindViewById<EditText>(Resource.Id.UserName);
            EditText LastName = FindViewById<EditText>(Resource.Id.UserLastName);
            EditText User = FindViewById<EditText>(Resource.Id.TextUser);
            EditText Password = FindViewById<EditText>(Resource.Id.TextPassword);
            EditText Age = FindViewById<EditText>(Resource.Id.AgeNumber);
            Console.WriteLine("BIENVENIDO "+FirstName.Text);
            Console.WriteLine("BIENVENIDO " + LastName.Text);
            Console.WriteLine("BIENVENIDO " + User.Text);
            Console.WriteLine("BIENVENIDO " + Password.Text);
            Console.WriteLine("BIENVENIDO " + Age.Text);

            API apii = new API();
            Console.WriteLine("XDXD");
            string register = apii.connect2("register", User.Text, Password.Text, FirstName.Text,LastName.Text,"5");
            //string register = apii.connect2("register", "HOLA", "ADIOS", "SOYYO", "XDE","55");
            Console.WriteLine("buscamos"+register);
        }
    }
}