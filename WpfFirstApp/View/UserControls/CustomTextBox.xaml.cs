using System.Windows;
using System.Windows.Controls;


namespace WpfFirstApp.View.UserControls
{

    public partial class CustomTextBox : UserControl
    {
        public CustomTextBox()
        {
            InitializeComponent();
        }



        private string placeholder;

        public string Placeholder
        {
            get { return placeholder; }
            set {
                
                placeholder = value;
               
            }
        }




        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txInput.Clear();
            txInput.Focus();

        }

        private void txInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(txInput.Text))
            {
                tbPlaceHolder.Visibility = Visibility.Visible;
            }
            else
            {
                tbPlaceHolder.Visibility = Visibility.Collapsed;
            }

        }
    }
}
