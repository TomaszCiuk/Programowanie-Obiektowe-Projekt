using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

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

            //Ładowanie danych do tabeli itemy

            PROJEKTDataSet pROJEKTDataSet = (PROJEKTDataSet)this.FindResource("pROJEKTDataSet");
            PROJEKTDataSetTableAdapters.ItemyTableAdapter pROJEKTDataSetItemyTableAdapter = new PROJEKTDataSetTableAdapters.ItemyTableAdapter();
            pROJEKTDataSetItemyTableAdapter.Fill(pROJEKTDataSet.Itemy);
            CollectionViewSource itemyViewSource = (CollectionViewSource)this.FindResource("itemyViewSource");
            itemyViewSource.View.MoveCurrentToFirst();

            //Zapytania linq podzielone na kategorie przedmiotów

            var queryBarterItemsDataGrid =
            from item in pROJEKTDataSet.Itemy
            where item.KategoriaID == 1
            orderby item.Nazwa
            select new { item.Nazwa };

            var queryGearDataGrid =
            from item in pROJEKTDataSet.Itemy
            where item.KategoriaID == 2
            orderby item.Nazwa
            select new { item.Nazwa };

            var queryWeaponsPartsDataGrid =
            from item in pROJEKTDataSet.Itemy
            where item.KategoriaID == 3
            orderby item.Nazwa
            select new { item.Nazwa };

            var queryWeaponsDataGrid =
            from item in pROJEKTDataSet.Itemy
            where item.KategoriaID == 4
            orderby item.Nazwa
            select new { item.Nazwa };

            var queryAmmoDataGrid =
            from item in pROJEKTDataSet.Itemy
            where item.KategoriaID == 5
            orderby item.Nazwa
            select new { item.Nazwa };

            var queryProvisionsDataGrid =
            from item in pROJEKTDataSet.Itemy
            where item.KategoriaID == 6
            orderby item.Nazwa
            select new { item.Nazwa };

            var queryMedicationDataGrid =
            from item in pROJEKTDataSet.Itemy
            where item.KategoriaID == 7
            orderby item.Nazwa
            select new { item.Nazwa };

            var queryKeysDataGrid =
            from item in pROJEKTDataSet.Itemy
            where item.KategoriaID == 8
            orderby item.Nazwa
            select new { item.Nazwa };

            var querySpecialEquipmentDataGrid =
            from item in pROJEKTDataSet.Itemy
            where item.KategoriaID == 9
            orderby item.Nazwa
            select new { item.Nazwa };

            var queryMapsDataGrid =
            from item in pROJEKTDataSet.Itemy
            where item.KategoriaID == 10
            orderby item.Nazwa
            select new { item.Nazwa };

            var queryMoneyDataGrid =
            from item in pROJEKTDataSet.Itemy
            where item.KategoriaID == 11
            orderby item.Nazwa
            select new { item.Nazwa };

            //Wyświetlanie wynikó zapytań w tabelach

            barterItemsDataGrid.ItemsSource = queryBarterItemsDataGrid.ToList();
            gearDataGrid.ItemsSource = queryGearDataGrid.ToList();
            weaponsPartsDataGrid.ItemsSource = queryWeaponsPartsDataGrid.ToList();
            weaponsDataGrid.ItemsSource = queryWeaponsDataGrid.ToList();
            ammoDataGrid.ItemsSource = queryAmmoDataGrid.ToList();
            provisionsDataGrid.ItemsSource = queryProvisionsDataGrid.ToList();
            medicationsDataGrid.ItemsSource = queryMedicationDataGrid.ToList();
            keysDataGrid.ItemsSource = queryKeysDataGrid.ToList();
            specialEquipmentDataGrid.ItemsSource = querySpecialEquipmentDataGrid.ToList();
            mapsEquipmentDataGrid.ItemsSource = queryMapsDataGrid.ToList();
            moneyEquipmentDataGrid.ItemsSource = queryMoneyDataGrid.ToList();

            // Ładowanie danych do tabeli traderów

            PROJEKTDataSetTableAdapters.PraporTableAdapter pROJEKTDataSetPraporTableAdapter = new PROJEKTDataSetTableAdapters.PraporTableAdapter();
            pROJEKTDataSetPraporTableAdapter.Fill(pROJEKTDataSet.Prapor);
            CollectionViewSource praporViewSource = (CollectionViewSource)this.FindResource("praporViewSource");
            praporViewSource.View.MoveCurrentToFirst();

            PROJEKTDataSetTableAdapters.TherapistTableAdapter pROJEKTDataSetTherapistTableAdapter = new PROJEKTDataSetTableAdapters.TherapistTableAdapter();
            pROJEKTDataSetTherapistTableAdapter.Fill(pROJEKTDataSet.Therapist);
            CollectionViewSource therapistViewSource = (CollectionViewSource)this.FindResource("praporViewSource");
            therapistViewSource.View.MoveCurrentToFirst();

            PROJEKTDataSetTableAdapters.SkierTableAdapter pROJEKTDataSetSkierTableAdapter = new PROJEKTDataSetTableAdapters.SkierTableAdapter();
            pROJEKTDataSetSkierTableAdapter.Fill(pROJEKTDataSet.Skier);
            CollectionViewSource skierViewSource = (CollectionViewSource)this.FindResource("praporViewSource");
            skierViewSource.View.MoveCurrentToFirst();

            PROJEKTDataSetTableAdapters.PeacekeeperTableAdapter pROJEKTDataPeacekeeperTableAdapter = new PROJEKTDataSetTableAdapters.PeacekeeperTableAdapter();
            pROJEKTDataPeacekeeperTableAdapter.Fill(pROJEKTDataSet.Peacekeeper);
            CollectionViewSource peacekeeperViewSource = (CollectionViewSource)this.FindResource("praporViewSource");
            peacekeeperViewSource.View.MoveCurrentToFirst();

            PROJEKTDataSetTableAdapters.MechanicTableAdapter pROJEKTDataMechanicTableAdapter = new PROJEKTDataSetTableAdapters.MechanicTableAdapter();
            pROJEKTDataMechanicTableAdapter.Fill(pROJEKTDataSet.Mechanic);
            CollectionViewSource mechanicViewSource = (CollectionViewSource)this.FindResource("praporViewSource");
            mechanicViewSource.View.MoveCurrentToFirst();

            PROJEKTDataSetTableAdapters.RagmanTableAdapter pROJEKTDataRagmanTableAdapter = new PROJEKTDataSetTableAdapters.RagmanTableAdapter();
            pROJEKTDataRagmanTableAdapter.Fill(pROJEKTDataSet.Ragman);
            CollectionViewSource ragmanViewSource = (CollectionViewSource)this.FindResource("praporViewSource");
            ragmanViewSource.View.MoveCurrentToFirst();

            PROJEKTDataSetTableAdapters.JaegerTableAdapter pROJEKTDataJaegerTableAdapter = new PROJEKTDataSetTableAdapters.JaegerTableAdapter();
            pROJEKTDataJaegerTableAdapter.Fill(pROJEKTDataSet.Jaeger);
            CollectionViewSource jaegerViewSource = (CollectionViewSource)this.FindResource("praporViewSource");
            jaegerViewSource.View.MoveCurrentToFirst();
        }

        //Przypisanie nazwy wybranego przedmiotu do formularza sprawdzającego ceny, w zależności od kategorii

        private void Button_AssingBarterItemsClick(object sender, RoutedEventArgs e)
        {
            DataGrid dataGrid = barterItemsDataGrid;
            DataGridRow Row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex);
            DataGridCell RowAndColumn = (DataGridCell)dataGrid.Columns[0].GetCellContent(Row).Parent;
            string CellValue = ((TextBlock)RowAndColumn.Content).Text;

            NazwaItemu.Text = CellValue;
        }
        private void Button_AssingGearClick(object sender, RoutedEventArgs e)
        {
            DataGrid dataGrid = gearDataGrid;
            DataGridRow Row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex);
            DataGridCell RowAndColumn = (DataGridCell)dataGrid.Columns[0].GetCellContent(Row).Parent;
            string CellValue = ((TextBlock)RowAndColumn.Content).Text;

            NazwaItemu.Text = CellValue;
        }
        private void Button_AssingWeaponsPartsClick(object sender, RoutedEventArgs e)
        {
            DataGrid dataGrid = weaponsPartsDataGrid;
            DataGridRow Row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex);
            DataGridCell RowAndColumn = (DataGridCell)dataGrid.Columns[0].GetCellContent(Row).Parent;
            string CellValue = ((TextBlock)RowAndColumn.Content).Text;

            NazwaItemu.Text = CellValue;
        }
        private void Button_AssingWeaponsClick(object sender, RoutedEventArgs e)
        {
            DataGrid dataGrid = weaponsDataGrid;
            DataGridRow Row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex);
            DataGridCell RowAndColumn = (DataGridCell)dataGrid.Columns[0].GetCellContent(Row).Parent;
            string CellValue = ((TextBlock)RowAndColumn.Content).Text;

            NazwaItemu.Text = CellValue;
        }

        private void Button_AssingAmmoClick(object sender, RoutedEventArgs e)
        {
            DataGrid dataGrid = ammoDataGrid;
            DataGridRow Row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex);
            DataGridCell RowAndColumn = (DataGridCell)dataGrid.Columns[0].GetCellContent(Row).Parent;
            string CellValue = ((TextBlock)RowAndColumn.Content).Text;

            NazwaItemu.Text = CellValue;
        }

        private void Button_AssingProvisionsClick(object sender, RoutedEventArgs e)
        {
            DataGrid dataGrid = provisionsDataGrid;
            DataGridRow Row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex);
            DataGridCell RowAndColumn = (DataGridCell)dataGrid.Columns[0].GetCellContent(Row).Parent;
            string CellValue = ((TextBlock)RowAndColumn.Content).Text;

            NazwaItemu.Text = CellValue;
        }

        private void Button_AssingMedicationClick(object sender, RoutedEventArgs e)
        {
            DataGrid dataGrid = medicationsDataGrid;
            DataGridRow Row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex);
            DataGridCell RowAndColumn = (DataGridCell)dataGrid.Columns[0].GetCellContent(Row).Parent;
            string CellValue = ((TextBlock)RowAndColumn.Content).Text;

            NazwaItemu.Text = CellValue;
        }

        private void Button_AssingKeysClick(object sender, RoutedEventArgs e)
        {
            DataGrid dataGrid = keysDataGrid;
            DataGridRow Row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex);
            DataGridCell RowAndColumn = (DataGridCell)dataGrid.Columns[0].GetCellContent(Row).Parent;
            string CellValue = ((TextBlock)RowAndColumn.Content).Text;

            NazwaItemu.Text = CellValue;
        }

        private void Button_AssingSpecialEquipmentClick(object sender, RoutedEventArgs e)
        {
            DataGrid dataGrid = specialEquipmentDataGrid;
            DataGridRow Row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex);
            DataGridCell RowAndColumn = (DataGridCell)dataGrid.Columns[0].GetCellContent(Row).Parent;
            string CellValue = ((TextBlock)RowAndColumn.Content).Text;

            NazwaItemu.Text = CellValue;
        }

        private void Button_AssingMapsClick(object sender, RoutedEventArgs e)
        {
            DataGrid dataGrid = mapsEquipmentDataGrid;
            DataGridRow Row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex);
            DataGridCell RowAndColumn = (DataGridCell)dataGrid.Columns[0].GetCellContent(Row).Parent;
            string CellValue = ((TextBlock)RowAndColumn.Content).Text;

            NazwaItemu.Text = CellValue;
        }

        private void Button_AssingMoneyClick(object sender, RoutedEventArgs e)
        {
            DataGrid dataGrid = moneyEquipmentDataGrid;
            DataGridRow Row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex);
            DataGridCell RowAndColumn = (DataGridCell)dataGrid.Columns[0].GetCellContent(Row).Parent;
            string CellValue = ((TextBlock)RowAndColumn.Content).Text;

            NazwaItemu.Text = CellValue;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //Tworzenie nowego okna dodawania

        EditingWindow wnd;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (wnd == null || !wnd.IsVisible)
            {
                wnd = new EditingWindow();
                wnd.Show();
            }
        }

        //Wyświetlanie ceny sprzedaży przedmiotu przez każdego z traderów

        private void ButtonPrice_Click(object sender, RoutedEventArgs e)
        {
            PROJEKTDataSet pROJEKTDataSet = (PROJEKTDataSet)FindResource("pROJEKTDataSet");
            PROJEKTDataSetTableAdapters.ItemyTableAdapter pROJEKTDataSetItemyTableAdapter = new PROJEKTDataSetTableAdapters.ItemyTableAdapter();
            pROJEKTDataSetItemyTableAdapter.Fill(pROJEKTDataSet.Itemy);
            CollectionViewSource itemyViewSource = (CollectionViewSource)FindResource("itemyViewSource");
            itemyViewSource.View.MoveCurrentToFirst();

          
            var quaryPrapor =
                from trader in pROJEKTDataSet.Prapor
                join item in pROJEKTDataSet.Itemy
                on trader.ItemID equals item.ID
                where item.Nazwa == NazwaItemu.Text
                select trader.CenaKupna;

            praporPrice.Text =
                quaryPrapor.FirstOrDefault() == 0
                ? "Handlarz nie sprzedaje przedmiotu"
                : $"{quaryPrapor.FirstOrDefault()} ₽";

            var quaryTherapist =
                from trader in pROJEKTDataSet.Therapist
                join item in pROJEKTDataSet.Itemy
                on trader.ItemID equals item.ID
                where item.Nazwa == NazwaItemu.Text
                select trader.CenaKupna;

            therapistPrice.Text =
                quaryTherapist.FirstOrDefault() == 0
                ? "Handlarz nie sprzedaje przedmiotu"
                : $"{quaryTherapist.FirstOrDefault()} ₽";

            var quarySkier =
                from skier in pROJEKTDataSet.Skier
                join item in pROJEKTDataSet.Itemy
                on skier.ItemID equals item.ID
                where item.Nazwa == NazwaItemu.Text
                select skier.CenaKupna;

            skierPrice.Text =
                quarySkier.FirstOrDefault() == 0
                ? "Handlarz nie sprzedaje przedmiotu"
                : $"{quarySkier.FirstOrDefault()} ₽";

            var quaryPeacekeeper =
                from peacekeeper in pROJEKTDataSet.Peacekeeper
                join item in pROJEKTDataSet.Itemy
                on peacekeeper.ItemID equals item.ID
                where item.Nazwa == NazwaItemu.Text
                select peacekeeper.CenaKupna;

            peacekeeperPrice.Text =
                quaryPeacekeeper.FirstOrDefault() == 0
                ? "Handlarz nie sprzedaje przedmiotu"
                : $"{quaryPeacekeeper.FirstOrDefault()} $" + '\n' +
                $" {quaryPeacekeeper.FirstOrDefault() * 112}  ₽";

            var quaryMechanic =
                from mechanic in pROJEKTDataSet.Mechanic
                join item in pROJEKTDataSet.Itemy
                on mechanic.ItemID equals item.ID
                where item.Nazwa == NazwaItemu.Text
                select mechanic.CenaKupna;

            mechanicPrice.Text =
                quaryMechanic.FirstOrDefault() == 0
                ? "Handlarz nie sprzedaje przedmiotu"
                : $"{quaryMechanic.FirstOrDefault()} ₽";

            var quaryRagman =
                from ragman in pROJEKTDataSet.Ragman
                join item in pROJEKTDataSet.Itemy
                on ragman.ItemID equals item.ID
                where item.Nazwa == NazwaItemu.Text
                select ragman.CenaKupna;

            ragmanPrice.Text =
                quaryRagman.FirstOrDefault() == 0
                ? "Handlarz nie sprzedaje przedmiotu"
                : $"{quaryRagman.FirstOrDefault()} ₽";

            var quaryJaeger =
                from jaeger in pROJEKTDataSet.Jaeger
                join item in pROJEKTDataSet.Itemy
                on jaeger.ItemID equals item.ID
                where item.Nazwa == NazwaItemu.Text
                select jaeger.CenaKupna;

            jaegerPrice.Text =
                quaryJaeger.FirstOrDefault() == 0
                ? "Handlarz nie sprzedaje przedmiotu"
                : $"{quaryJaeger.FirstOrDefault()} ₽";
        }

        // Wyświetlanie cen kupna podeanego  przedmiotu u wszystkich handlarzy

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PROJEKTDataSet pROJEKTDataSet = (PROJEKTDataSet)FindResource("pROJEKTDataSet");
            PROJEKTDataSetTableAdapters.ItemyTableAdapter pROJEKTDataSetItemyTableAdapter = new PROJEKTDataSetTableAdapters.ItemyTableAdapter();
            pROJEKTDataSetItemyTableAdapter.Fill(pROJEKTDataSet.Itemy);
            CollectionViewSource itemyViewSource = (CollectionViewSource)FindResource("itemyViewSource");
            itemyViewSource.View.MoveCurrentToFirst();

            var quaryPrapor =
                from trader in pROJEKTDataSet.Prapor
                join item in pROJEKTDataSet.Itemy
                on trader.ItemID equals item.ID
                where item.Nazwa == NazwaItemu.Text
                select trader.CenaSprzedaży;

            praporPrice.Text =
                quaryPrapor.FirstOrDefault() == 0
                ? "Handlarz nie kupuje przedmiotu"
                : $"{quaryPrapor.FirstOrDefault()} ₽";

           

            var quaryTherapist =
                from trader in pROJEKTDataSet.Therapist
                join item in pROJEKTDataSet.Itemy
                on trader.ItemID equals item.ID
                where item.Nazwa == NazwaItemu.Text
                select trader.CenaSprzedaży;

            therapistPrice.Text =
                quaryTherapist.FirstOrDefault() == 0
                ? "Handlarz nie kupuje przedmiotu"
                : $"{quaryTherapist.FirstOrDefault()} ₽";

          

            var quarySkier =
                from skier in pROJEKTDataSet.Skier
                join item in pROJEKTDataSet.Itemy
                on skier.ItemID equals item.ID
                where item.Nazwa == NazwaItemu.Text
                select skier.CenaSprzedaży;

            skierPrice.Text =
                quarySkier.FirstOrDefault() == 0
                ? "Handlarz nie kupuje przedmiotu"
                : $"{quarySkier.FirstOrDefault()} ₽";

           

            var quaryPeacekeeper =
                from peacekeeper in pROJEKTDataSet.Peacekeeper
                join item in pROJEKTDataSet.Itemy
                on peacekeeper.ItemID equals item.ID
                where item.Nazwa == NazwaItemu.Text
                select peacekeeper.CenaSprzedaży;

            peacekeeperPrice.Text =
                quaryPeacekeeper.FirstOrDefault() == 0
                ? "Handlarz nie kupuje przedmiotu"
                : $"{quaryPeacekeeper.FirstOrDefault()} $" + '\n' +
                $" {quaryPeacekeeper.FirstOrDefault() * 112}  ₽";



            var quaryMechanic =
                from mechanic in pROJEKTDataSet.Mechanic
                join item in pROJEKTDataSet.Itemy
                on mechanic.ItemID equals item.ID
                where item.Nazwa == NazwaItemu.Text
                select mechanic.CenaSprzedaży;

            mechanicPrice.Text =
                quaryMechanic.FirstOrDefault() == 0
                ? "Handlarz nie kupuje przedmiotu"
                : $"{quaryMechanic.FirstOrDefault()} ₽";



            var quaryRagman =
                from ragman in pROJEKTDataSet.Ragman
                join item in pROJEKTDataSet.Itemy
                on ragman.ItemID equals item.ID
                where item.Nazwa == NazwaItemu.Text
                select ragman.CenaSprzedaży;

            ragmanPrice.Text =
                quaryRagman.FirstOrDefault() == 0
                ? "Handlarz nie kupuje przedmiotu"
                : $"{quaryRagman.FirstOrDefault()} ₽";



            var quaryJaeger =
                from jaeger in pROJEKTDataSet.Jaeger
                join item in pROJEKTDataSet.Itemy
                on jaeger.ItemID equals item.ID
                where item.Nazwa == NazwaItemu.Text
                select jaeger.CenaSprzedaży;

            jaegerPrice.Text =
                quaryJaeger.FirstOrDefault() == 0
                ? "Handlarz nie kupuje przedmiotu"
                : $"{quaryJaeger.FirstOrDefault()} ₽";
        }



    }
}
