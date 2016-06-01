using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {

        public HomeViewModel()
        {
            Recycler = new RecyclerViewModel();
        }

        /// <summary>Gets the recycler.</summary>
        /// <value>The recycler.</value>
        public RecyclerViewModel Recycler { get; private set; }

        //public MvxCommand GoToInfoCommand
        //{
        //    get { return new MvxCommand(() => ShowViewModel<InfoViewModel>()); }
        //}
    }
}
