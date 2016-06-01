using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace demo.Droid.Views
{
    [Activity(Label = "Lista")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }
    }
}
