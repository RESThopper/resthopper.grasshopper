using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Resthopper.Core.ViewModels;

namespace Resthopper.Core.Views
{
    /// <summary>
    /// Interaction logic for MainPanelView.xaml
    /// </summary>
    public partial class MainPanelView
    {
        public MainPanelView()
        {
            DataContext = new MainPanelViewModel();
            InitializeComponent();
        }

        private MainPanelViewModel ViewModel => DataContext as MainPanelViewModel;
    }
}
