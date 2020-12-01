using MVVM_PagesNavigation.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MVVM_PagesNavigation.ViewModel
{
    class ViewModelMainWindow : ViewModelBase
    {
        public Page Display;

        private Page _currentPage;
        public Page CurrentPage
        {
            get => _currentPage;
            set => Set(ref _currentPage, value);
        }

        public ViewModelMainWindow()
        {
            Display = new View.ViewPageDisplay();

            CurrentPage = Display;
        }
    }
}
