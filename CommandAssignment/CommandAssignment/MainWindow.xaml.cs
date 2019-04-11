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
    /// </summary>S
    public partial class MainWindow : Window
    {
        private IDevice _lamp;
        private ICommand _togglecommand;
        private ICommand _increasecommand;
        private ICommand _decreasecommand;
        private LightController _lightController; 


        public MainWindow()
        {
            InitializeComponent();
            _lamp = new Lamp(lamplight);
            _lightController = new LightController(3);
            _togglecommand = new ToggleCommand(_lamp);
            _decreasecommand = new DecreaseCommand(_lamp);
            _increasecommand = new IncreaseCommand(_lamp);

            _lightController.SetCommand(0, _togglecommand);
            _lightController.SetCommand(1, _increasecommand);
            _lightController.SetCommand(2, _decreasecommand);
        }

        private void OnOffButton_Click(object sender, RoutedEventArgs e)
        {
            _lightController.ExecuteCommand(0);
        }

        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            _lightController.ExecuteCommand(1);
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            _lightController.ExecuteCommand(2);
        }
    }
}
