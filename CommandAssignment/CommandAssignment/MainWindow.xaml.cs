using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using CommandAssignment.Commands;

namespace CommandAssignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IDevice _lamp;
        private ICommand _command;
        private LightController _lightController; 


        public MainWindow()
        {
            InitializeComponent();
            
            _lamp = new Lamp();
            _lightController = new LightController();
        }

        private void OnOffButton_Click(object sender, RoutedEventArgs e)
        {
            _command = new ToggleCommand(_lamp);
            _lightController.SetCommand(_command);
            _lightController.ExecuteCommand();
        }

        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            _command = new IncreaseCommand(_lamp);
            _lightController.SetCommand(_command);
            _lightController.ExecuteCommand();
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            _command = new DecreaseCommand(_lamp);
            _lightController.SetCommand(_command);
            _lightController.ExecuteCommand();
        }
    }
}
