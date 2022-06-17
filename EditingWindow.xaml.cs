using System.ComponentModel.DataAnnotations.Schema;
using System.Windows;
namespace Programowanie_Obiektowe___Projekt
{
    /// <summary>
    /// Logika interakcji dla klasy EditingWindow.xaml
    /// </summary>
    public partial class EditingWindow : Window
    {
        public EditingWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PROJEKTDataSet db = new PROJEKTDataSet();
            Itemy itemy = new Itemy();
            itemy.Nazwa = itemName.Text;
            
            switch(itemCategory.SelectedValue.ToString())
            {
                
            }

        }
    }
}
