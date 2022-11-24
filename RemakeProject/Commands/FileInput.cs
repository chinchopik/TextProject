using RemakeProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RemakeProject.Commands
{
    class FileInput : ICommand
    {
        TextAnalyze _fileInput;
        public FileInput(TextAnalyze viewModel)
        {
            _fileInput = viewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _fileInput.OnExecute();
        }
    }
}
