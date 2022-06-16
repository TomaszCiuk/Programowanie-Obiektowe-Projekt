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

namespace Programowanie_Obiektowe___Projekt
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Programowanie_Obiektowe___Projekt.PROJEKTDataSet pROJEKTDataSet = ((Programowanie_Obiektowe___Projekt.PROJEKTDataSet)(this.FindResource("pROJEKTDataSet")));
            // Załaduj dane do tabeli Itemy. Możesz modyfikować ten kod w razie potrzeby.
            Programowanie_Obiektowe___Projekt.PROJEKTDataSetTableAdapters.ItemyTableAdapter pROJEKTDataSetItemyTableAdapter = new Programowanie_Obiektowe___Projekt.PROJEKTDataSetTableAdapters.ItemyTableAdapter();
            pROJEKTDataSetItemyTableAdapter.Fill(pROJEKTDataSet.Itemy);
            System.Windows.Data.CollectionViewSource itemyViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("itemyViewSource")));
            itemyViewSource.View.MoveCurrentToFirst();
        }
    }
}
