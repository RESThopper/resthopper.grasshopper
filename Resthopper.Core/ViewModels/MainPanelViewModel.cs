using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.CommandWpf;
using Rhino;

namespace Resthopper.Core.ViewModels
{
    internal class MainPanelViewModel : Rhino.UI.ViewModel
    {
        public RelayCommand DeclareInputsCommand { get; set; }

        public MainPanelViewModel()
        {
            DeclareInputsCommand = new RelayCommand(OnDeclareInputs);
        }

        public void OnDeclareInputs()
        {
            RhinoApp.WriteLine("Good!");
        }
    }
}
