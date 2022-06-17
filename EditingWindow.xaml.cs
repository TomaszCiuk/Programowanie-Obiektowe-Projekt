using System.Data.Entity;
using System.Data.Linq;
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
            DataContext db = new DataContext();
        
            
            switch(itemCategory.SelectedValue.ToString())
            {
                
            }  
        }
        public class TarkovContext : DbContext
        {
            
            public DbSet<Item> Items { get; set; }
            public DbSet<Prapor> PraporItems { get; set; }
            public DbSet<Therapist> TherapistItems { get; set; }
            public DbSet<Skier> SkierItems { get; set; }
            public DbSet<Peacekeeper> PeacekeeperItems { get; set; }
            public DbSet<Mechanic> MechanicItems { get; set; }
            public DbSet<Ragman> RagmanItems { get; set; }
            public DbSet<Jaeger> JaegerItems { get; set; }

            public string ConnectionString { get; }

            public TarkovContext(string connectionString)
            {
                this.ConnectionString = connectionString;
            }

            protected override void OnConfiguring(DbContextOptionsBuilder options)
            {
                options.UseSqlServer(this.ConnectionString);
            }
        }
        public class Item
        {
            public int ID { get; set; }
            public string Nazwa { get; set; }
            public int KategoriaID { get; set; }

        }
        public class Prapor
        {
            public int itemID { get; set; }
            public int cenaSprzedazy { get; set; }
            public int cenaKupna { get; set; }
            public int level { get; set; }
        }
        public class Therapist
        {
            public int itemID { get; set; }
            public int cenaSprzedazy { get; set; }
            public int cenaKupna { get; set; }
            public int level { get; set; }
        }
        public class Skier
        {
            public int itemID { get; set; }
            public int cenaSprzedazy { get; set; }
            public int cenaKupna { get; set; }
            public int level { get; set; }
        }
        public class Peacekeeper
        {
            public int itemID { get; set; }
            public int cenaSprzedazy { get; set; }
            public int cenaKupna { get; set; }
            public int level { get; set; }
        }
        public class Mechanic
        {
            public int itemID { get; set; }
            public int cenaSprzedazy { get; set; }
            public int cenaKupna { get; set; }
            public int level { get; set; }
        }
        public class Ragman
        {
            public int itemID { get; set; }
            public int cenaSprzedazy { get; set; }
            public int cenaKupna { get; set; }
            public int level { get; set; }
        }
        public class Jaeger
        {
            public int itemID { get; set; }
            public int cenaSprzedazy { get; set; }
            public int cenaKupna { get; set; }
            public int level { get; set; }
        }
    }
}
