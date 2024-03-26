using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Activation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ActivationCode",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d6099788-469b-4db0-af94-715311ffa62e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActivationCode", "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "490ec08b-1809-486c-87cb-1419b050aa34", new DateTime(2024, 3, 26, 22, 15, 2, 822, DateTimeKind.Local).AddTicks(5419), "AQAAAAIAAYagAAAAELXdtZ8yKlUctemX6bgVDx5tm0fgLCmy5gzJsusvawIsVo96VYgs52vLaneZcgEYjg==", "0801f91e-8f9f-4ce1-8a3e-043243f260ed" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2024, 3, 26, 22, 15, 2, 822, DateTimeKind.Local).AddTicks(3685), "Enim makinesi minima dolores modi voluptatum modi dolayı yazın otobüs." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Jewelery", new DateTime(2024, 3, 26, 22, 15, 2, 822, DateTimeKind.Local).AddTicks(3950), "Praesentium şafak makinesi nesciunt koşuyorlar değirmeni ut ducimus karşıdakine consequuntur." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2024, 3, 26, 22, 15, 2, 822, DateTimeKind.Local).AddTicks(4004), "Fugit patlıcan quasi teldeki neque ötekinden sit yazın patlıcan aliquid." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Garden", new DateTime(2024, 3, 26, 22, 15, 2, 822, DateTimeKind.Local).AddTicks(4074), "Karşıdakine dolore ekşili dignissimos rem quis sed nisi velit layıkıyla." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2024, 3, 26, 22, 15, 2, 822, DateTimeKind.Local).AddTicks(4132), "Accusantium gül sequi aut consequatur qui voluptate eve teldeki qui." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2024, 3, 26, 22, 15, 2, 822, DateTimeKind.Local).AddTicks(4182), "Reprehenderit kutusu magnam gazete sarmal vitae orta biber consequatur quam." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2024, 3, 26, 22, 15, 2, 822, DateTimeKind.Local).AddTicks(4231), "Sequi ki sıla şafak öyle de dolore doloremque et orta." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Baby", new DateTime(2024, 3, 26, 22, 15, 2, 822, DateTimeKind.Local).AddTicks(4278), "Aut aut qui nesciunt architecto göze mutlu hesap dışarı dignissimos." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2024, 3, 26, 22, 15, 2, 822, DateTimeKind.Local).AddTicks(4341), "Mıknatıslı deleniti gitti sit gazete dolayı iure ki bahar çarpan." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2024, 3, 26, 22, 15, 2, 822, DateTimeKind.Local).AddTicks(4388), "Corporis numquam nesciunt türemiş adanaya sıfat dışarı eve qui açılmadan." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 15, 2, 822, DateTimeKind.Local).AddTicks(4472), "Rustic Cotton Ball", 547.54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 15, 2, 822, DateTimeKind.Local).AddTicks(4674), "Generic Metal Gloves", 225.18m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 15, 2, 822, DateTimeKind.Local).AddTicks(4749), "Gorgeous Steel Pants", 513.02m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 15, 2, 822, DateTimeKind.Local).AddTicks(4798), "Generic Granite Bacon", 601.57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 15, 2, 822, DateTimeKind.Local).AddTicks(4846), "Sleek Rubber Bacon", 917.76m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 15, 2, 822, DateTimeKind.Local).AddTicks(4897), "Intelligent Frozen Chicken", 353.08m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 15, 2, 822, DateTimeKind.Local).AddTicks(4990), "Generic Frozen Mouse", 327.79m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 15, 2, 822, DateTimeKind.Local).AddTicks(5039), "Incredible Rubber Chips", 360.68m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 15, 2, 822, DateTimeKind.Local).AddTicks(5090), "Rustic Rubber Chair", 577.95m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 15, 2, 822, DateTimeKind.Local).AddTicks(5140), "Gorgeous Cotton Fish", 925.78m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivationCode",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "9dc02cb0-6da5-491f-ac11-b967be0d7881");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4e8c304-8705-4ca1-a4f7-6038273d933b", new DateTime(2024, 3, 26, 21, 47, 51, 412, DateTimeKind.Local).AddTicks(4204), "AQAAAAIAAYagAAAAEJa2eFrDXH2m86MUSnCYe3EGo2sD95baPekAL9L2cdIkLRCdMYyMaNXhFuOeqvamwg==", "c6ba81fe-c798-4f2f-91c1-b95f7351f788" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2024, 3, 26, 21, 47, 51, 412, DateTimeKind.Local).AddTicks(2462), "Velit gitti açılmadan in et voluptatem aliquam qui magni nostrum." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2024, 3, 26, 21, 47, 51, 412, DateTimeKind.Local).AddTicks(2719), "Ve ducimus sıfat duyulmamış salladı sit sayfası magni ve aliquid." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Electronics", new DateTime(2024, 3, 26, 21, 47, 51, 412, DateTimeKind.Local).AddTicks(2772), "Sarmal suscipit dicta tv dolor velit kapının koştum molestiae alias." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Baby", new DateTime(2024, 3, 26, 21, 47, 51, 412, DateTimeKind.Local).AddTicks(2882), "Voluptatem dolayı lakin türemiş aut aut ut nihil nostrum kutusu." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Jewelery", new DateTime(2024, 3, 26, 21, 47, 51, 412, DateTimeKind.Local).AddTicks(2934), "Kalemi deleniti telefonu fugit voluptatem praesentium öyle ex adipisci aperiam." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2024, 3, 26, 21, 47, 51, 412, DateTimeKind.Local).AddTicks(2981), "Masanın odit de corporis patlıcan tempora sıradanlıktan aut ut sunt." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Jewelery", new DateTime(2024, 3, 26, 21, 47, 51, 412, DateTimeKind.Local).AddTicks(3035), "Değirmeni sit et voluptate mi salladı lakin oldular velit quam." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Industrial", new DateTime(2024, 3, 26, 21, 47, 51, 412, DateTimeKind.Local).AddTicks(3095), "Bahar doloremque ea gazete salladı dignissimos autem layıkıyla dolores sequi." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2024, 3, 26, 21, 47, 51, 412, DateTimeKind.Local).AddTicks(3145), "Sunt alias esse bundan masaya layıkıyla çakıl lakin iure çünkü." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2024, 3, 26, 21, 47, 51, 412, DateTimeKind.Local).AddTicks(3193), "Uzattı sit quia batarya corporis quia perferendis beğendim magnam karşıdakine." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 47, 51, 412, DateTimeKind.Local).AddTicks(3284), "Handcrafted Fresh Table", 316.44m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 47, 51, 412, DateTimeKind.Local).AddTicks(3514), "Incredible Fresh Shoes", 297.72m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 47, 51, 412, DateTimeKind.Local).AddTicks(3574), "Intelligent Cotton Shoes", 692.43m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 47, 51, 412, DateTimeKind.Local).AddTicks(3627), "Intelligent Soft Car", 550.85m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 47, 51, 412, DateTimeKind.Local).AddTicks(3677), "Small Metal Mouse", 880.85m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 47, 51, 412, DateTimeKind.Local).AddTicks(3728), "Refined Frozen Keyboard", 249.51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 47, 51, 412, DateTimeKind.Local).AddTicks(3804), "Tasty Frozen Shoes", 24.01m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 47, 51, 412, DateTimeKind.Local).AddTicks(3854), "Generic Steel Fish", 696.55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 47, 51, 412, DateTimeKind.Local).AddTicks(3904), "Licensed Cotton Shirt", 436.89m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 47, 51, 412, DateTimeKind.Local).AddTicks(3956), "Tasty Granite Pizza", 796.36m });
        }
    }
}
