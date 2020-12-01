using MVVM_PagesNavigation.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace MVVM_PagesNavigation.ViewModel
{
    class ViewModelMainWindow : ViewModelBase
    {
        public Page SetPage;

        private Page _GetPage;
        public Page GetPage
        {
            get => _GetPage;
            set => Set(ref _GetPage, value);
        }


        public ViewModelMainWindow()
        {
            SetPage = new View.ViewPageDisplay();
            GetPage = SetPage;
        }


    }
    //class ViewModelMainWindow : ViewModelBase
    //{
    //    public Page Display1;

    //    private Page _currentPage;
    //    public Page CurrentPage
    //    {
    //        get => _currentPage;
    //        set => Set(ref _currentPage, value);
    //    }

    //    public ViewModelMainWindow()
    //    {
    //        Display1 = new View.ViewPageDisplay();

    //        CurrentPage = Display1;
    //    }
    //}
}
