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

namespace HelloWPF {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("Name: {0} \n", FullName.Text));
            sb.Append(string.Format("Sex: {0} \n", ((bool) Male.IsChecked ? "Male" : "Female")));

            sb.Append("Computer Type: ");
            sb.Append(((bool) Desktop.IsChecked ? "Desktop " : ""));
            sb.Append(((bool) Laptop.IsChecked ? "Laptop " : ""));
            sb.Append(((bool) Tablet.IsChecked ? "Tablet " : ""));

            sb.Append(string.Format("\nJob profile: {0} \n", Job.SelectionBoxItem));
            sb.Append(string.Format("Proposed Date: {0} \n", ProposedDate.SelectedDate.ToString()));

            MessageBox.Show(sb.ToString());

        }
    }
}
