using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoppingApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class IniitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "455f6a3f-8d37-4d89-8cf2-ab87aa4d6bc7", "17369fee-9973-4a33-870b-3823c0cf38a8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0cc4d1e9-04a5-4e73-bbac-332362861946", "1f08a980-516e-459a-a809-772b826b47a7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0cc4d1e9-04a5-4e73-bbac-332362861946");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "455f6a3f-8d37-4d89-8cf2-ab87aa4d6bc7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17369fee-9973-4a33-870b-3823c0cf38a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f08a980-516e-459a-a809-772b826b47a7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "647ca195-1dc0-4e0c-a62e-405dbb3307fd", null, "Admin rolü", "Admin", "ADMIN" },
                    { "fce50ab4-543c-451a-8ad3-423371745554", null, "User rolü", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "45087a5b-1db3-4519-94ff-2a56bfa4749f", 0, "Çek cd. Senet sk. Fatura ap.", "İstanbul", "bfcdc02e-52c9-4a60-929a-82477742bdc5", new DateTime(1998, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Deniz", "Kadın", "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEDzTHmGTA1kOEx7NIsPwO5/IW8w8Uk7RORLTnhLwhCeZnXzr5R0kdALyW2Rtt1Qmew==", "5555555555", false, "bbe293b0-9cda-49b1-b745-9b5c3bb86495", false, "admin" },
                    { "83670e96-1459-462a-901f-7c66b13f5f35", 0, "Akasya cd. Orkide sk. Gül ap.", "İzmir", "efd599ce-5cbf-42ba-b6d1-460ba6773cd1", new DateTime(1985, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "Kemal", "Erkek", "User", false, null, "USER@GMAIL.COM", "USER", "AQAAAAIAAYagAAAAEI20rhFALjyxWoloEomiohCmh1+U0pohwyekbM3ldzqASKMVyGBfulPVABU+QF/dgQ==", "4444444444", false, "357a7cb2-34b1-4761-95ad-24744c89b848", false, "user" }
                });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "45087a5b-1db3-4519-94ff-2a56bfa4749f");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "83670e96-1459-462a-901f-7c66b13f5f35");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "647ca195-1dc0-4e0c-a62e-405dbb3307fd", "45087a5b-1db3-4519-94ff-2a56bfa4749f" },
                    { "fce50ab4-543c-451a-8ad3-423371745554", "83670e96-1459-462a-901f-7c66b13f5f35" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "647ca195-1dc0-4e0c-a62e-405dbb3307fd", "45087a5b-1db3-4519-94ff-2a56bfa4749f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fce50ab4-543c-451a-8ad3-423371745554", "83670e96-1459-462a-901f-7c66b13f5f35" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "647ca195-1dc0-4e0c-a62e-405dbb3307fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fce50ab4-543c-451a-8ad3-423371745554");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45087a5b-1db3-4519-94ff-2a56bfa4749f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83670e96-1459-462a-901f-7c66b13f5f35");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0cc4d1e9-04a5-4e73-bbac-332362861946", null, "User rolü", "User", "USER" },
                    { "455f6a3f-8d37-4d89-8cf2-ab87aa4d6bc7", null, "Admin rolü", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "17369fee-9973-4a33-870b-3823c0cf38a8", 0, "Çek cd. Senet sk. Fatura ap.", "İstanbul", "4f1bceb8-440a-4eab-bfd3-a155288ad57b", new DateTime(1998, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Deniz", "Kadın", "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEMlpxkxRSVsVU/IMS69Q9IJ9a/brKqRuOXjvAZZ1RtQxtDaDpvGsYVXhnx9v/9VH3A==", "5555555555", false, "67695b43-440f-45cb-b547-ee08b4dc5c66", false, "admin" },
                    { "1f08a980-516e-459a-a809-772b826b47a7", 0, "Akasya cd. Orkide sk. Gül ap.", "İzmir", "052b2368-5c4a-467f-9dbd-461e0fa5a5db", new DateTime(1985, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "Kemal", "Erkek", "User", false, null, "USER@GMAIL.COM", "USER", "AQAAAAIAAYagAAAAEOixitBTTgAAt3Y4tGqJyCxuw+1jrD12f4x0HTTuVVqva1rGjh623PKn3oXjC08nVQ==", "4444444444", false, "c3829a96-a938-459f-a539-0adfa0f58fac", false, "user" }
                });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "17369fee-9973-4a33-870b-3823c0cf38a8");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "1f08a980-516e-459a-a809-772b826b47a7");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "455f6a3f-8d37-4d89-8cf2-ab87aa4d6bc7", "17369fee-9973-4a33-870b-3823c0cf38a8" },
                    { "0cc4d1e9-04a5-4e73-bbac-332362861946", "1f08a980-516e-459a-a809-772b826b47a7" }
                });
        }
    }
}
