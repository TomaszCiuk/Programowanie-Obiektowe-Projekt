using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
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
            DataRow itemRow = db.Tables["Itemy"].NewRow();
            itemRow["Nazwa"] = itemName.Text;
            
            switch(itemCategory.SelectedValue.ToString())
            {
                case "BaarterItems":
                    itemRow["KategoriaID"] = 1;
                    break;
                case "Gear":
                    itemRow["KategoriaID"] = 2;
                    break;
                case "WeaponsParts":
                    itemRow["KategoriaID"] = 3;
                    break;
                case "Weapons":
                    itemRow["KategoriaID"] = 4;
                    break;
                case "Ammo":
                    itemRow["KategoriaID"] = 5;
                    break;
                case "Provisions":
                    itemRow["KategoriaID"] = 6;
                    break;
                case "Medication":
                    itemRow["KategoriaID"] = 7;
                    break;
                case "Keys":
                    itemRow["KategoriaID"] = 8;
                    break;
                case "SpecialEquipment":
                    itemRow["KategoriaID"] = 9;
                    break;
                case "Maps":
                    itemRow["KategoriaID"] = 10;
                    break;
                case "Money":
                    itemRow["KategoriaID"] = 11;
                    break;
            }
            db.Tables["Itemy"].Rows.Add(itemRow);

        }
    }
}
