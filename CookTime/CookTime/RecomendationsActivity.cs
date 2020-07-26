
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace CookTime
{
    [Activity(Label = "RecomendationsActivity")]
    public class RecomendationsActivity : Activity
    {
        Toolbar toolbar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Recomendations);
            toolbar = FindViewById<Toolbar>(Resource.Id.toolbar1);
            SetActionBar(toolbar);

            // Create your application here
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.navigation, menu);
            return base.OnCreateOptionsMenu(menu);
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