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
using MvvmCross.Droid.Shared.Attributes;
using demo.Core.ViewModels;

namespace nombreDemo.Andro.Fragments
{
    [MvxFragment(typeof(FirstViewModel), Resource.Id.content_frame, true)]
    [Register("nombredemo.andro.fragments.HomeFragment")]
    public class HomeFragment : BaseFragment<HomeViewModel>
    {
        protected override int FragmentId
        {
            get
            {
                return Resource.Layout.fragment_home;
            }
        }
    }
}