using System;
using System.Diagnostics;
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
        private EditingWindow wnd;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            PROJEKTDataSet pROJEKTDataSet = (PROJEKTDataSet)this.FindResource("pROJEKTDataSet");
            // Załaduj dane do tabeli Itemy. Możesz modyfikować ten kod w razie potrzeby.
            PROJEKTDataSetTableAdapters.ItemyTableAdapter pROJEKTDataSetItemyTableAdapter = new PROJEKTDataSetTableAdapters.ItemyTableAdapter();
            pROJEKTDataSetItemyTableAdapter.Fill(pROJEKTDataSet.Itemy);
            System.Windows.Data.CollectionViewSource itemyViewSource = (System.Windows.Data.CollectionViewSource)this.FindResource("itemyViewSource");
            itemyViewSource.View.MoveCurrentToFirst();

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

            // Załaduj dane do tabeli Prapor. Możesz modyfikować ten kod w razie potrzeby.
            PROJEKTDataSetTableAdapters.PraporTableAdapter pROJEKTDataSetPraporTableAdapter = new PROJEKTDataSetTableAdapters.PraporTableAdapter();
            pROJEKTDataSetPraporTableAdapter.Fill(pROJEKTDataSet.Prapor);
            System.Windows.Data.CollectionViewSource praporViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("praporViewSource")));
            praporViewSource.View.MoveCurrentToFirst();
        }


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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (wnd != null || wnd.IsVisible) return;
            wnd = new EditingWindow();
            wnd.Show();
        }

        private void praporPrice_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonPrice_Click(object sender, RoutedEventArgs e)
        {
            PROJEKTDataSet pROJEKTDataSet = (PROJEKTDataSet)FindResource("pROJEKTDataSet");
            // Załaduj dane do tabeli Itemy. Możesz modyfikować ten kod w razie potrzeby.
            PROJEKTDataSetTableAdapters.ItemyTableAdapter pROJEKTDataSetItemyTableAdapter = new PROJEKTDataSetTableAdapters.ItemyTableAdapter();
            pROJEKTDataSetItemyTableAdapter.Fill(pROJEKTDataSet.Itemy);
            CollectionViewSource itemyViewSource = (CollectionViewSource)FindResource("itemyViewSource");
            itemyViewSource.View.MoveCurrentToFirst();

            var quaryPrapor =
                from prapor in pROJEKTDataSet.Prapor
                join item in pROJEKTDataSet.Itemy
                on prapor.ItemID equals item.ID
                where item.Nazwa == NazwaItemu.Text
                select prapor.CenaKupna;

                praporPrice.Text =
                    quaryPrapor.FirstOrDefault() == 0
                    ? "Handlarz nie kupuje przedmiotu"
                    : $"{quaryPrapor.FirstOrDefault()} ₽";

            var quaryTherapist =
                from therapist in pROJEKTDataSet.Therapist
                join item in pROJEKTDataSet.Itemy
                on therapist.ItemID equals item.ID
                where item.Nazwa == NazwaItemu.Text
                select therapist.CenaKupna;

            therapistPrice.Text =
                quaryTherapist.FirstOrDefault() == 0
                ? "Handlarz nie kupuje przedmiotu"
                : $"{quaryTherapist.FirstOrDefault()} ₽";

            var quarySkier =
                from skier in pROJEKTDataSet.Skier
                join item in pROJEKTDataSet.Itemy
                on skier.ItemID equals item.ID
                where item.Nazwa == NazwaItemu.Text
                select skier.CenaKupna;

            skierPrice.Text =
                quarySkier.FirstOrDefault() == 0
                ? "Handlarz nie kupuje przedmiotu"
                : $"{quarySkier.FirstOrDefault()} ₽";

            var quaryPeacekeeper =
                from peacekeeper in pROJEKTDataSet.Peacekeeper
                join item in pROJEKTDataSet.Itemy
                on peacekeeper.ItemID equals item.ID
                where item.Nazwa == NazwaItemu.Text
                select peacekeeper.CenaKupna;

            peacekeeperPrice.Text =
                quaryPeacekeeper.FirstOrDefault() == 0
                ? "Handlarz nie kupuje przedmiotu"
                : $"{quaryPeacekeeper.FirstOrDefault()} $";

            var quaryMechanic =
                from mechanic in pROJEKTDataSet.Mechanic
                join item in pROJEKTDataSet.Itemy
                on mechanic.ItemID equals item.ID
                where item.Nazwa == NazwaItemu.Text
                select mechanic.CenaKupna;

            mechanicPrice.Text =
                quaryMechanic.FirstOrDefault() == 0
                ? "Handlarz nie kupuje przedmiotu"
                : $"{quaryMechanic.FirstOrDefault()} ₽";

            var quaryRagman =
                from ragman in pROJEKTDataSet.Ragman
                join item in pROJEKTDataSet.Itemy
                on ragman.ItemID equals item.ID
                where item.Nazwa == NazwaItemu.Text
                select ragman.CenaKupna;

            ragmanPrice.Text =
                quaryRagman.FirstOrDefault() == 0
                ? "Handlarz nie kupuje przedmiotu"
                : $"{quaryRagman.FirstOrDefault()} ₽";

            var quaryJaeger =
                from jaeger in pROJEKTDataSet.Jaeger
                join item in pROJEKTDataSet.Itemy
                on jaeger.ItemID equals item.ID
                where item.Nazwa == NazwaItemu.Text
                select jaeger.CenaKupna;

            jaegerPrice.Text =
                quaryJaeger.FirstOrDefault() == 0
                ? "Handlarz nie kupuje przedmiotu"
                : $"{quaryJaeger.FirstOrDefault()} ₽";
        }
    }
}
