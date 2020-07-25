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
    [Activity(Label = "ProfileActivity")]
    public class ProfileActivity : Activity
    {
        Toolbar toolbar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Profile);
            toolbar = FindViewById<Toolbar>(Resource.Id.toolbar1);
            SetActionBar(toolbar);

            TextView txt_userName = FindViewById<TextView>(Resource.Id.textView2);

            Button buttonFollowing = FindViewById<Button>(Resource.Id.buttonFollowing);
            buttonFollowing.Click += ButtonFollowing_Click;

            Button buttonFollowers = FindViewById<Button>(Resource.Id.buttonFollowers);
            buttonFollowers.Click += ButtonFollowers_Click;

            Button buttonAdmin = FindViewById<Button>(Resource.Id.buttonadministration);
            buttonAdmin.Click += ButtonAdmin_Click;

            // Create your application here
        }

        private void ButtonAdmin_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(administration));
          
            
        }

        private void ButtonFollowing_Click(object sender, EventArgs e)
        {
            var intent1 = new Intent(this, typeof(FollowingActivity));
            StartActivity(intent1);
            
        }

        private void ButtonFollowers_Click(object sender, EventArgs e)
        {
            var intent2 = new Intent(this, typeof(FollowersActivity));
            StartActivity(intent2);

        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.navigation, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        private void CreateCompany()
        {
            API api = new API();
            string Ap = api.connecta("Company", "unaa", "2", "2", "2", "2",  "a");
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.ic_home:
                    StartActivity(typeof(newFeed));
                    Finish();
                    break;
                case Resource.Id.ic_recomendations:
                    StartActivity(typeof(RecomendationsActivity));
                    Finish();
                    break;
                case Resource.Id.ic_notifications:
                    StartActivity(typeof(NotificationsActivity));
                    Finish();
                    break;
                case Resource.Id.ic_profile:
                    StartActivity(typeof(ProfileActivity));
                    Finish();
                    break;
                case Resource.Id.ic_add:
                    StartActivity(typeof(ShareRecipeActivity));
                    Finish();
                    break;



            }
            return base.OnOptionsItemSelected(item);
        }
    }
}