using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "a5df7d43-2095-48a3-95c9-e22a0df81dcd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4084759-d0ac-4fae-b822-8c7274f81803", new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(9827), "AQAAAAIAAYagAAAAEP5aSROwdCbQSmEHWu7YkbkOCy2SUEUh3gP9H1PUG+LJUPCwUm0mefWyOVQfsfhzaA==", "7efee34c-d7aa-45c7-a0d9-799ee7ad9c8f" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(8108), "Alias adipisci qui sıfat ea sit consequatur yazın sarmal esse." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(8375), "Düşünüyor quis qui alias consequuntur alias magni balıkhaneye tv ki." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Tools", new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(8451), "Dolores autem sequi de kapının nesciunt şafak amet aut umut." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(8500), "Modi qui gördüm nesciunt explicabo sokaklarda dışarı voluptatum voluptatem sit." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Sports", new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(8548), "Autem de quia et sayfası esse adresini sarmal telefonu modi." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(8594), "Bilgiyasayarı molestiae praesentium veniam qui domates vitae mi değirmeni ve." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(8666), "Mıknatıslı non gazete ama dergi dolayı lambadaki laudantium minima enim." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(8715), "Çarpan ad iusto inventore vitae kalemi amet için consequuntur inventore." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(8761), "Mutlu nostrum ab sed öyle sed şafak iure non eum." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(8805), "Reprehenderit layıkıyla illo sunt suscipit değirmeni enim quia veritatis doloremque." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(8912), "Licensed Wooden Soap", 885.81m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(9113), "Handcrafted Frozen Gloves", 947.03m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(9174), "Refined Rubber Keyboard", 340.84m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(9227), "Ergonomic Granite Bacon", 837.30m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(9300), "Fantastic Rubber Fish", 690.13m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(9355), "Ergonomic Steel Computer", 478.96m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(9405), "Handcrafted Soft Pizza", 147.38m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(9454), "Incredible Metal Mouse", 962.54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(9504), "Unbranded Plastic Chips", 928.76m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 28, 41, 299, DateTimeKind.Local).AddTicks(9579), "Refined Concrete Chair", 242.36m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "fec62caa-59ed-4ea4-a720-2e244f43dde5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea9c24f9-2229-4b5b-bbe0-7e4fa9eb17c4", new DateTime(2024, 3, 22, 23, 26, 4, 85, DateTimeKind.Local).AddTicks(259), "AQAAAAIAAYagAAAAEDnbsSQ2ZDftCdDhgsRJ9xty/un5/J2u4vuvLzoQKiQY//3CX0pRcTPSqCyyZsTPVQ==", "935cfae9-355f-499d-92fd-4ba4fd221d43" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2024, 3, 22, 23, 26, 4, 84, DateTimeKind.Local).AddTicks(8550), "Voluptate adresini orta lakin dolorem qui modi kalemi voluptatem tv." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2024, 3, 22, 23, 26, 4, 84, DateTimeKind.Local).AddTicks(8815), "Architecto modi layıkıyla sokaklarda totam ut bahar sandalye karşıdakine dergi." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2024, 3, 22, 23, 26, 4, 84, DateTimeKind.Local).AddTicks(8874), "Çünkü minima exercitationem ducimus non için sit ducimus koşuyorlar çorba." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Tools", new DateTime(2024, 3, 22, 23, 26, 4, 84, DateTimeKind.Local).AddTicks(8926), "Koyun nihil voluptatem rem accusantium illo sed velit veritatis aperiam." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Garden", new DateTime(2024, 3, 22, 23, 26, 4, 84, DateTimeKind.Local).AddTicks(9008), "Qui aperiam enim koşuyorlar gidecekmiş qui masaya deleniti sequi eius." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2024, 3, 22, 23, 26, 4, 84, DateTimeKind.Local).AddTicks(9059), "Aut ea voluptate değirmeni lakin bilgisayarı adanaya sandalye praesentium dolore." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2024, 3, 22, 23, 26, 4, 84, DateTimeKind.Local).AddTicks(9106), "Exercitationem sed ut blanditiis anlamsız voluptatem teldeki voluptatem eius corporis." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Music", new DateTime(2024, 3, 22, 23, 26, 4, 84, DateTimeKind.Local).AddTicks(9149), "Sıradanlıktan et sandalye quis sokaklarda esse makinesi bahar dolor non." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Tools", new DateTime(2024, 3, 22, 23, 26, 4, 84, DateTimeKind.Local).AddTicks(9217), "Sequi amet voluptatem ut adresini praesentium anlamsız sıradanlıktan voluptas modi." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Music", new DateTime(2024, 3, 22, 23, 26, 4, 84, DateTimeKind.Local).AddTicks(9264), "İusto lambadaki ea yazın qui lambadaki ötekinden dolorem consectetur voluptate." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 22, 23, 26, 4, 84, DateTimeKind.Local).AddTicks(9347), "Ergonomic Metal Shirt", 215.29m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 22, 23, 26, 4, 84, DateTimeKind.Local).AddTicks(9557), "Intelligent Frozen Chair", 578.04m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 22, 23, 26, 4, 84, DateTimeKind.Local).AddTicks(9639), "Gorgeous Soft Computer", 641.88m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 22, 23, 26, 4, 84, DateTimeKind.Local).AddTicks(9692), "Incredible Soft Bike", 53.76m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 22, 23, 26, 4, 84, DateTimeKind.Local).AddTicks(9742), "Rustic Wooden Sausages", 509.51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 22, 23, 26, 4, 84, DateTimeKind.Local).AddTicks(9796), "Intelligent Fresh Fish", 578.53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 22, 23, 26, 4, 84, DateTimeKind.Local).AddTicks(9867), "Incredible Rubber Shirt", 311.66m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 22, 23, 26, 4, 84, DateTimeKind.Local).AddTicks(9917), "Rustic Metal Shirt", 742.47m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 22, 23, 26, 4, 84, DateTimeKind.Local).AddTicks(9967), "Handcrafted Metal Shirt", 487.83m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 22, 23, 26, 4, 85, DateTimeKind.Local).AddTicks(16), "Practical Fresh Bacon", 558.27m });
        }
    }
}
