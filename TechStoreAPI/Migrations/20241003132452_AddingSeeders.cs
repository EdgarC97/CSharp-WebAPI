using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechStoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddingSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Dispositivos móviles avanzados con capacidades de computación.", "Smartphones" },
                    { 2, "Computadoras portátiles para trabajo y entretenimiento.", "Laptops" },
                    { 3, "Dispositivos móviles con pantallas táctiles y portabilidad.", "Tablets" },
                    { 4, "Complementos tecnológicos como auriculares, cargadores, y más.", "Accesorios" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Av. Siempre Viva 123, Ciudad", "juan.perez@example.com", "Juan Pérez", "123-456-7890" },
                    { 2, "Calle Falsa 456, Ciudad", "maria.lopez@example.com", "María López", "234-567-8901" },
                    { 3, "Paseo de la Reforma 789, Ciudad", "carlos.garcia@example.com", "Carlos García", "345-678-9012" },
                    { 4, "Calle del Sol 101, Ciudad", "ana.martinez@example.com", "Ana Martínez", "456-789-0123" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ClientId", "CreatedAt", "State" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 3, 13, 24, 51, 981, DateTimeKind.Utc).AddTicks(9616), "Pending" },
                    { 2, 2, new DateTime(2024, 10, 2, 13, 24, 51, 981, DateTimeKind.Utc).AddTicks(9617), "Shipped" },
                    { 3, 3, new DateTime(2024, 10, 1, 13, 24, 51, 981, DateTimeKind.Utc).AddTicks(9624), "Delivered" },
                    { 4, 4, new DateTime(2024, 9, 30, 13, 24, 51, 981, DateTimeKind.Utc).AddTicks(9625), "Pending" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, "Smartphone de Apple con pantalla de 6.1 pulgadas.", "iPhone 13", 799.99m, 50 },
                    { 2, 1, "Smartphone de Samsung con tecnología de cámara avanzada.", "Samsung Galaxy S21", 699.99m, 30 },
                    { 3, 2, "Laptop compacta y poderosa con pantalla InfinityEdge.", "Dell XPS 13", 999.99m, 20 },
                    { 4, 3, "Tablet de Apple con chip M1 y pantalla Liquid Retina.", "iPad Pro", 1099.99m, 25 },
                    { 5, 4, "Ratón ergonómico avanzado para productividad.", "Logitech MX Master 3", 99.99m, 100 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password", "RoleId" },
                values: new object[,]
                {
                    { 1, "admin@example.com", "Admin User", "AdminPass123", 1 },
                    { 2, "user@example.com", "Regular User", "UserPass123", 2 }
                });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "Id", "OrderId", "Price", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 699.99m, 1, 2 },
                    { 2, 1, 299.99m, 3, 1 },
                    { 3, 2, 999.99m, 2, 1 },
                    { 4, 3, 49.99m, 4, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

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
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
