﻿using System;
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
    }
}
