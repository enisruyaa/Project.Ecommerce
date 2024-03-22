using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ShipperMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShipperID",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Shippers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippers", x => x.ID);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShipperID",
                table: "Orders",
                column: "ShipperID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Shippers_ShipperID",
                table: "Orders",
                column: "ShipperID",
                principalTable: "Shippers",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Shippers_ShipperID",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Shippers");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ShipperID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShipperID",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "75b5d149-cea4-4c7d-a341-6729bde8cf74");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40672ab2-4bc2-449c-8a09-3cca96745e74", new DateTime(2024, 3, 20, 1, 0, 15, 294, DateTimeKind.Local).AddTicks(7234), "AQAAAAIAAYagAAAAEADXb/BAaLauiKm9EE1aDgYTCSm7cqW6V5lsiwg5A4HcHX9l3EZ5j3Wn51RvzBEGNw==", "0c07017b-1fb2-4bd8-be3e-c4fcae45aa3a" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Music", new DateTime(2024, 3, 20, 1, 0, 15, 294, DateTimeKind.Local).AddTicks(5550), "Teldeki koyun aut göze laudantium mutlu nihil ut değerli bilgiyasayarı." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Electronics", new DateTime(2024, 3, 20, 1, 0, 15, 294, DateTimeKind.Local).AddTicks(5807), "Ama praesentium çıktılar nihil perferendis neque kulu ki gördüm totam." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2024, 3, 20, 1, 0, 15, 294, DateTimeKind.Local).AddTicks(5863), "Camisi karşıdakine praesentium ad voluptatem perferendis veritatis lakin masanın ve." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2024, 3, 20, 1, 0, 15, 294, DateTimeKind.Local).AddTicks(5940), "Ullam ea nisi çorba vel ışık eum voluptatem odit voluptatem." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2024, 3, 20, 1, 0, 15, 294, DateTimeKind.Local).AddTicks(5988), "Aliquam aut nisi perferendis quae lakin quia et yapacakmış için." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Baby", new DateTime(2024, 3, 20, 1, 0, 15, 294, DateTimeKind.Local).AddTicks(6036), "Öyle sarmal çıktılar perferendis ekşili nisi mutlu qui ışık blanditiis." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Garden", new DateTime(2024, 3, 20, 1, 0, 15, 294, DateTimeKind.Local).AddTicks(6081), "Architecto açılmadan voluptatem tv dolorem dolor sandalye sıla doğru voluptatem." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Baby", new DateTime(2024, 3, 20, 1, 0, 15, 294, DateTimeKind.Local).AddTicks(6129), "Perferendis okuma cesurca ötekinden praesentium dağılımı vel labore architecto praesentium." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2024, 3, 20, 1, 0, 15, 294, DateTimeKind.Local).AddTicks(6191), "Sinema ut nemo reprehenderit alias laboriosam voluptas quasi mi blanditiis." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2024, 3, 20, 1, 0, 15, 294, DateTimeKind.Local).AddTicks(6243), "Laudantium esse architecto ut voluptatem bundan ekşili dolorem laudantium dolores." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 20, 1, 0, 15, 294, DateTimeKind.Local).AddTicks(6330), "Handmade Cotton Salad", 742.87m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 20, 1, 0, 15, 294, DateTimeKind.Local).AddTicks(6541), "Awesome Rubber Table", 716.81m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 20, 1, 0, 15, 294, DateTimeKind.Local).AddTicks(6601), "Fantastic Rubber Pants", 755.18m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 20, 1, 0, 15, 294, DateTimeKind.Local).AddTicks(6651), "Fantastic Soft Chicken", 985.17m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 20, 1, 0, 15, 294, DateTimeKind.Local).AddTicks(6700), "Licensed Metal Cheese", 537.38m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 20, 1, 0, 15, 294, DateTimeKind.Local).AddTicks(6752), "Incredible Wooden Shirt", 303.21m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 20, 1, 0, 15, 294, DateTimeKind.Local).AddTicks(6840), "Generic Fresh Computer", 735.69m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 20, 1, 0, 15, 294, DateTimeKind.Local).AddTicks(6891), "Fantastic Concrete Shirt", 372.26m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 20, 1, 0, 15, 294, DateTimeKind.Local).AddTicks(6940), "Gorgeous Fresh Keyboard", 708.76m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 20, 1, 0, 15, 294, DateTimeKind.Local).AddTicks(6992), "Sleek Concrete Salad", 651.41m });
        }
    }
}
