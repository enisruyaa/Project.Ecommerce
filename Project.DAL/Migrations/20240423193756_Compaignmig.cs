using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Compaignmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compaigns",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartMount = table.Column<int>(type: "int", nullable: false),
                    EndMount = table.Column<int>(type: "int", nullable: false),
                    StartYear = table.Column<int>(type: "int", nullable: false),
                    EndYear = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compaigns", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductCompaigns",
                columns: table => new
                {
                    CompaignID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCompaigns", x => new { x.ProductID, x.CompaignID });
                    table.ForeignKey(
                        name: "FK_ProductCompaigns_Compaigns_CompaignID",
                        column: x => x.CompaignID,
                        principalTable: "Compaigns",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCompaigns_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "057293a7-8ade-4e6a-895d-c4915aeff212");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "1a41ec2d-c034-4dbf-9b72-bd4ed8c4251f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ad36776-498c-4f23-8cc8-df9f3ca49c0d", new DateTime(2024, 4, 23, 22, 37, 55, 442, DateTimeKind.Local).AddTicks(5314), "AQAAAAIAAYagAAAAEL5k9vUTWJMu4/WzBPDf3L7sNp3QTl3cjuwJKUIBu4lAy51RyLbdTHkw8Ds35CbQ+Q==", "cbe6b4a0-6787-4546-8d5f-a7be6d20f741" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35541ec9-4d34-483f-8f4b-d5427be3f24c", new DateTime(2024, 4, 23, 22, 37, 55, 499, DateTimeKind.Local).AddTicks(3445), "AQAAAAIAAYagAAAAEFWy0FK6HwChtt+3saGnjeBhht3QOhfPdH2k/yrVYlgiNHqvuZCE25Tk/F1TE9mfhw==", "63a6cfc9-ba45-4ac2-b119-552f78d52a73" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Baby", new DateTime(2024, 4, 23, 22, 37, 55, 442, DateTimeKind.Local).AddTicks(3613), "Dışarı çünkü otobüs autem aliquid labore çobanın alias düşünüyor voluptatem." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2024, 4, 23, 22, 37, 55, 442, DateTimeKind.Local).AddTicks(3882), "Patlıcan enim eve makinesi laboriosam anlamsız velit eius sed veniam." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Baby", new DateTime(2024, 4, 23, 22, 37, 55, 442, DateTimeKind.Local).AddTicks(3960), "Sinema patlıcan layıkıyla sed uzattı açılmadan quia voluptas illo sit." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2024, 4, 23, 22, 37, 55, 442, DateTimeKind.Local).AddTicks(4015), "Ama rem voluptatem nemo nihil eaque oldular deleniti quis qui." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2024, 4, 23, 22, 37, 55, 442, DateTimeKind.Local).AddTicks(4064), "Telefonu reprehenderit domates otobüs mutlu çıktılar corporis ut çarpan değerli." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 4, 23, 22, 37, 55, 442, DateTimeKind.Local).AddTicks(4113), "Ea şafak totam consequuntur blanditiis biber uzattı sed sayfası inventore." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 4, 23, 22, 37, 55, 442, DateTimeKind.Local).AddTicks(4168), "Aut koyun quia dışarı koştum amet inventore non koyun camisi." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 4, 23, 22, 37, 55, 442, DateTimeKind.Local).AddTicks(4220), "Qui incidunt orta ut ut düşünüyor teldeki perferendis ut göze." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Computers", new DateTime(2024, 4, 23, 22, 37, 55, 442, DateTimeKind.Local).AddTicks(4266), "Çünkü voluptatem et yapacakmış türemiş nostrum sinema çünkü düşünüyor sunt." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Sports", new DateTime(2024, 4, 23, 22, 37, 55, 442, DateTimeKind.Local).AddTicks(4311), "Perferendis tv dignissimos masaya exercitationem suscipit ışık totam beğendim corporis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 23, 22, 37, 55, 442, DateTimeKind.Local).AddTicks(4486), "Intelligent Frozen Bacon", 24.90m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 23, 22, 37, 55, 442, DateTimeKind.Local).AddTicks(4691), "Refined Cotton Towels", 239.39m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 23, 22, 37, 55, 442, DateTimeKind.Local).AddTicks(4749), "Tasty Soft Computer", 164.20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 23, 22, 37, 55, 442, DateTimeKind.Local).AddTicks(4799), "Ergonomic Plastic Ball", 367.16m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 23, 22, 37, 55, 442, DateTimeKind.Local).AddTicks(4874), "Practical Concrete Hat", 964.52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 23, 22, 37, 55, 442, DateTimeKind.Local).AddTicks(4926), "Handcrafted Fresh Chair", 799.94m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 23, 22, 37, 55, 442, DateTimeKind.Local).AddTicks(4976), "Practical Cotton Ball", 190.35m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 23, 22, 37, 55, 442, DateTimeKind.Local).AddTicks(5022), "Licensed Granite Hat", 809.83m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 23, 22, 37, 55, 442, DateTimeKind.Local).AddTicks(5070), "Handcrafted Frozen Shirt", 359.50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 23, 22, 37, 55, 442, DateTimeKind.Local).AddTicks(5136), "Intelligent Frozen Computer", 587.36m });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCompaigns_CompaignID",
                table: "ProductCompaigns",
                column: "CompaignID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCompaigns");

            migrationBuilder.DropTable(
                name: "Compaigns");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "fa25c777-1819-43a9-97e4-44c87202cc53");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "2ed8abe4-18c3-4b0e-a59c-714e38a63f22");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba49ba7d-1a36-4e01-b700-3ea6343118f3", new DateTime(2024, 4, 19, 0, 42, 57, 632, DateTimeKind.Local).AddTicks(8262), "AQAAAAIAAYagAAAAEJU/6muONEukdL9k+Zlc4W4AWrwR6fbDHD8DFogB3A089mnJTWniCfYBv1LWyLttHw==", "fb75e40a-c25e-4011-8f58-c8c8bc8f25db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d668bcd-7c47-41df-8b5e-cfa5fea43276", new DateTime(2024, 4, 19, 0, 42, 57, 690, DateTimeKind.Local).AddTicks(4330), "AQAAAAIAAYagAAAAEAv+y4kmVTJFECz+kfLN5B3pWtHmWqcfauT4KCnCasW4BxNLzQEowx+yIKdEBTk8cA==", "bab80bd6-a8c8-4e0d-b293-d2d3e37dd39b" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Sports", new DateTime(2024, 4, 19, 0, 42, 57, 632, DateTimeKind.Local).AddTicks(6142), "Et yazın perferendis batarya patlıcan ipsa adresini enim aperiam koyun." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2024, 4, 19, 0, 42, 57, 632, DateTimeKind.Local).AddTicks(6431), "Gidecekmiş enim sıradanlıktan adresini voluptatem enim qui bilgisayarı praesentium gördüm." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2024, 4, 19, 0, 42, 57, 632, DateTimeKind.Local).AddTicks(6485), "Qui ekşili umut qui voluptate ut ut mutlu et doloremque." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2024, 4, 19, 0, 42, 57, 632, DateTimeKind.Local).AddTicks(6534), "Lakin blanditiis balıkhaneye velit koşuyorlar illo gitti beğendim voluptatem dolorem." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2024, 4, 19, 0, 42, 57, 632, DateTimeKind.Local).AddTicks(6614), "Anlamsız velit sed doloremque iure teldeki quis mi enim sıfat." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 42, 57, 632, DateTimeKind.Local).AddTicks(6669), "Çakıl aut lakin eaque et quaerat deleniti quam sarmal öyle." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 42, 57, 632, DateTimeKind.Local).AddTicks(6718), "Dolayı ratione voluptatum filmini in anlamsız velit eaque mıknatıslı voluptatem." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 42, 57, 632, DateTimeKind.Local).AddTicks(6763), "Otobüs lambadaki illo suscipit sinema tv qui layıkıyla dolor ışık." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2024, 4, 19, 0, 42, 57, 632, DateTimeKind.Local).AddTicks(6850), "Ab velit odio doloremque uzattı sıradanlıktan ipsam velit quis düşünüyor." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2024, 4, 19, 0, 42, 57, 632, DateTimeKind.Local).AddTicks(6899), "Mi inventore sıfat layıkıyla domates ut corporis veritatis mıknatıslı dolorem." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 42, 57, 632, DateTimeKind.Local).AddTicks(6996), "Refined Metal Ball", 349.39m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 42, 57, 632, DateTimeKind.Local).AddTicks(7222), "Sleek Metal Cheese", 748.51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 42, 57, 632, DateTimeKind.Local).AddTicks(7345), "Handmade Soft Hat", 166.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 42, 57, 632, DateTimeKind.Local).AddTicks(7422), "Sleek Frozen Tuna", 940.69m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 42, 57, 632, DateTimeKind.Local).AddTicks(7620), "Generic Frozen Fish", 503.46m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 42, 57, 632, DateTimeKind.Local).AddTicks(7676), "Fantastic Concrete Shoes", 693.65m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 42, 57, 632, DateTimeKind.Local).AddTicks(7758), "Intelligent Frozen Shoes", 410.01m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 42, 57, 632, DateTimeKind.Local).AddTicks(7812), "Refined Metal Fish", 148.72m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 42, 57, 632, DateTimeKind.Local).AddTicks(7862), "Fantastic Metal Towels", 581.06m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 42, 57, 632, DateTimeKind.Local).AddTicks(7912), "Incredible Rubber Sausages", 475.38m });
        }
    }
}
