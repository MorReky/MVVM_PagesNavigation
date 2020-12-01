using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_PagesNavigation.Infrastact.Commands.Base
{
    internal abstract class CommandBase : ICommand
    {
        /// <summary>
        /// Событие изменения возможности выполнения Execute
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public abstract bool CanExecute(object parameter);
        

        public abstract void Execute(object parameter);
    }
}
