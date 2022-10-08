// Group 4 Author: Marta Group Members: Aman, Himanshu, Srivani, Meet, Robin
using System.Windows;

namespace PresentValue
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        VM vm = new VM();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
            vm.UpdatePresentValue();
        }

    }

}
