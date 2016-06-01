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
using Android.Content.PM;
using demo.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace nombreDemo.Andro.Activities
{
    [Activity(
        Label = "First Activity",
        Theme = "@style/AppTheme",
        LaunchMode = LaunchMode.SingleTop,
        Name = "nombredemo.andro.activities.MainActivity"
    )]
    public class FirstActivity : MvxCachingFragmentCompatActivity<FirstViewModel>
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);

            if (bundle == null)
                ViewModel.ShowMenu();

        }

    }
}