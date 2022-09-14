using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartphoneShop.Server.Migrations
{
    public partial class Productseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Izdržljiv i zapanjujući dizajn, s nehrđajućim čelikom kirurške kvalitete, keramičkim štitom i vodećom vodootpornošću IP68.", "https://technostore.hr/upload/products/iphone_13_pro_max_graphite_pdp_image_position_1a_wwen_4_21.jpg", "Iphone 13 Pro Max", 0m },
                    { 2, "Izdržljiv i zapanjujući dizajn, s nehrđajućim čelikom kirurške kvalitete, keramičkim štitom i vodećom vodootpornošću IP68.", "http://bbelektronika.hr/wp-content/uploads/2021/10/apple-iphone-13.jpg", "Iphone 13 Pro", 0m },
                    { 3, "Naš najnapredniji sustav s dvojnom kamerom. Čip brži od konkurencije. Do 2,5 sati dulje trajanje baterije.", "https://s3.eu-central-1.amazonaws.com/amadeus2.hr/img/7964-13_pro.png", "Iphone 13", 0m },
                    { 4, "Učinite svaki dan spektakularnim. Predstavljamo Galaxy S22 5G i S22 Plus 5G s Nightography kamerom, pohranom za Vaše snimke i s baterijom koja traje duže.", "https://smartlab.hr/cms/wp-content/uploads/2022/04/samsung_galaxy_s22_8gb_128gb_negro_001_l.jpg", "Samsung Galaxy S22", 0m },
                    { 5, "Stavljajući velike zaslone i bateriju u kompaktno kućište, Huawei P50 Pro je lakši od prethodne generacije i bolje leži u ruci.", "https://bazzar.hr/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBMjNiNUE9PSIsImV4cCI6bnVsbCwicHVyIjoiYmxvYl9pZCJ9fQ==--130f390e170100dd7f0cc1c9022050a6bc3b98bb/mobitel-huawei-p50-pro-66-8gb-256gb-crni-65715_3.jpg", "Huawei P50 Pro", 0m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
