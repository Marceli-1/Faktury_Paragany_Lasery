using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;

namespace Faktury_Paragany_Lasery.ViewModel.Commands
{
    public class RelayCommand : ICommand  
    {  
        public event EventHandler CanExecuteChanged;  
        private readonly Func<object, bool> canExecute;  
        private readonly Action<object> execute;  
  
  
        public RelayCommand(Func<object, bool> canExecute, Action<object> execute)  
        {  
            this.canExecute = canExecute;  
            this.execute = execute;  
        }  
  
        public bool CanExecute(object parameter)  
        {  
            return canExecute(parameter);  
        }  
  
        public void Execute(object parameter)  
        {  
            execute(parameter);  
        }
    }
}
