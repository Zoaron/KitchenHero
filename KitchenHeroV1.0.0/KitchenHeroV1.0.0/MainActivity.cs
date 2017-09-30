using Android.App;
using Android.Widget;
using Android.OS;

namespace KitchenHeroV1._0._0
{
    [Activity(Label = "KitchenHeroV1._0._0", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

