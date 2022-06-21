using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

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
        private void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Ładowanie danych z tabeli itemy (nie działa)
            PROJEKTDataSet pROJEKTDataSet = (PROJEKTDataSet)this.FindResource("pROJEKTDataSet");
            PROJEKTDataSetTableAdapters.ItemyTableAdapter pROJEKTDataSetItemyTableAdapter = new PROJEKTDataSetTableAdapters.ItemyTableAdapter();
            PROJEKTDataSet.ItemyDataTable itemy = new PROJEKTDataSet.ItemyDataTable();
            PROJEKTDataSet.ItemyRow itemRow = itemy.NewItemyRow();
            itemRow["Nazwa"] = itemName.Text;

            //Lista kategorii do listy rozwijaniej

            switch (itemCategory.SelectedValue.ToString())
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

            // Dodawanie nowego wiersza do tabeli itemy i odświeżenie tej tabeli

            itemy.Rows.Add(itemRow);
            CollectionViewSource itemyViewSource = (CollectionViewSource)this.FindResource("itemyViewSource");
            itemyViewSource.View.MoveCurrentToFirst();


        }

        //Wyświetlanie zdjęcia wybranego handlarza

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            BitmapImage traderImageSource = new BitmapImage();
            traderImageSource.BeginInit();
            switch (trader.SelectedValue.ToString())
            {
                case "Prapor":
                    traderImageSource.UriSource = new Uri("Images/Prapor.jpg", UriKind.Relative);
                    traderImageSource.EndInit();
                    traderImage.Stretch = Stretch.Fill;
                    traderImage.Source = traderImageSource;
                    break;
                case "Therapist":
                    traderImageSource.UriSource = new Uri("Images/Therapist.jpg", UriKind.Relative);
                    traderImageSource.EndInit();
                    traderImage.Stretch = Stretch.Fill;
                    traderImage.Source = traderImageSource;
                    break;
                case "Skier":
                    traderImageSource.UriSource = new Uri("Images/Skier.jpg", UriKind.Relative);
                    traderImageSource.EndInit();
                    traderImage.Stretch = Stretch.Fill;
                    traderImage.Source = traderImageSource;
                    break;
                case "Peacekepeer":
                    traderImageSource.UriSource = new Uri("Images/Peacekeeper.jpg", UriKind.Relative);
                    traderImageSource.EndInit();
                    traderImage.Stretch = Stretch.Fill;
                    traderImage.Source = traderImageSource;
                    break;
                case "Mechanic":
                    traderImageSource.UriSource = new Uri("Images/Mechanic.jpg", UriKind.Relative);
                    traderImageSource.EndInit();
                    traderImage.Stretch = Stretch.Fill;
                    traderImage.Source = traderImageSource;
                    break;
                case "Ragman":
                    traderImageSource.UriSource = new Uri("Images/Ragman.jpg", UriKind.Relative);
                    traderImageSource.EndInit();
                    traderImage.Stretch = Stretch.Fill;
                    traderImage.Source = traderImageSource;
                    break;
                case "Jaeger":
                    traderImageSource.UriSource = new Uri("Images/Jaeger.jpg", UriKind.Relative);
                    traderImageSource.EndInit();
                    traderImage.Stretch = Stretch.Fill;
                    traderImage.Source = traderImageSource;
                    break;
            }
        }

        //Przypisywanie przedmiotu do handlarza

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PROJEKTDataSet pROJEKTDataSet = (PROJEKTDataSet)this.FindResource("pROJEKTDataSet");
            var quaryIDItem =
                from item in pROJEKTDataSet.Itemy
                where item.Nazwa == itemAddingName.Text
                select item.ID;
            switch (trader.SelectedValue.ToString())
            {
                //Ustalanie cen kupna i sprzedaży w tabeli wybranego handlarza. Dodanie ich do tabeli i zaktualizowanie jej
                case "Prapor":
                    PROJEKTDataSet.PraporDataTable prapor = new PROJEKTDataSet.PraporDataTable();
                    PROJEKTDataSet.PraporRow praporItemRow = prapor.NewPraporRow();
                    praporItemRow["ItemID"] = quaryIDItem.FirstOrDefault();
                    praporItemRow["CenaSprzedaży"] = itemSell.Text;
                    praporItemRow["CenaKupna"] = itemBuy.Text;
                    praporItemRow["Level"] = 0;
                    prapor.Rows.Add(praporItemRow);
                    PROJEKTDataSetTableAdapters.PraporTableAdapter pROJEKTDataSetPraporTableAdapter = new PROJEKTDataSetTableAdapters.PraporTableAdapter();
                    pROJEKTDataSetPraporTableAdapter.Fill(pROJEKTDataSet.Prapor);
                    CollectionViewSource PraporViewSource = (CollectionViewSource)this.FindResource("therapistViewSource");
                    PraporViewSource.View.MoveCurrentToFirst();
                    break;
                case "Therapist":
                    PROJEKTDataSet.PraporDataTable therapist = new PROJEKTDataSet.PraporDataTable();
                    PROJEKTDataSet.PraporRow therapistItemRow = therapist.NewPraporRow();
                    therapistItemRow["ItemID"] = quaryIDItem.FirstOrDefault();
                    therapistItemRow["CenaSprzedaży"] = itemSell.Text;
                    therapistItemRow["CenaKupna"] = itemBuy.Text;
                    therapistItemRow["Level"] = 0;
                    therapist.Rows.Add(therapistItemRow);
                    PROJEKTDataSetTableAdapters.PraporTableAdapter pROJEKTDataSetTherapistTableAdapter = new PROJEKTDataSetTableAdapters.PraporTableAdapter();
                    pROJEKTDataSetTherapistTableAdapter.Fill(pROJEKTDataSet.Prapor);
                    CollectionViewSource therapistViewSource = (CollectionViewSource)this.FindResource("therapistViewSource");
                    therapistViewSource.View.MoveCurrentToFirst();
                    break;
                case "skier":
                    PROJEKTDataSet.PraporDataTable skier = new PROJEKTDataSet.PraporDataTable();
                    PROJEKTDataSet.PraporRow skierItemRow = skier.NewPraporRow();
                    skierItemRow["ItemID"] = quaryIDItem.FirstOrDefault();
                    skierItemRow["CenaSprzedaży"] = itemSell.Text;
                    skierItemRow["CenaKupna"] = itemBuy.Text;
                    skierItemRow["Level"] = 0;
                    skier.Rows.Add(skierItemRow);
                    PROJEKTDataSetTableAdapters.PraporTableAdapter pROJEKTDataSetSkierTableAdapter = new PROJEKTDataSetTableAdapters.PraporTableAdapter();
                    pROJEKTDataSetSkierTableAdapter.Fill(pROJEKTDataSet.Prapor);
                    CollectionViewSource skierViewSource = (CollectionViewSource)this.FindResource("skierViewSource");
                    skierViewSource.View.MoveCurrentToFirst();
                    break;
                case "Peacekepeer":
                    PROJEKTDataSet.PraporDataTable peacekepeer = new PROJEKTDataSet.PraporDataTable();
                    PROJEKTDataSet.PraporRow peacekepeerItemRow = peacekepeer.NewPraporRow();
                    peacekepeerItemRow["ItemID"] = quaryIDItem.FirstOrDefault();
                    peacekepeerItemRow["CenaSprzedaży"] = itemSell.Text;
                    peacekepeerItemRow["CenaKupna"] = itemBuy.Text;
                    peacekepeerItemRow["Level"] = 0;
                    peacekepeer.Rows.Add(peacekepeerItemRow);
                    PROJEKTDataSetTableAdapters.PraporTableAdapter pROJEKTDataSetPeacekepeerTableAdapter = new PROJEKTDataSetTableAdapters.PraporTableAdapter();
                    pROJEKTDataSetPeacekepeerTableAdapter.Fill(pROJEKTDataSet.Prapor);
                    CollectionViewSource peacekepeerViewSource = (CollectionViewSource)this.FindResource("peacekepeerViewSource");
                    peacekepeerViewSource.View.MoveCurrentToFirst();
                    break;
                case "Mechanic":
                    PROJEKTDataSet.PraporDataTable mechanic = new PROJEKTDataSet.PraporDataTable();
                    PROJEKTDataSet.PraporRow mechanicItemRow = mechanic.NewPraporRow();
                    mechanicItemRow["ItemID"] = quaryIDItem.FirstOrDefault();
                    mechanicItemRow["CenaSprzedaży"] = itemSell.Text;
                    mechanicItemRow["CenaKupna"] = itemBuy.Text;
                    mechanicItemRow["Level"] = 0;
                    mechanic.Rows.Add(mechanicItemRow);
                    PROJEKTDataSetTableAdapters.PraporTableAdapter pROJEKTDataSetMechanicTableAdapter = new PROJEKTDataSetTableAdapters.PraporTableAdapter();
                    pROJEKTDataSetMechanicTableAdapter.Fill(pROJEKTDataSet.Prapor);
                    CollectionViewSource mechanicViewSource = (CollectionViewSource)this.FindResource("mechanicViewSource");
                    mechanicViewSource.View.MoveCurrentToFirst();
                    break;
                case "Ragman":
                    PROJEKTDataSet.PraporDataTable ragman = new PROJEKTDataSet.PraporDataTable();
                    PROJEKTDataSet.PraporRow ragmanItemRow = ragman.NewPraporRow();
                    ragmanItemRow["ItemID"] = quaryIDItem.FirstOrDefault();
                    ragmanItemRow["CenaSprzedaży"] = itemSell.Text;
                    ragmanItemRow["CenaKupna"] = itemBuy.Text;
                    ragmanItemRow["Level"] = 0;
                    ragman.Rows.Add(ragmanItemRow);
                    PROJEKTDataSetTableAdapters.PraporTableAdapter pROJEKTDataSetRagmanTableAdapter = new PROJEKTDataSetTableAdapters.PraporTableAdapter();
                    pROJEKTDataSetRagmanTableAdapter.Fill(pROJEKTDataSet.Prapor);
                    CollectionViewSource ragmanViewSource = (CollectionViewSource)this.FindResource("ragmanViewSource");
                    ragmanViewSource.View.MoveCurrentToFirst();
                    break;
                case "Jaeger":
                    PROJEKTDataSet.PraporDataTable jeager = new PROJEKTDataSet.PraporDataTable();
                    PROJEKTDataSet.PraporRow jeagerItemRow = jeager.NewPraporRow();
                    jeagerItemRow["ItemID"] = quaryIDItem.FirstOrDefault();
                    jeagerItemRow["CenaSprzedaży"] = itemSell.Text;
                    jeagerItemRow["CenaKupna"] = itemBuy.Text;
                    jeagerItemRow["Level"] = 0;
                    jeager.Rows.Add(jeagerItemRow);
                    PROJEKTDataSetTableAdapters.PraporTableAdapter pROJEKTDataSetJeagerTableAdapter = new PROJEKTDataSetTableAdapters.PraporTableAdapter();
                    pROJEKTDataSetJeagerTableAdapter.Fill(pROJEKTDataSet.Prapor);
                    CollectionViewSource jeagerViewSource = (CollectionViewSource)this.FindResource("jeagerViewSource");
                    jeagerViewSource.View.MoveCurrentToFirst();
                    break;
            }
        }
    }
}
