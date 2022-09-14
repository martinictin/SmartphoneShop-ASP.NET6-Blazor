namespace SmartphoneShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                   new Product
                   {
                       Id = 1,
                       Name = "Iphone 13 Pro Max",
                       Description = "Izdržljiv i zapanjujući dizajn, s nehrđajućim čelikom kirurške kvalitete, keramičkim štitom i vodećom vodootpornošću IP68.",
                       ImageUrl = "https://technostore.hr/upload/products/iphone_13_pro_max_graphite_pdp_image_position_1a_wwen_4_21.jpg",
                       
                   },
                   new Product
                   {
                       Id = 2,
                       Name = "Iphone 13 Pro",
                       Description= "Izdržljiv i zapanjujući dizajn, s nehrđajućim čelikom kirurške kvalitete, keramičkim štitom i vodećom vodootpornošću IP68.",
                       ImageUrl = "http://bbelektronika.hr/wp-content/uploads/2021/10/apple-iphone-13.jpg"
                   },
                   new Product
                   {
                       Id = 3,
                       Name = "Iphone 13",
                       Description= "Naš najnapredniji sustav s dvojnom kamerom. Čip brži od konkurencije. Do 2,5 sati dulje trajanje baterije.",
                       ImageUrl = "https://s3.eu-central-1.amazonaws.com/amadeus2.hr/img/7964-13_pro.png",
            
                   },
                   new Product
                   {
                       Id = 4,
                       Name = "Samsung Galaxy S22",
                       Description = "Učinite svaki dan spektakularnim. Predstavljamo Galaxy S22 5G i S22 Plus 5G s Nightography kamerom, pohranom za Vaše snimke i s baterijom koja traje duže.",
                       ImageUrl = "https://smartlab.hr/cms/wp-content/uploads/2022/04/samsung_galaxy_s22_8gb_128gb_negro_001_l.jpg",
                   },
                   new Product
                   {
                       Id = 5,
                       Name = "Huawei P50 Pro",
                       Description = "Stavljajući velike zaslone i bateriju u kompaktno kućište, Huawei P50 Pro je lakši od prethodne generacije i bolje leži u ruci.",
                       ImageUrl = "https://bazzar.hr/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBMjNiNUE9PSIsImV4cCI6bnVsbCwicHVyIjoiYmxvYl9pZCJ9fQ==--130f390e170100dd7f0cc1c9022050a6bc3b98bb/mobitel-huawei-p50-pro-66-8gb-256gb-crni-65715_3.jpg",
                    
                   }
                   );
        }
        public DbSet<Product> Products { get; set; }
    }
}
