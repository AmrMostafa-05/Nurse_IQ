using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nurse_IQ.Migrations
{
    /// <inheritdoc />
    public partial class addDataseedAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Educational_institution", "Email", "EmailConfirmed", "Fname", "Lname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "Type_of_Educational_institution", "UserName", "Year_Level", "gender", "interests_Fields", "role" },
                values: new object[,]
                { 
                    { 1, 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b0ec844f-5cea-452c-8cf1-11b42d228ddf", "Nursing Faculty", null, false, "System", "Admin", false, null, null, null, null, null, false, null, false, "college", "admin", null, "male", "[\"Research\",\"Teaching\"]", "Student" },
                    { 2, 0, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "345a93ef-3fc4-44cc-b6a2-bdeab2bac79d", "Cairo University", null, false, "Ahmed", "Ali", false, null, null, null, null, null, false, null, false, "college", "doctor1", null, "male", "[\"Pharmacology\",\"ICU\",\"Pediatrics\"]", "Doctor" }
                });

            migrationBuilder.InsertData(
                table: "announcements",
                columns: new[] { "Id", "AdminImageUrl", "Content", "CreatedByAdminId", "Date", "Title", "category" },
                values: new object[,]
                {
                    { 1, "img/admin.png", "Welcome to NursingIQ!", 1, new DateTime(2025, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Welcome", "General" },
                    { 2, "img/admin.png", "We have launched new nursing courses", 1, new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Courses", "Update" }
                });

            migrationBuilder.InsertData(
                table: "articles",
                columns: new[] { "Id", "Description", "Num_of_views", "Title", "UserId", "autorImage", "category", "imageUrl", "publisheDate", "readTime" },
                values: new object[,]
                {
                    { 1, "Challenges in ICU nursing", 100, "Nursing in ICU", 2, "img/doctor1.png", "Medical", "img/article1.jpg", "2025-09-13", "7 min" },
                    { 2, "Essential knowledge of drug mechanisms", 150, "Pharmacology Basics", 2, "img/doctor2.png", "Pharma", "img/article2.jpg", "2025-11-13", "7 min" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "articles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "articles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
