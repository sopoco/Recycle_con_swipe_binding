using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using demo.Core.ViewModels;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Binding.Droid.BindingContext;
using Android.Support.V7.Widget;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvvmCross.Droid.Shared.Attributes;
using Android.Support.V7.Widget.Helper;
using demo.Core.Services;
using App1.swipe;

namespace nombreDemo.Andro.Fragments
{
    [MvxFragment(typeof(FirstViewModel), Resource.Id.content_frame, true)]
    [Register("nombredemo.andro.fragments.RecyclerViewFragment")]
    public class RecyclerViewFragment : BaseFragment<RecyclerViewModel>
    {
        //RvAdapter adapter;
       // Nombres _nombres;

        protected override int FragmentId
        {
            get
            {
                return Resource.Layout.fragment_example_recyclerview;
            }
        }
        
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);

            var recyclerView = ignore.FindViewById<MvxRecyclerView>(Resource.Id.my_recycler_view);

            if (recyclerView != null)
            {
                recyclerView.HasFixedSize = true;
                var layoutManager = new LinearLayoutManager(Activity);
                recyclerView.SetLayoutManager(layoutManager);

                ItemTouchHelper.Callback callback = new SimpleItemTouchHelperCallback(recyclerView.GetAdapter());
                ItemTouchHelper itemTouchHelper = new ItemTouchHelper(callback);
                itemTouchHelper.AttachToRecyclerView(recyclerView);
                recyclerView.SetItemAnimator(new DefaultItemAnimator());
            }

            return ignore;
        }

        public override void OnDestroyView()
        {
            base.OnDestroyView();
            
        }
    }

}
