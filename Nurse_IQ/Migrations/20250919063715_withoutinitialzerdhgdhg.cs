using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nurse_IQ.Migrations
{
    /// <inheritdoc />
    public partial class withoutinitialzerdhgdhg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Lname = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false, computedColumnSql: "[Fname] + ' ' + [Lname]"),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year_Level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Educational_institution = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    Type_of_Educational_institution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    interests_Fields = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "announcements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    Content = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminImageUrl = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    CreatedByAdminId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_announcements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_announcements_AspNetUsers_CreatedByAdminId",
                        column: x => x.CreatedByAdminId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imageUrl = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    category = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    authorImage = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    publishDate = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    readTime = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    Num_of_views = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_articles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "contactForms",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    phone = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    InquiryType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedByAdminId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contactForms", x => x.ID);
                    table.ForeignKey(
                        name: "FK_contactForms_AspNetUsers_CreatedByAdminId",
                        column: x => x.CreatedByAdminId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    YearLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    courseType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    semister = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    imageUrl = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    smallDescription = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    bigDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    courseTopics = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    coursePrerequisites = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "diplomas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    requirement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    register_steps = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedByAdminId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diplomas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_diplomas_AspNetUsers_CreatedByAdminId",
                        column: x => x.CreatedByAdminId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "forumtopics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    category = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    num_comments = table.Column<int>(type: "int", nullable: false),
                    num_of_likes = table.Column<int>(type: "int", nullable: false),
                    num_of_views = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_forumtopics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_forumtopics_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medicalTerms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    arabicName = table.Column<string>(type: "VARCHAR(55)", maxLength: 55, nullable: false),
                    englishName = table.Column<string>(type: "VARCHAR(55)", maxLength: 55, nullable: false),
                    latinName = table.Column<string>(type: "VARCHAR(55)", maxLength: 55, nullable: false),
                    definition = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    example = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    synonyms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicalTerms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_medicalTerms_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medicines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    arabicName = table.Column<string>(type: "VARCHAR(55)", maxLength: 55, nullable: false),
                    englishName = table.Column<string>(type: "VARCHAR(55)", maxLength: 55, nullable: false),
                    latinName = table.Column<string>(type: "VARCHAR(55)", maxLength: 55, nullable: false),
                    category = table.Column<string>(type: "VARCHAR(55)", maxLength: 55, nullable: false),
                    form = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: false),
                    indications = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: false),
                    sideEffects = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: false),
                    dosage = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    applicationUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_medicines_AspNetUsers_applicationUserId",
                        column: x => x.applicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    SubTitle = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    category = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountPercentage = table.Column<int>(type: "int", nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[OriginalPrice] * [discountPercentage] / 100", stored: true),
                    LastPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[OriginalPrice] - ([OriginalPrice] * [discountPercentage] / 100)", stored: true),
                    imageUrl = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: false),
                    expiredAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    features = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedByAdminId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offers_AspNetUsers_CreatedByAdminId",
                        column: x => x.CreatedByAdminId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "training_Videos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    category = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    publishedDate = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    duration = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    thumbnailUrl = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    instructorName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    instructorImage = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    videoUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    numberOfViews = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CreatedByAdminId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_training_Videos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_training_Videos_AspNetUsers_CreatedByAdminId",
                        column: x => x.CreatedByAdminId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "trainings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    HospitalName = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Category = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Experience = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    requirement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    postedDate = table.Column<DateTime>(type: "date", nullable: false),
                    deadline = table.Column<DateTime>(type: "date", nullable: false),
                    CreatedByAdminId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trainings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_trainings_AspNetUsers_CreatedByAdminId",
                        column: x => x.CreatedByAdminId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "lectures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    smallDescription = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    bigDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duration = table.Column<string>(type: "VARCHAR(55)", maxLength: 55, nullable: false),
                    videoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lectures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_lectures_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_lectures_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "diplomaFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    DiplomaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diplomaFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_diplomaFeatures_diplomas_DiplomaId",
                        column: x => x.DiplomaId,
                        principalTable: "diplomas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRegisteredTrainings",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TrainingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRegisteredTrainings", x => new { x.UserId, x.TrainingId });
                    table.ForeignKey(
                        name: "FK_UserRegisteredTrainings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRegisteredTrainings_trainings_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "trainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "lectureMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    FileUrl = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    LectureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lectureMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_lectureMaterials_lectures_LectureId",
                        column: x => x.LectureId,
                        principalTable: "lectures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "quizzes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    LectureId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quizzes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_quizzes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_quizzes_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_quizzes_lectures_LectureId",
                        column: x => x.LectureId,
                        principalTable: "lectures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hardnessType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: false),
                    CorrectAnswer = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: false),
                    Student_Answer = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    options = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuizId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_questions_quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Educational_institution", "Email", "EmailConfirmed", "Fname", "Lname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "Type_of_Educational_institution", "UserName", "Year_Level", "gender", "interests_Fields", "role" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e35ff8ee-6040-4cca-8352-ffbdfb2a90eb", "Nursing Faculty", "admin@nurseiq.com", false, "System", "Admin", false, null, "ADMIN@NURSEIQ.COM", "ADMIN", "AQAAAAEAACcQAAAAEHQ36c3VJt2fP+m3v/6rF3hHENu2eYi5...", null, false, "fadde23e-011f-4496-af6f-cadc726a79d9", false, "college", "admin", null, "male", "[\"Research\",\"Teaching\",\"Management\"]", "Doctor" },
                    { 2, 0, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "64177201-9bfa-4b58-8c57-203c1a5a7322", "جامعة القاهرة", "doctor1@nurseiq.com", false, "أحمد", "علي", false, null, "DOCTOR1@NURSEIQ.COM", "DOCTOR1", "AQAAAAEAACcQAAAAEHQ36c3VJt2fP+m3v/6rF3hHENu2eYi5...", null, false, "04e31ae6-c28b-4a93-8a8d-ee786d43d832", false, "college", "doctor1", null, "male", "[\"Pharmacology\",\"ICU\",\"Pediatrics\"]", "Doctor" },
                    { 3, 0, new DateTime(1988, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "d0b8e5ee-a8da-4007-b45d-a05fbaab756e", "جامعة عين شمس", "doctor2@nurseiq.com", false, "فاطمة", "محمد", false, null, "DOCTOR2@NURSEIQ.COM", "DOCTOR2", "AQAAAAEAACcQAAAAEHQ36c3VJt2fP+m3v/6rF3hHENu2eYi5...", null, false, "b6d768b4-b040-4c2a-8ecb-b02c8e81a321", false, "college", "doctor2", null, "female", "[\"Surgery\",\"Emergency\",\"Cardiology\"]", "Doctor" },
                    { 4, 0, new DateTime(1982, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0aa10ea0-e9df-4d21-b48f-95b5a1d1e628", "جامعة الإسكندرية", "doctor3@nurseiq.com", false, "محمد", "حسن", false, null, "DOCTOR3@NURSEIQ.COM", "DOCTOR3", "AQAAAAEAACcQAAAAEHQ36c3VJt2fP+m3v/6rF3hHENu2eYi5...", null, false, "2f7bb075-9db2-42a8-9d78-6b4f7b2fba88", false, "college", "doctor3", null, "male", "[\"Neurology\",\"Psychiatry\",\"Research\"]", "Doctor" },
                    { 5, 0, new DateTime(2003, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "f3490106-8b4b-4cc6-b97e-3b933347cf23", "معهد التمريض العالي", "student1@nurseiq.com", false, "سارة", "أحمد", false, null, "STUDENT1@NURSEIQ.COM", "STUDENT1", "AQAAAAEAACcQAAAAEHQ36c3VJt2fP+m3v/6rF3hHENu2eYi5...", null, false, "cc64b1b5-1c11-42c4-857a-e3d291788013", false, "institute", "student1", "First_Year", "female", "[\"Pediatrics\",\"Emergency\",\"Community Health\"]", "Student" },
                    { 6, 0, new DateTime(2002, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "19188dbd-d090-444f-b384-6514e1665728", "كلية التمريض - جامعة القاهرة", "student2@nurseiq.com", false, "علي", "محمود", false, null, "STUDENT2@NURSEIQ.COM", "STUDENT2", "AQAAAAEAACcQAAAAEHQ36c3VJt2fP+m3v/6rF3hHENu2eYi5...", null, false, "85661625-4b32-4f9c-be8d-d622feb86576", false, "college", "student2", "Sec_Year", "male", "[\"ICU\",\"Surgery\",\"Pharmacology\"]", "Student" },
                    { 7, 0, new DateTime(2001, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "0012bcc6-6b9a-43cb-a9d4-fa61e41cbc29", "كلية التمريض - جامعة عين شمس", "student3@nurseiq.com", false, "مريم", "عبدالله", false, null, "STUDENT3@NURSEIQ.COM", "STUDENT3", "AQAAAAEAACcQAAAAEHQ36c3VJt2fP+m3v/6rF3hHENu2eYi5...", null, false, "22732da7-9d2c-4f64-b8b9-b56b08174745", false, "college", "student3", "Third_Year", "female", "[\"Mental Health\",\"Community Health\",\"Research\"]", "Student" },
                    { 8, 0, new DateTime(2000, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "8b09686e-8df3-4930-ba60-dab5398f8c3c", "كلية التمريض - جامعة الإسكندرية", "student4@nurseiq.com", false, "يوسف", "إبراهيم", false, null, "STUDENT4@NURSEIQ.COM", "STUDENT4", "AQAAAAEAACcQAAAAEHQ36c3VJt2fP+m3v/6rF3hHENu2eYi5...", null, false, "ab82a807-c357-419f-b9d2-168084625bff", false, "college", "student4", "Fourth_Year", "male", "[\"Emergency\",\"Trauma\",\"Critical Care\"]", "Student" },
                    { 9, 0, new DateTime(1999, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "8a0db598-276d-44f6-a6bf-9f5d62d292bf", "كلية التمريض - جامعة القاهرة", "excellence1@nurseiq.com", false, "نور", "السيد", false, null, "EXCELLENCE1@NURSEIQ.COM", "EXCELLENCE1", "AQAAAAEAACcQAAAAEHQ36c3VJt2fP+m3v/6rF3hHENu2eYi5...", null, false, "e8c19911-3c90-404f-b9d4-d89d0d203aa0", false, "college", "excellence1", "Excellence_Year", "female", "[\"Research\",\"Leadership\",\"Advanced Practice\"]", "Excellence_student" },
                    { 10, 0, new DateTime(1998, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "cfec7e7c-3140-4ebc-9d90-3c2f0e3c7774", "كلية التمريض - جامعة عين شمس", "graduate1@nurseiq.com", false, "خالد", "محمد", false, null, "GRADUATE1@NURSEIQ.COM", "GRADUATE1", "AQAAAAEAACcQAAAAEHQ36c3VJt2fP+m3v/6rF3hHENu2eYi5...", null, false, "5f58a864-fd3c-4c78-896b-25ddc20a6a09", false, "college", "graduate1", "Graduated", "male", "[\"Professional Development\",\"Specialization\",\"Teaching\"]", "graduate" }
                });

            migrationBuilder.InsertData(
                table: "medicines",
                columns: new[] { "Id", "UserId", "applicationUserId", "arabicName", "category", "description", "dosage", "englishName", "form", "indications", "latinName", "sideEffects" },
                values: new object[,]
                {
                    { 1, 2, null, "باراسيتامول", "مسكنات الألم", "مسكن للألم وخافض للحرارة", "500-1000 مجم كل 6-8 ساعات", "Paracetamol", "أقراص", "الحمى، الصداع، آلام الجسم", "Acetaminophen", "غثيان، طفح جلدي، تلف الكبد (بجرعات عالية)" },
                    { 2, 2, null, "إيبوبروفين", "مسكنات الألم", "مسكن للألم ومضاد للالتهاب", "200-400 مجم كل 6-8 ساعات", "Ibuprofen", "أقراص", "آلام المفاصل، الصداع، الحمى", "Ibuprofenum", "اضطراب المعدة، نزيف معوي، مشاكل في الكلى" },
                    { 3, 2, null, "أموكسيسيلين", "مضادات حيوية", "مضاد حيوي واسع الطيف", "250-500 مجم كل 8 ساعات", "Amoxicillin", "كبسولات", "التهابات الجهاز التنفسي، التهابات المسالك البولية", "Amoxicillinum", "إسهال، طفح جلدي، حساسية" },
                    { 4, 3, null, "أزيثروميسين", "مضادات حيوية", "مضاد حيوي من مجموعة الماكروليد", "500 مجم مرة واحدة يومياً لمدة 3 أيام", "Azithromycin", "أقراص", "التهابات الجهاز التنفسي، التهابات الجلد", "Azithromycinum", "غثيان، إسهال، اضطراب في المعدة" },
                    { 5, 3, null, "أتينولول", "أدوية القلب", "حاصرات بيتا لعلاج ارتفاع ضغط الدم", "25-100 مجم مرة واحدة يومياً", "Atenolol", "أقراص", "ارتفاع ضغط الدم، عدم انتظام ضربات القلب", "Atenololum", "بطء القلب، انخفاض ضغط الدم، تعب" },
                    { 6, 4, null, "أملوديبين", "أدوية القلب", "حاصرات قنوات الكالسيوم", "5-10 مجم مرة واحدة يومياً", "Amlodipine", "أقراص", "ارتفاع ضغط الدم، الذبحة الصدرية", "Amlodipinum", "تورم الكاحلين، صداع، دوخة" },
                    { 7, 2, null, "أوميبرازول", "أدوية الجهاز الهضمي", "مثبط مضخة البروتون", "20-40 مجم مرة واحدة يومياً", "Omeprazole", "كبسولات", "قرحة المعدة، ارتجاع المريء", "Omeprazolum", "صداع، غثيان، إسهال" },
                    { 8, 3, null, "دومبيريدون", "أدوية الجهاز الهضمي", "مضاد للغثيان والقيء", "10 مجم 3 مرات يومياً", "Domperidone", "أقراص", "الغثيان، القيء، عسر الهضم", "Domperidonum", "جفاف الفم، صداع، اضطراب في المعدة" },
                    { 9, 4, null, "سالبوتامول", "أدوية الجهاز التنفسي", "موسع للشعب الهوائية", "1-2 بخة حسب الحاجة", "Salbutamol", "بخاخ", "الربو، التهاب الشعب الهوائية", "Salbutamolum", "رعشة، تسارع ضربات القلب، صداع" },
                    { 10, 2, null, "بريدنيزولون", "أدوية الجهاز التنفسي", "كورتيكوستيرويد مضاد للالتهاب", "5-60 مجم يومياً حسب الحالة", "Prednisolone", "أقراص", "الربو الحاد، التهاب المفاصل", "Prednisolonum", "زيادة الوزن، ارتفاع ضغط الدم، هشاشة العظام" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Duration", "Name", "Title", "UserId", "YearLevel", "bigDescription", "coursePrerequisites", "courseTopics", "courseType", "imageUrl", "semister", "smallDescription" },
                values: new object[,]
                {
                    { 1, "3 أشهر", "أساسيات التمريض", "مبادئ الرعاية التمريضية", 2, "First_Year", "دورة شاملة تغطي المبادئ الأساسية للتمريض والممارسة المهنية", "[\"\\u0634\\u0647\\u0627\\u062F\\u0629 \\u0627\\u0644\\u062B\\u0627\\u0646\\u0648\\u064A\\u0629 \\u0627\\u0644\\u0639\\u0627\\u0645\\u0629\"]", "[\"\\u0623\\u062E\\u0644\\u0627\\u0642\\u064A\\u0627\\u062A \\u0627\\u0644\\u062A\\u0645\\u0631\\u064A\\u0636\",\"\\u0633\\u0644\\u0627\\u0645\\u0629 \\u0627\\u0644\\u0645\\u0631\\u064A\\u0636\",\"\\u0627\\u0644\\u062A\\u0648\\u0627\\u0635\\u0644 \\u0645\\u0639 \\u0627\\u0644\\u0645\\u0631\\u064A\\u0636\",\"\\u0627\\u0644\\u0631\\u0639\\u0627\\u064A\\u0629 \\u0627\\u0644\\u0623\\u0633\\u0627\\u0633\\u064A\\u0629\"]", "theoretical_Course", "img/course1.jpg", "FirstSemester", "مقدمة في أساسيات التمريض" },
                    { 2, "4 أشهر", "علم التشريح والفيزيولوجيا", "دراسة جسم الإنسان", 2, "First_Year", "دراسة مفصلة لتشريح ووظائف جميع أجهزة الجسم البشري", "[\"\\u062E\\u0644\\u0641\\u064A\\u0629 \\u0641\\u064A \\u0639\\u0644\\u0645 \\u0627\\u0644\\u0623\\u062D\\u064A\\u0627\\u0621\"]", "[\"\\u0627\\u0644\\u062C\\u0647\\u0627\\u0632 \\u0627\\u0644\\u0647\\u064A\\u0643\\u0644\\u064A\",\"\\u0627\\u0644\\u062C\\u0647\\u0627\\u0632 \\u0627\\u0644\\u0639\\u0636\\u0644\\u064A\",\"\\u0627\\u0644\\u062C\\u0647\\u0627\\u0632 \\u0627\\u0644\\u062F\\u0648\\u0631\\u064A\",\"\\u0627\\u0644\\u062C\\u0647\\u0627\\u0632 \\u0627\\u0644\\u062A\\u0646\\u0641\\u0633\\u064A\"]", "theoretical_Course", "img/course2.jpg", "FirstSemester", "دراسة تشريح ووظائف أعضاء الجسم" },
                    { 3, "3 أشهر", "المهارات التمريضية الأساسية", "التطبيق العملي للتمريض", 3, "First_Year", "تدريب عملي على المهارات التمريضية الأساسية في المختبر والمستشفى", "[\"\\u0623\\u0633\\u0627\\u0633\\u064A\\u0627\\u062A \\u0627\\u0644\\u062A\\u0645\\u0631\\u064A\\u0636\"]", "[\"\\u0642\\u064A\\u0627\\u0633 \\u0627\\u0644\\u0639\\u0644\\u0627\\u0645\\u0627\\u062A \\u0627\\u0644\\u062D\\u064A\\u0648\\u064A\\u0629\",\"\\u062D\\u0642\\u0646 \\u0627\\u0644\\u0623\\u062F\\u0648\\u064A\\u0629\",\"\\u0627\\u0644\\u0639\\u0646\\u0627\\u064A\\u0629 \\u0628\\u0627\\u0644\\u062C\\u0631\\u0648\\u062D\",\"\\u0627\\u0644\\u0631\\u0639\\u0627\\u064A\\u0629 \\u0627\\u0644\\u0634\\u062E\\u0635\\u064A\\u0629\"]", "practical_Course", "img/course3.jpg", "SecondSemester", "تعلم المهارات العملية الأساسية" },
                    { 4, "4 أشهر", "علم الأدوية", "مقدمة في علم الأدوية", 2, "Second_Year", "دراسة شاملة للأدوية وتصنيفاتها وآليات عملها وتأثيراتها الجانبية", "[\"\\u0639\\u0644\\u0645 \\u0627\\u0644\\u062A\\u0634\\u0631\\u064A\\u062D \\u0648\\u0627\\u0644\\u0641\\u064A\\u0632\\u064A\\u0648\\u0644\\u0648\\u062C\\u064A\\u0627\"]", "[\"\\u0627\\u0644\\u0645\\u0636\\u0627\\u062F\\u0627\\u062A \\u0627\\u0644\\u062D\\u064A\\u0648\\u064A\\u0629\",\"\\u0645\\u0633\\u0643\\u0646\\u0627\\u062A \\u0627\\u0644\\u0623\\u0644\\u0645\",\"\\u0623\\u062F\\u0648\\u064A\\u0629 \\u0627\\u0644\\u0642\\u0644\\u0628\",\"\\u0623\\u062F\\u0648\\u064A\\u0629 \\u0627\\u0644\\u062C\\u0647\\u0627\\u0632 \\u0627\\u0644\\u0647\\u0636\\u0645\\u064A\"]", "theoretical_Course", "img/course4.jpg", "FirstSemester", "دراسة الأدوية وتأثيراتها" },
                    { 5, "4 أشهر", "تمريض الباطنة", "رعاية المرضى الداخليين", 3, "Second_Year", "دراسة شاملة لرعاية المرضى في الأقسام الداخلية المختلفة", "[\"\\u0639\\u0644\\u0645 \\u0627\\u0644\\u0623\\u062F\\u0648\\u064A\\u0629\"]", "[\"\\u062A\\u0645\\u0631\\u064A\\u0636 \\u0627\\u0644\\u0642\\u0644\\u0628\",\"\\u062A\\u0645\\u0631\\u064A\\u0636 \\u0627\\u0644\\u062C\\u0647\\u0627\\u0632 \\u0627\\u0644\\u062A\\u0646\\u0641\\u0633\\u064A\",\"\\u062A\\u0645\\u0631\\u064A\\u0636 \\u0627\\u0644\\u062C\\u0647\\u0627\\u0632 \\u0627\\u0644\\u0647\\u0636\\u0645\\u064A\",\"\\u062A\\u0645\\u0631\\u064A\\u0636 \\u0627\\u0644\\u0643\\u0644\\u0649\"]", "theoretical_Course", "img/course5.jpg", "SecondSemester", "رعاية المرضى في الأقسام الداخلية" },
                    { 6, "4 أشهر", "تمريض الأطفال", "رعاية الأطفال والرضع", 2, "Third_Year", "دراسة متخصصة في رعاية الأطفال من الولادة حتى المراهقة", "[\"\\u062A\\u0645\\u0631\\u064A\\u0636 \\u0627\\u0644\\u0628\\u0627\\u0637\\u0646\\u0629\"]", "[\"\\u0631\\u0639\\u0627\\u064A\\u0629 \\u062D\\u062F\\u064A\\u062B\\u064A \\u0627\\u0644\\u0648\\u0644\\u0627\\u062F\\u0629\",\"\\u062A\\u063A\\u0630\\u064A\\u0629 \\u0627\\u0644\\u0623\\u0637\\u0641\\u0627\\u0644\",\"\\u0623\\u0645\\u0631\\u0627\\u0636 \\u0627\\u0644\\u0623\\u0637\\u0641\\u0627\\u0644 \\u0627\\u0644\\u0634\\u0627\\u0626\\u0639\\u0629\",\"\\u0627\\u0644\\u062A\\u0637\\u0639\\u064A\\u0645\\u0627\\u062A\"]", "theoretical_Course", "img/course6.jpg", "FirstSemester", "رعاية خاصة بالأطفال" },
                    { 7, "4 أشهر", "تمريض الجراحة", "رعاية المرضى الجراحيين", 3, "Third_Year", "تدريب عملي على رعاية المرضى قبل وأثناء وبعد العمليات الجراحية", "[\"\\u0627\\u0644\\u0645\\u0647\\u0627\\u0631\\u0627\\u062A \\u0627\\u0644\\u062A\\u0645\\u0631\\u064A\\u0636\\u064A\\u0629 \\u0627\\u0644\\u0623\\u0633\\u0627\\u0633\\u064A\\u0629\"]", "[\"\\u0627\\u0644\\u062A\\u062D\\u0636\\u064A\\u0631 \\u0644\\u0644\\u062C\\u0631\\u0627\\u062D\\u0629\",\"\\u0631\\u0639\\u0627\\u064A\\u0629 \\u0645\\u0627 \\u0628\\u0639\\u062F \\u0627\\u0644\\u062C\\u0631\\u0627\\u062D\\u0629\",\"\\u0627\\u0644\\u0639\\u0646\\u0627\\u064A\\u0629 \\u0628\\u0627\\u0644\\u062C\\u0631\\u0648\\u062D \\u0627\\u0644\\u062C\\u0631\\u0627\\u062D\\u064A\\u0629\",\"\\u0625\\u062F\\u0627\\u0631\\u0629 \\u0627\\u0644\\u0623\\u0644\\u0645\"]", "practical_Course", "img/course7.jpg", "SecondSemester", "رعاية ما قبل وبعد الجراحة" },
                    { 8, "5 أشهر", "تمريض العناية المركزة", "رعاية المرضى الحرجين", 4, "Fourth_Year", "تدريب متقدم على رعاية المرضى الحرجين في وحدات العناية المركزة", "[\"\\u062A\\u0645\\u0631\\u064A\\u0636 \\u0627\\u0644\\u0628\\u0627\\u0637\\u0646\\u0629\",\"\\u062A\\u0645\\u0631\\u064A\\u0636 \\u0627\\u0644\\u062C\\u0631\\u0627\\u062D\\u0629\"]", "[\"\\u0623\\u062C\\u0647\\u0632\\u0629 \\u0627\\u0644\\u062A\\u0646\\u0641\\u0633 \\u0627\\u0644\\u0635\\u0646\\u0627\\u0639\\u064A\",\"\\u0645\\u0631\\u0627\\u0642\\u0628\\u0629 \\u0627\\u0644\\u0639\\u0644\\u0627\\u0645\\u0627\\u062A \\u0627\\u0644\\u062D\\u064A\\u0648\\u064A\\u0629\",\"\\u0625\\u062F\\u0627\\u0631\\u0629 \\u0627\\u0644\\u0623\\u062F\\u0648\\u064A\\u0629 \\u0627\\u0644\\u0648\\u0631\\u064A\\u062F\\u064A\\u0629\",\"\\u0627\\u0644\\u0625\\u0646\\u0639\\u0627\\u0634 \\u0627\\u0644\\u0642\\u0644\\u0628\\u064A \\u0627\\u0644\\u0631\\u0626\\u0648\\u064A\"]", "practical_Course", "img/course8.jpg", "FirstSemester", "رعاية المرضى في العناية المركزة" },
                    { 9, "4 أشهر", "تمريض الطوارئ", "رعاية حالات الطوارئ", 3, "Fourth_Year", "تدريب متخصص على التعامل مع حالات الطوارئ والإسعافات الأولية", "[\"\\u062A\\u0645\\u0631\\u064A\\u0636 \\u0627\\u0644\\u0639\\u0646\\u0627\\u064A\\u0629 \\u0627\\u0644\\u0645\\u0631\\u0643\\u0632\\u0629\"]", "[\"\\u0627\\u0644\\u0625\\u0633\\u0639\\u0627\\u0641\\u0627\\u062A \\u0627\\u0644\\u0623\\u0648\\u0644\\u064A\\u0629\",\"\\u062D\\u0627\\u0644\\u0627\\u062A \\u0627\\u0644\\u0635\\u062F\\u0645\\u0629\",\"\\u0627\\u0644\\u062A\\u0633\\u0645\\u0645\",\"\\u0627\\u0644\\u062D\\u0631\\u0648\\u0642 \\u0648\\u0627\\u0644\\u0643\\u0633\\u0648\\u0631\"]", "practical_Course", "img/course9.jpg", "SecondSemester", "رعاية حالات الطوارئ والإسعافات الأولية" },
                    { 10, "6 أشهر", "التمريض المتقدم", "ممارسة التمريض المتقدمة", 4, "Excellence_Year", "دراسة متقدمة في ممارسة التمريض والقيادة التمريضية", "[\"\\u062C\\u0645\\u064A\\u0639 \\u0627\\u0644\\u0645\\u0648\\u0627\\u062F \\u0627\\u0644\\u0633\\u0627\\u0628\\u0642\\u0629\"]", "[\"\\u0627\\u0644\\u0642\\u064A\\u0627\\u062F\\u0629 \\u0627\\u0644\\u062A\\u0645\\u0631\\u064A\\u0636\\u064A\\u0629\",\"\\u0625\\u062F\\u0627\\u0631\\u0629 \\u0627\\u0644\\u062C\\u0648\\u062F\\u0629\",\"\\u0627\\u0644\\u0628\\u062D\\u062B \\u0627\\u0644\\u062A\\u0645\\u0631\\u064A\\u0636\\u064A\",\"\\u0627\\u0644\\u062A\\u0637\\u0648\\u064A\\u0631 \\u0627\\u0644\\u0645\\u0647\\u0646\\u064A\"]", "theoretical_Course", "img/course10.jpg", "FirstSemester", "ممارسة التمريض على مستوى متقدم" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreatedByAdminId", "Description", "DiscountPercentage", "OriginalPrice", "SubTitle", "Title", "category", "expiredAt", "features", "imageUrl" },
                values: new object[,]
                {
                    { 1, 1, "خصم خاص على دبلوم العناية المركزة مع تدريب عملي متقدم", 20, 1000m, "وفر 20%", "عرض تدريب العناية المركزة", "Training", new DateTime(2025, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"\\u062C\\u0644\\u0633\\u0627\\u062A \\u0639\\u0645\\u0644\\u064A\\u0629\",\"\\u0645\\u062F\\u0631\\u0628\\u0648\\u0646 \\u0645\\u0639\\u062A\\u0645\\u062F\\u0648\\u0646\",\"\\u0634\\u0647\\u0627\\u062F\\u0629 \\u0645\\u0639\\u062A\\u0645\\u062F\\u0629\"]", "img/offer1.png" },
                    { 2, 1, "خصم على دورة علم الأدوية مع مواد إضافية مجانية", 10, 500m, "وفر 10%", "عرض دورة علم الأدوية", "Course", new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"\\u0645\\u0648\\u0627\\u062F \\u0645\\u062C\\u0627\\u0646\\u064A\\u0629\",\"\\u062A\\u0645\\u0627\\u0631\\u064A\\u0646 \\u0625\\u0636\\u0627\\u0641\\u064A\\u0629\",\"\\u062F\\u0639\\u0645 \\u0623\\u0643\\u0627\\u062F\\u064A\\u0645\\u064A\"]", "img/offer2.png" },
                    { 3, 2, "خصم كبير على برنامج تدريب الطوارئ الطبية", 25, 800m, "وفر 25%", "عرض تدريب الطوارئ", "Training", new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"\\u0645\\u062D\\u0627\\u0643\\u0627\\u0629 \\u062D\\u0627\\u0644\\u0627\\u062A \\u0637\\u0648\\u0627\\u0631\\u0626\",\"\\u062A\\u062F\\u0631\\u064A\\u0628 \\u0639\\u0644\\u0649 \\u0627\\u0644\\u0645\\u0639\\u062F\\u0627\\u062A\",\"\\u0634\\u0647\\u0627\\u062F\\u0629 \\u062F\\u0648\\u0644\\u064A\\u0629\"]", "img/offer3.png" },
                    { 4, 1, "خصم خاص على جميع دورات التمريض المتقدم", 30, 1200m, "وفر 30%", "عرض دورات التمريض المتقدم", "Course", new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"\\u062F\\u0648\\u0631\\u0627\\u062A \\u0645\\u062A\\u062E\\u0635\\u0635\\u0629\",\"\\u0645\\u062A\\u0627\\u0628\\u0639\\u0629 \\u0634\\u062E\\u0635\\u064A\\u0629\",\"\\u0634\\u0647\\u0627\\u062F\\u0627\\u062A \\u0645\\u0639\\u062A\\u0645\\u062F\\u0629\"]", "img/offer4.png" },
                    { 5, 1, "ترحيب خاص بالطلاب الجدد - خصم كبير على أول دورة", 40, 600m, "وفر 40%", "عرض الطلاب الجدد", "Course", new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"\\u062E\\u0635\\u0645 \\u0625\\u0636\\u0627\\u0641\\u064A\",\"\\u0645\\u0648\\u0627\\u062F \\u0645\\u062C\\u0627\\u0646\\u064A\\u0629\",\"\\u062F\\u0639\\u0645 \\u0623\\u0643\\u0627\\u062F\\u064A\\u0645\\u064A\"]", "img/offer5.png" },
                    { 6, 2, "خصم خاص على جميع الدبلومات المهنية في التمريض", 35, 2000m, "وفر 35%", "عرض الدبلومات المهنية", "Diploma", new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"\\u062F\\u0628\\u0644\\u0648\\u0645\\u0627\\u062A \\u0645\\u0639\\u062A\\u0645\\u062F\\u0629\",\"\\u062A\\u062F\\u0631\\u064A\\u0628 \\u0639\\u0645\\u0644\\u064A\",\"\\u0641\\u0631\\u0635 \\u0639\\u0645\\u0644\"]", "img/offer6.png" },
                    { 7, 1, "عرض نهاية العام - خصم كبير على جميع الخدمات", 50, 1500m, "وفر 50%", "عرض نهاية العام", "All", new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"\\u062E\\u0635\\u0645 \\u0634\\u0627\\u0645\\u0644\",\"\\u062C\\u0645\\u064A\\u0639 \\u0627\\u0644\\u062E\\u062F\\u0645\\u0627\\u062A\",\"\\u0639\\u0631\\u0636 \\u0645\\u062D\\u062F\\u0648\\u062F\"]", "img/offer7.png" },
                    { 8, 1, "هذا العرض منتهي الصلاحية", 50, 1000m, "انتهى العرض", "عرض منتهي الصلاحية", "Course", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"\\u0639\\u0631\\u0636 \\u0645\\u0646\\u062A\\u0647\\u064A\"]", "img/offer8.png" }
                });

            migrationBuilder.InsertData(
                table: "announcements",
                columns: new[] { "Id", "AdminImageUrl", "Content", "CreatedByAdminId", "Date", "Title", "category" },
                values: new object[,]
                {
                    { 1, "img/admin.png", "نرحب بكم في منصة التمريض الرائدة في مصر. نقدم لكم أفضل المحتوى التعليمي والتدريبي في مجال التمريض", 1, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "مرحباً بكم في منصة NursingIQ", "Urgent" },
                    { 2, "img/admin.png", "يسرنا أن نعلن عن إطلاق مجموعة جديدة من الدورات التدريبية المتخصصة في التمريض", 1, new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "إطلاق دورات جديدة في التمريض", "Info" },
                    { 3, "img/admin.png", "ورشة عمل مجانية حول أفضل الممارسات في التمريض في وحدات العناية المركزة - 25 يناير 2025", 1, new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ورشة عمل حول التمريض في العناية المركزة", "Important" },
                    { 4, "img/admin.png", "مسابقة شهرية لأفضل مقال في التمريض مع جوائز قيمة للفائزين", 1, new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "مسابقة أفضل مقال تمريضي", "Practical" },
                    { 5, "img/admin.png", "تم تحديث نظام الاختبارات ليشمل المزيد من الأسئلة التفاعلية والتقييم الذكي", 1, new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "تحديث نظام الاختبارات", "Important" },
                    { 6, "img/admin.png", "دورة تدريبية شاملة في الإسعافات الأولية مع شهادة معتمدة - التسجيل مفتوح الآن", 1, new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "دورة تدريبية في الإسعافات الأولية", "Academic" }
                });

            migrationBuilder.InsertData(
                table: "articles",
                columns: new[] { "Id", "Description", "Num_of_views", "Title", "UserId", "authorImage", "category", "imageUrl", "publishDate", "readTime" },
                values: new object[,]
                {
                    { 1, "مقال شامل عن تحديات التمريض في وحدات العناية المركزة وأفضل الممارسات", 1250, "التمريض في العناية المركزة: التحديات والحلول", 2, "img/doctor1.png", "العناية المركزة", "img/article1.jpg", "2025-01-15", "8 دقائق" },
                    { 2, "دليل شامل لفهم آليات عمل الأدوية وتأثيراتها الجانبية", 980, "أساسيات علم الأدوية للممرضين", 2, "img/doctor2.png", "علم الأدوية", "img/article2.jpg", "2025-01-12", "10 دقائق" },
                    { 3, "أفضل الممارسات في رعاية الأطفال والرضع في البيئة المستشفوية", 750, "رعاية الأطفال في المستشفيات: دليل شامل", 3, "img/doctor3.png", "تمريض الأطفال", "img/article3.jpg", "2025-01-10", "12 دقيقة" },
                    { 4, "استراتيجيات حديثة لإدارة الألم وتقييم مستوياته لدى المرضى", 1100, "إدارة الألم في التمريض: الطرق الحديثة", 2, "img/doctor1.png", "إدارة الألم", "img/article4.jpg", "2025-01-08", "9 دقائق" },
                    { 5, "دور الممرض في رعاية المرضى النفسيين وتقديم الدعم النفسي", 650, "التمريض النفسي: رعاية الصحة العقلية", 4, "img/doctor4.png", "التمريض النفسي", "img/article5.jpg", "2025-01-05", "11 دقيقة" },
                    { 6, "أحدث البروتوكولات والإرشادات للإنعاش القلبي الرئوي", 1400, "الإنعاش القلبي الرئوي: البروتوكولات الحديثة", 3, "img/doctor3.png", "الطوارئ", "img/article6.jpg", "2025-01-03", "7 دقائق" },
                    { 7, "استراتيجيات الوقاية من العدوى المكتسبة من المستشفيات", 890, "العدوى المكتسبة من المستشفيات: الوقاية والسيطرة", 2, "img/doctor2.png", "مكافحة العدوى", "img/article7.jpg", "2025-01-01", "13 دقيقة" },
                    { 8, "دور الممرض في جميع مراحل العملية الجراحية", 720, "التمريض في الجراحة: قبل وأثناء وبعد العملية", 3, "img/doctor3.png", "تمريض الجراحة", "img/article8.jpg", "2024-12-28", "10 دقائق" }
                });

            migrationBuilder.InsertData(
                table: "contactForms",
                columns: new[] { "ID", "CreatedByAdminId", "FullName", "InquiryType", "email", "message", "phone" },
                values: new object[,]
                {
                    { 1, 1, "محمد علي", "TechnicalProblem", "mohamed@example.com", "أريد معرفة المزيد عن منصة NursingIQ والخدمات المتاحة", "01012345678" },
                    { 2, 1, "سارة أحمد", "PaymentProblem", "sara@example.com", "لدي مشكلة في تسجيل الدخول إلى حسابي", "01098765432" },
                    { 3, 1, "أحمد محمود", "InquiryAboutCourse", "ahmed@example.com", "أريد الاستفسار عن دورة تمريض العناية المركزة ومتطلبات التسجيل", "01123456789" },
                    { 4, 1, "فاطمة حسن", "CertificateInquiry", "fatma@example.com", "متى يمكنني الحصول على شهادة إتمام الدورة التدريبية؟", "01234567890" },
                    { 5, 1, "علي إبراهيم", "Other", "ali@example.com", "هل يمكنني الحصول على نسخة من المحاضرات المسجلة؟", "01345678901" },
                    { 6, 1, "مريم عبدالله", "TechnicalProblem", "mariam@example.com", "لا يمكنني تحميل المواد التعليمية من الموقع", "01456789012" }
                });

            migrationBuilder.InsertData(
                table: "diplomas",
                columns: new[] { "ID", "CreatedByAdminId", "Description", "Duration", "Title", "register_steps", "requirement" },
                values: new object[,]
                {
                    { 1, 1, "تدريب متخصص للممرضين في وحدات العناية المركزة مع شهادة معتمدة", "6 أشهر", "دبلوم تمريض العناية المركزة", "[\"\\u0627\\u0644\\u062A\\u0633\\u062C\\u064A\\u0644 \\u0639\\u0628\\u0631 \\u0627\\u0644\\u0625\\u0646\\u062A\\u0631\\u0646\\u062A\",\"\\u062A\\u0642\\u062F\\u064A\\u0645 \\u0627\\u0644\\u0645\\u0633\\u062A\\u0646\\u062F\\u0627\\u062A \\u0627\\u0644\\u0645\\u0637\\u0644\\u0648\\u0628\\u0629\",\"\\u062F\\u0641\\u0639 \\u0627\\u0644\\u0631\\u0633\\u0648\\u0645\",\"\\u0627\\u062C\\u062A\\u064A\\u0627\\u0632 \\u0627\\u0644\\u0645\\u0642\\u0627\\u0628\\u0644\\u0629\"]", "[\"\\u0634\\u0647\\u0627\\u062F\\u0629 \\u0627\\u0644\\u062A\\u0645\\u0631\\u064A\\u0636\",\"\\u0633\\u0646\\u062A\\u0627\\u0646 \\u062E\\u0628\\u0631\\u0629 \\u0641\\u064A \\u0627\\u0644\\u062A\\u0645\\u0631\\u064A\\u0636\",\"\\u0627\\u062C\\u062A\\u064A\\u0627\\u0632 \\u0627\\u0644\\u0645\\u0642\\u0627\\u0628\\u0644\\u0629 \\u0627\\u0644\\u0634\\u062E\\u0635\\u064A\\u0629\"]" },
                    { 2, 1, "تخصص في رعاية الأطفال والرضع مع التركيز على الحالات الحرجة", "4 أشهر", "دبلوم تمريض الأطفال", "[\"\\u0627\\u0644\\u062A\\u0633\\u062C\\u064A\\u0644 \\u0639\\u0628\\u0631 \\u0627\\u0644\\u0625\\u0646\\u062A\\u0631\\u0646\\u062A\",\"\\u062A\\u0642\\u062F\\u064A\\u0645 \\u0627\\u0644\\u0645\\u0633\\u062A\\u0646\\u062F\\u0627\\u062A\",\"\\u0627\\u062C\\u062A\\u064A\\u0627\\u0632 \\u0627\\u0644\\u0645\\u0642\\u0627\\u0628\\u0644\\u0629 \\u0627\\u0644\\u0634\\u062E\\u0635\\u064A\\u0629\"]", "[\"\\u0634\\u0647\\u0627\\u062F\\u0629 \\u0627\\u0644\\u062A\\u0645\\u0631\\u064A\\u0636\",\"\\u062E\\u0628\\u0631\\u0629 \\u0641\\u064A \\u0631\\u0639\\u0627\\u064A\\u0629 \\u0627\\u0644\\u0623\\u0637\\u0641\\u0627\\u0644\"]" },
                    { 3, 1, "تخصص في رعاية المرضى النفسيين وتقديم الدعم النفسي", "5 أشهر", "دبلوم التمريض النفسي", "[\"\\u0627\\u0644\\u062A\\u0633\\u062C\\u064A\\u0644 \\u0639\\u0628\\u0631 \\u0627\\u0644\\u0625\\u0646\\u062A\\u0631\\u0646\\u062A\",\"\\u062A\\u0642\\u062F\\u064A\\u0645 \\u0627\\u0644\\u0645\\u0633\\u062A\\u0646\\u062F\\u0627\\u062A\",\"\\u0627\\u062C\\u062A\\u064A\\u0627\\u0632 \\u0627\\u062E\\u062A\\u0628\\u0627\\u0631 \\u0627\\u0644\\u0642\\u0628\\u0648\\u0644\",\"\\u062F\\u0641\\u0639 \\u0627\\u0644\\u0631\\u0633\\u0648\\u0645\"]", "[\"\\u0634\\u0647\\u0627\\u062F\\u0629 \\u0627\\u0644\\u062A\\u0645\\u0631\\u064A\\u0636\",\"\\u062E\\u0628\\u0631\\u0629 \\u0641\\u064A \\u0627\\u0644\\u062A\\u0645\\u0631\\u064A\\u0636 \\u0627\\u0644\\u0639\\u0627\\u0645\",\"\\u0627\\u062C\\u062A\\u064A\\u0627\\u0632 \\u0627\\u062E\\u062A\\u0628\\u0627\\u0631 \\u0627\\u0644\\u0642\\u0628\\u0648\\u0644\"]" },
                    { 4, 1, "تخصص في التعامل مع حالات الطوارئ والإسعافات الأولية", "4 أشهر", "دبلوم تمريض الطوارئ", "[\"\\u0627\\u0644\\u062A\\u0633\\u062C\\u064A\\u0644 \\u0639\\u0628\\u0631 \\u0627\\u0644\\u0625\\u0646\\u062A\\u0631\\u0646\\u062A\",\"\\u062A\\u0642\\u062F\\u064A\\u0645 \\u0627\\u0644\\u0645\\u0633\\u062A\\u0646\\u062F\\u0627\\u062A\",\"\\u0627\\u062C\\u062A\\u064A\\u0627\\u0632 \\u0627\\u0644\\u0645\\u0642\\u0627\\u0628\\u0644\\u0629\"]", "[\"\\u0634\\u0647\\u0627\\u062F\\u0629 \\u0627\\u0644\\u062A\\u0645\\u0631\\u064A\\u0636\",\"\\u062E\\u0628\\u0631\\u0629 \\u0641\\u064A \\u0627\\u0644\\u062A\\u0645\\u0631\\u064A\\u0636 \\u0627\\u0644\\u0639\\u0627\\u0645\"]" },
                    { 5, 1, "تخصص في إدارة الفرق التمريضية وإدارة الجودة في التمريض", "6 أشهر", "دبلوم إدارة التمريض", "[\"\\u0627\\u0644\\u062A\\u0633\\u062C\\u064A\\u0644 \\u0639\\u0628\\u0631 \\u0627\\u0644\\u0625\\u0646\\u062A\\u0631\\u0646\\u062A\",\"\\u062A\\u0642\\u062F\\u064A\\u0645 \\u0627\\u0644\\u0645\\u0633\\u062A\\u0646\\u062F\\u0627\\u062A\",\"\\u0627\\u062C\\u062A\\u064A\\u0627\\u0632 \\u0627\\u0644\\u0645\\u0642\\u0627\\u0628\\u0644\\u0629 \\u0627\\u0644\\u0634\\u062E\\u0635\\u064A\\u0629\",\"\\u062F\\u0641\\u0639 \\u0627\\u0644\\u0631\\u0633\\u0648\\u0645\"]", "[\"\\u0634\\u0647\\u0627\\u062F\\u0629 \\u0627\\u0644\\u062A\\u0645\\u0631\\u064A\\u0636\",\"3 \\u0633\\u0646\\u0648\\u0627\\u062A \\u062E\\u0628\\u0631\\u0629\",\"\\u062E\\u0628\\u0631\\u0629 \\u0641\\u064A \\u0627\\u0644\\u0625\\u062F\\u0627\\u0631\\u0629\"]" }
                });

            migrationBuilder.InsertData(
                table: "forumtopics",
                columns: new[] { "Id", "Description", "Title", "UserId", "category", "comments", "num_comments", "num_of_likes", "num_of_views" },
                values: new object[,]
                {
                    { 1, "شاركوا نصائحكم في دراسة التمريض وأفضل الطرق للاستذكار", "كيفية دراسة التمريض بفعالية؟", 5, "الدراسة", "[\"\\u0627\\u0633\\u062A\\u062E\\u062F\\u0645 \\u0627\\u0644\\u0628\\u0637\\u0627\\u0642\\u0627\\u062A \\u0627\\u0644\\u062A\\u0639\\u0644\\u064A\\u0645\\u064A\\u0629\",\"\\u0627\\u0644\\u062F\\u0631\\u0627\\u0633\\u0629 \\u0627\\u0644\\u062C\\u0645\\u0627\\u0639\\u064A\\u0629 \\u0645\\u0641\\u064A\\u062F\\u0629 \\u062C\\u062F\\u0627\\u064B\",\"\\u0631\\u0627\\u062C\\u0639 \\u0627\\u0644\\u0645\\u062D\\u0627\\u0636\\u0631\\u0627\\u062A \\u064A\\u0648\\u0645\\u064A\\u0627\\u064B\"]", 0, 25, 450 },
                    { 2, "ناقش أفضل الكتب والملاحظات لدراسة علم الأدوية", "أفضل المصادر لدراسة علم الأدوية", 6, "علم الأدوية", "[\"\\u0643\\u062A\\u0627\\u0628 \\u0643\\u0627\\u062A\\u0632\\u0648\\u0646\\u062C \\u0641\\u064A \\u0639\\u0644\\u0645 \\u0627\\u0644\\u0623\\u062F\\u0648\\u064A\\u0629\",\"\\u0627\\u0644\\u0645\\u0644\\u0627\\u062D\\u0638\\u0627\\u062A \\u0627\\u0644\\u0645\\u062D\\u0644\\u064A\\u0629 \\u0645\\u0641\\u064A\\u062F\\u0629\",\"\\u0627\\u0633\\u062A\\u062E\\u062F\\u0645 \\u0627\\u0644\\u062A\\u0637\\u0628\\u064A\\u0642\\u0627\\u062A \\u0627\\u0644\\u062A\\u0639\\u0644\\u064A\\u0645\\u064A\\u0629\"]", 0, 18, 320 },
                    { 3, "شاركوا تجاربكم في التدريب العملي في المستشفيات", "تجاربكم في التدريب العملي", 7, "التدريب العملي", "[\"\\u0627\\u0644\\u062A\\u062F\\u0631\\u064A\\u0628 \\u0641\\u064A \\u0627\\u0644\\u0639\\u0646\\u0627\\u064A\\u0629 \\u0627\\u0644\\u0645\\u0631\\u0643\\u0632\\u0629 \\u0643\\u0627\\u0646 \\u0635\\u0639\\u0628\\u0627\\u064B \\u0644\\u0643\\u0646 \\u0645\\u0641\\u064A\\u062F\\u0627\\u064B\",\"\\u062A\\u0639\\u0644\\u0645\\u062A \\u0627\\u0644\\u0643\\u062B\\u064A\\u0631 \\u0645\\u0646 \\u0627\\u0644\\u0645\\u0645\\u0631\\u0636\\u064A\\u0646 \\u0630\\u0648\\u064A \\u0627\\u0644\\u062E\\u0628\\u0631\\u0629\"]", 0, 32, 580 },
                    { 4, "كيف تتعاملون مع المرضى الصعبيين أو العدوانيين؟", "نصائح للتعامل مع المرضى الصعبيين", 8, "الممارسة المهنية", "[\"\\u0627\\u0644\\u0635\\u0628\\u0631 \\u0648\\u0627\\u0644\\u062A\\u0641\\u0647\\u0645 \\u0645\\u0641\\u062A\\u0627\\u062D \\u0627\\u0644\\u0646\\u062C\\u0627\\u062D\",\"\\u0627\\u0633\\u062A\\u062E\\u062F\\u0645 \\u062A\\u0642\\u0646\\u064A\\u0627\\u062A \\u0627\\u0644\\u062A\\u0648\\u0627\\u0635\\u0644 \\u0627\\u0644\\u0641\\u0639\\u0627\\u0644\",\"\\u0627\\u0637\\u0644\\u0628 \\u0627\\u0644\\u0645\\u0633\\u0627\\u0639\\u062F\\u0629 \\u0645\\u0646 \\u0627\\u0644\\u0641\\u0631\\u064A\\u0642\"]", 0, 28, 420 },
                    { 5, "ما هي أفضل التطبيقات التي تساعدكم في العمل؟", "أفضل التطبيقات للممرضين", 9, "التكنولوجيا", "[\"\\u062A\\u0637\\u0628\\u064A\\u0642 \\u062D\\u0633\\u0627\\u0628 \\u0627\\u0644\\u062C\\u0631\\u0639\\u0627\\u062A \\u0645\\u0641\\u064A\\u062F \\u062C\\u062F\\u0627\\u064B\",\"\\u062A\\u0637\\u0628\\u064A\\u0642 \\u0645\\u0631\\u0627\\u0642\\u0628\\u0629 \\u0627\\u0644\\u0639\\u0644\\u0627\\u0645\\u0627\\u062A \\u0627\\u0644\\u062D\\u064A\\u0648\\u064A\\u0629\",\"\\u062A\\u0637\\u0628\\u064A\\u0642 \\u0627\\u0644\\u0623\\u062F\\u0648\\u064A\\u0629 \\u0648\\u0627\\u0644\\u062A\\u0641\\u0627\\u0639\\u0644\\u0627\\u062A\"]", 0, 15, 280 },
                    { 6, "نصائح لإدارة الوقت بكفاءة أثناء العمل في التمريض", "كيفية إدارة الوقت في التمريض", 10, "إدارة الوقت", "[\"\\u062E\\u0637\\u0637 \\u0645\\u0647\\u0627\\u0645\\u0643 \\u0645\\u0633\\u0628\\u0642\\u0627\\u064B\",\"\\u0627\\u0633\\u062A\\u062E\\u062F\\u0645 \\u0642\\u0648\\u0627\\u0626\\u0645 \\u0627\\u0644\\u0645\\u0647\\u0627\\u0645\",\"\\u062A\\u0639\\u0644\\u0645 \\u0623\\u0646 \\u062A\\u0642\\u0648\\u0644 \\u0644\\u0627 \\u0639\\u0646\\u062F \\u0627\\u0644\\u062D\\u0627\\u062C\\u0629\"]", 0, 22, 350 }
                });

            migrationBuilder.InsertData(
                table: "medicalTerms",
                columns: new[] { "Id", "UserId", "arabicName", "category", "definition", "englishName", "example", "latinName", "synonyms" },
                values: new object[,]
                {
                    { 1, 2, "قلب", "Urgent", "التنفس الصناعي هو مساعدة المريض على التنفس", "Heart", "القلب يضخ الدم إلى جميع أنحاء الجسم", "Cor", "[\"\\u0642\\u0644\\u0628\\u064A\",\"\\u0642\\u0644\\u0628\\u064A \\u0648\\u0639\\u0627\\u0626\\u064A\"]" },
                    { 2, 2, "رئة", "Important", "التنفس الصناعي هو مساعدة المريض على التنفس", "Lung", "الرئة تساعد في التنفس وتبادل الغازات", "Pulmo", "[\"\\u0631\\u0626\\u0648\\u064A\",\"\\u062A\\u0646\\u0641\\u0633\\u064A\"]" },
                    { 3, 2, "كبد", "Practical", "التنفس الصناعي هو مساعدة المريض على التنفس", "Liver", "الكبد يقوم بتصفية الدم وإنتاج الصفراء", "Hepar", "[\"\\u0643\\u0628\\u062F\\u064A\",\"\\u0647\\u064A\\u0628\\u0627\\u062A\\u064A\\u0643\"]" },
                    { 4, 3, "كلية", "Info", "التنفس الصناعي هو مساعدة المريض على التنفس", "Kidney", "الكلى تقوم بتصفية الدم وإنتاج البول", "Ren", "[\"\\u0643\\u0644\\u0648\\u064A\",\"\\u0631\\u064A\\u0646\\u0627\\u0644\"]" },
                    { 5, 2, "حمى", "6", "التنفس الصناعي هو مساعدة المريض على التنفس", "Fever", "الحمى هي ارتفاع في درجة حرارة الجسم", "Febris", "[\"\\u0627\\u0631\\u062A\\u0641\\u0627\\u0639 \\u0627\\u0644\\u062D\\u0631\\u0627\\u0631\\u0629\",\"\\u0633\\u062E\\u0648\\u0646\\u0629\"]" },
                    { 6, 3, "صداع", "Important", "التنفس الصناعي هو مساعدة المريض على التنفس", "Headache", "الصداع هو ألم في الرأس أو الرقبة", "Cephalgia", "[\"\\u0623\\u0644\\u0645 \\u0627\\u0644\\u0631\\u0623\\u0633\",\"\\u0648\\u062C\\u0639 \\u0627\\u0644\\u0631\\u0623\\u0633\"]" },
                    { 7, 2, "غثيان", "Urgent", "التنفس الصناعي هو مساعدة المريض على التنفس", "Nausea", "الغثيان هو الشعور بالرغبة في التقيؤ", "Nausea", "[\"\\u0631\\u063A\\u0628\\u0629 \\u0641\\u064A \\u0627\\u0644\\u062A\\u0642\\u064A\\u0624\",\"\\u062F\\u0648\\u062E\\u0629\"]" },
                    { 8, 3, "جراحة", "Important", "التنفس الصناعي هو مساعدة المريض على التنفس", "Surgery", "الجراحة هي إجراء طبي يتطلب قطع الأنسجة", "Chirurgia", "[\"\\u0639\\u0645\\u0644\\u064A\\u0629 \\u062C\\u0631\\u0627\\u062D\\u064A\\u0629\",\"\\u062A\\u062F\\u062E\\u0644 \\u062C\\u0631\\u0627\\u062D\\u064A\"]" },
                    { 9, 4, "تنفس صناعي", "Important", "التنفس الصناعي هو مساعدة المريض على التنفس", "Artificial Respiration", "التنفس الصناعي هو مساعدة المريض على التنفس", "Respiratio Artificialis", "[\"\\u062A\\u0647\\u0648\\u064A\\u0629 \\u0635\\u0646\\u0627\\u0639\\u064A\\u0629\",\"\\u062F\\u0639\\u0645 \\u062A\\u0646\\u0641\\u0633\\u064A\"]" },
                    { 10, 2, "مضاد حيوي", "Practical", "التنفس الصناعي هو مساعدة المريض على التنفس", "Antibiotic", "المضاد الحيوي يقتل البكتيريا أو يمنع نموها", "Antibioticum", "[\"\\u0645\\u0636\\u0627\\u062F \\u0628\\u0643\\u062A\\u064A\\u0631\\u064A\",\"\\u0645\\u0636\\u0627\\u062F \\u062C\\u0631\\u062B\\u0648\\u0645\\u064A\"]" },
                    { 11, 3, "مسكن ألم", "Urgent", "التنفس الصناعي هو مساعدة المريض على التنفس", "Analgesic", "مسكن الألم يخفف من الشعور بالألم", "Analgeticum", "[\"\\u0645\\u062E\\u062F\\u0631\",\"\\u0645\\u0647\\u062F\\u0626\"]" }
                });

            migrationBuilder.InsertData(
                table: "training_Videos",
                columns: new[] { "Id", "CreatedByAdminId", "Description", "Title", "category", "duration", "instructorImage", "instructorName", "publishedDate", "thumbnailUrl", "videoUrl" },
                values: new object[,]
                {
                    { 1, 2, "تعلم ممارسات الحقن الآمنة مع التركيز على السلامة والوقاية من العدوى", "تقنيات الحقن الآمنة", "مهارات", "15 دقيقة", "img/doctor1.png", "د. أحمد محمد", "2025-09-13", "img/injection.png", "videos/injection.mp4" },
                    { 2, 2, "دليل خطوة بخطوة لتضميد الجروح مع التركيز على النظافة والسلامة", "تضميد الجروح", "مهارات", "20 دقيقة", "img/doctor2.png", "د. فاطمة أحمد", "2025-06-23", "img/dressing.png", "videos/dressing.mp4" },
                    { 3, 1, "تعلم كيفية قياس النبض وضغط الدم ودرجة الحرارة بدقة", "قياس العلامات الحيوية", "طوارئ", "25 دقيقة", "img/doctor3.png", "د. محمد علي", "2025-08-15", "img/vitals.png", "videos/vitals.mp4" },
                    { 4, 2, "كيفية التعامل مع حالات الطوارئ الطبية والإنعاش القلبي الرئوي", "التعامل مع حالات الطوارئ", "طوارئ", "30 دقيقة", "img/doctor4.png", "د. سارة محمود", "2025-07-10", "img/emergency.png", "videos/emergency.mp4" },
                    { 5, 1, "مبادئ رعاية المرضى في العناية المركزة مع التركيز على المراقبة المستمرة", "رعاية مرضى العناية المركزة", "طوارئ", "35 دقيقة", "img/doctor5.png", "د. خالد حسن", "2025-05-20", "img/icu_care.png", "videos/icu_care.mp4" },
                    { 6, 2, "تعلم كيفية تشغيل ومراقبة أجهزة التنفس الصناعي", "استخدام أجهزة التنفس الصناعي", "طوارئ", "40 دقيقة", "img/doctor6.png", "د. مريم عبدالله", "2025-04-15", "img/ventilator.png", "videos/ventilator.mp4" },
                    { 7, 1, "مبادئ رعاية الأطفال المرضى مع التركيز على التواصل والراحة النفسية", "رعاية الأطفال المرضى", "طب الأطفال", "28 دقيقة", "img/doctor7.png", "د. يوسف إبراهيم", "2025-03-10", "img/pediatrics.png", "videos/pediatrics.mp4" },
                    { 8, 2, "تقنيات خاصة لحقن الأطفال مع تقليل الألم والخوف", "حقن الأطفال", "طب الأطفال", "22 دقيقة", "img/doctor8.png", "د. رانيا محمد", "2025-02-05", "img/pediatric_injection.png", "videos/pediatric_injection.mp4" },
                    { 9, 1, "مبادئ التمريض في غرف العمليات مع التركيز على التعقيم", "التمريض الجراحي", "جراحة", "45 دقيقة", "img/doctor9.png", "د. علي أحمد", "2025-01-20", "img/surgical_nursing.png", "videos/surgical_nursing.mp4" },
                    { 10, 2, "خطوات إعداد المريض قبل الجراحة مع التركيز على السلامة", "إعداد المريض للجراحة", "جراحة", "32 دقيقة", "img/doctor10.png", "د. نور الدين", "2024-12-15", "img/pre_surgery.png", "videos/pre_surgery.mp4" }
                });

            migrationBuilder.InsertData(
                table: "trainings",
                columns: new[] { "Id", "Category", "CreatedByAdminId", "Description", "Experience", "HospitalName", "Location", "Title", "deadline", "imageUrl", "postedDate", "requirement", "salary" },
                values: new object[,]
                {
                    { 1, "تدريب عملي", 1, "برنامج تدريبي متقدم في العناية المركزة مع تدريب عملي على أحدث المعدات", "سنتان", "مستشفى القاهرة الدولي", "القاهرة", "تدريب العناية المركزة", new DateTime(2025, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/training1.png", new DateTime(2025, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"\\u062E\\u0628\\u0631\\u0629 \\u0641\\u064A \\u0627\\u0644\\u0639\\u0646\\u0627\\u064A\\u0629 \\u0627\\u0644\\u0645\\u0631\\u0643\\u0632\\u0629\",\"\\u0634\\u0647\\u0627\\u062F\\u0629 \\u062A\\u0645\\u0631\\u064A\\u0636\",\"\\u0634\\u0647\\u0627\\u062F\\u0629 BLS\"]", 5000m },
                    { 2, "Pediatrics", 1, "تدريب متخصص في رعاية الأطفال المرضى مع التركيز على التواصل مع الأطفال", "سنة واحدة", "مستشفى الأطفال", "الجيزة", "تدريب طب الأطفال", new DateTime(2025, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/training2.png", new DateTime(2025, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"\\u062E\\u0628\\u0631\\u0629 \\u0641\\u064A \\u0637\\u0628 \\u0627\\u0644\\u0623\\u0637\\u0641\\u0627\\u0644\",\"\\u0634\\u0647\\u0627\\u062F\\u0629 \\u062A\\u0645\\u0631\\u064A\\u0636\"]", 4000m },
                    { 3, "Emergency", 2, "تدريب متقدم في التعامل مع حالات الطوارئ الطبية والحوادث", "سنة ونصف", "مستشفى الطوارئ", "الإسكندرية", "تدريب الطوارئ الطبية", new DateTime(2025, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/training3.png", new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"\\u062E\\u0628\\u0631\\u0629 \\u0641\\u064A \\u0627\\u0644\\u0637\\u0648\\u0627\\u0631\\u0626\",\"\\u0634\\u0647\\u0627\\u062F\\u0629 ACLS\",\"\\u0633\\u0631\\u0639\\u0629 \\u0641\\u064A \\u0627\\u0644\\u0627\\u0633\\u062A\\u062C\\u0627\\u0628\\u0629\"]", 4500m },
                    { 4, "Surgery", 1, "تدريب متخصص في التمريض الجراحي مع التركيز على التعقيم والسلامة", "سنتان", "مستشفى الجراحة المتخصصة", "القاهرة", "تدريب التمريض الجراحي", new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/training4.png", new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"\\u062E\\u0628\\u0631\\u0629 \\u0641\\u064A \\u0627\\u0644\\u062C\\u0631\\u0627\\u062D\\u0629\",\"\\u062F\\u0642\\u0629 \\u0641\\u064A \\u0627\\u0644\\u0639\\u0645\\u0644\",\"\\u062A\\u062D\\u0645\\u0644 \\u0636\\u063A\\u0637 \\u0627\\u0644\\u0639\\u0645\\u0644\"]", 5500m },
                    { 5, "Oncology", 2, "تدريب متخصص في رعاية الأطفال المصابين بالسرطان مع الدعم النفسي", "سنة ونصف", "مستشفى سرطان الأطفال", "الجيزة", "تدريب أورام الأطفال", new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/training5.png", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"\\u062E\\u0628\\u0631\\u0629 \\u0641\\u064A \\u0627\\u0644\\u0623\\u0648\\u0631\\u0627\\u0645\",\"\\u062A\\u0639\\u0627\\u0637\\u0641 \\u0645\\u0639 \\u0627\\u0644\\u0645\\u0631\\u0636\\u0649\",\"\\u0634\\u0647\\u0627\\u062F\\u0629 \\u062A\\u0645\\u0631\\u064A\\u0636\"]", 4800m },
                    { 6, "Cardiology", 1, "تدريب متقدم في رعاية مرضى القلب مع استخدام أحدث التقنيات", "سنتان", "معهد القلب", "القاهرة", "تدريب القلب والأوعية الدموية", new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/training6.png", new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"\\u062E\\u0628\\u0631\\u0629 \\u0641\\u064A \\u0627\\u0644\\u0642\\u0644\\u0628\",\"\\u0634\\u0647\\u0627\\u062F\\u0629 ACLS\",\"\\u062F\\u0642\\u0629 \\u0641\\u064A \\u0627\\u0644\\u0645\\u0631\\u0627\\u0642\\u0628\\u0629\"]", 5200m },
                    { 7, "Neonatal", 2, "تدريب متخصص في رعاية الأطفال حديثي الولادة والخدج", "سنة واحدة", "مستشفى الولادة", "الإسكندرية", "تدريب العناية بالأطفال حديثي الولادة", new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/training7.png", new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"\\u062E\\u0628\\u0631\\u0629 \\u0641\\u064A \\u062D\\u062F\\u064A\\u062B\\u064A \\u0627\\u0644\\u0648\\u0644\\u0627\\u062F\\u0629\",\"\\u0635\\u0628\\u0631 \\u0648\\u062F\\u0642\\u0629\",\"\\u0634\\u0647\\u0627\\u062F\\u0629 NRP\"]", 4600m },
                    { 8, "Mental Health", 1, "تدريب في رعاية المرضى النفسيين مع التركيز على الدعم النفسي", "سنة واحدة", "مستشفى الطب النفسي", "القاهرة", "تدريب الصحة النفسية", new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/training8.png", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"\\u062E\\u0628\\u0631\\u0629 \\u0641\\u064A \\u0627\\u0644\\u0635\\u062D\\u0629 \\u0627\\u0644\\u0646\\u0641\\u0633\\u064A\\u0629\",\"\\u062A\\u0639\\u0627\\u0637\\u0641\",\"\\u0645\\u0647\\u0627\\u0631\\u0627\\u062A \\u062A\\u0648\\u0627\\u0635\\u0644\"]", 4200m }
                });

            migrationBuilder.InsertData(
                table: "UserRegisteredTrainings",
                columns: new[] { "TrainingId", "UserId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 6, 2 },
                    { 2, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 5 },
                    { 3, 6 },
                    { 4, 6 },
                    { 5, 7 },
                    { 6, 7 },
                    { 7, 8 },
                    { 8, 8 },
                    { 4, 9 },
                    { 5, 10 },
                    { 7, 10 },
                    { 8, 10 }
                });

            migrationBuilder.InsertData(
                table: "diplomaFeatures",
                columns: new[] { "Id", "Description", "DiplomaId", "Icon", "Title" },
                values: new object[,]
                {
                    { 1, "تدريب عملي مباشر في وحدات العناية المركزة مع المرضى الحقيقيين", 1, "icon-icu.png", "تدريب عملي في العناية المركزة" },
                    { 2, "جميع الدورات تدرس من قبل أطباء وممرضين معتمدين", 1, "icon-doctor.png", "مدربون معتمدون" },
                    { 3, "شهادة معتمدة من وزارة الصحة معترف بها في جميع المستشفيات", 1, "icon-certificate.png", "شهادة معتمدة" },
                    { 4, "محتوى متخصص في رعاية الأطفال والرضع", 2, "icon-child.png", "تركيز على رعاية الأطفال" },
                    { 5, "تدريب عملي في مستشفيات الأطفال المتخصصة", 2, "icon-hospital.png", "تدريب في مستشفيات الأطفال" },
                    { 6, "متابعة مستمرة بعد التخرج ودعم مهني", 2, "icon-support.png", "متابعة مستمرة" },
                    { 7, "تدريب متخصص في رعاية المرضى النفسيين", 3, "icon-mental-health.png", "تدريب في الصحة النفسية" },
                    { 8, "تعلم تقنيات العلاج النفسي والاستشارة", 3, "icon-therapy.png", "تقنيات العلاج النفسي" },
                    { 9, "تدريب على الإسعافات الأولية المتقدمة", 4, "icon-emergency.png", "الإسعافات الأولية المتقدمة" },
                    { 10, "تدريب على التعامل مع الحالات الحرجة والطوارئ", 4, "icon-critical.png", "التعامل مع الحالات الحرجة" },
                    { 11, "تعلم إدارة الفرق التمريضية وتنظيم العمل", 5, "icon-management.png", "إدارة الفرق التمريضية" },
                    { 12, "تعلم معايير الجودة في التمريض وإدارة الجودة", 5, "icon-quality.png", "إدارة الجودة" }
                });

            migrationBuilder.InsertData(
                table: "lectures",
                columns: new[] { "Id", "CourseId", "Title", "UserId", "bigDescription", "duration", "smallDescription", "videoUrl" },
                values: new object[,]
                {
                    { 1, 1, "مقدمة في العناية المركزة", 2, "محاضرة شاملة عن العناية المركزة تشمل التعريف والأهداف والمبادئ الأساسية", "45 دقيقة", "تعريف بالعناية المركزة وأهميتها", "lectures/icu_intro.mp4" },
                    { 2, 1, "مراقبة العلامات الحيوية", 2, "تعلم كيفية مراقبة وقياس العلامات الحيوية المختلفة للمرضى في العناية المركزة", "50 دقيقة", "كيفية مراقبة العلامات الحيوية في العناية المركزة", "lectures/vital_signs.mp4" },
                    { 3, 2, "مقدمة في علم الأدوية", 3, "محاضرة شاملة عن علم الأدوية تشمل التعريف والتصنيف وآلية العمل", "40 دقيقة", "تعريف بعلم الأدوية وتصنيفها", "lectures/pharma_intro.mp4" },
                    { 4, 2, "المسكنات ومضادات الالتهاب", 3, "تعلم أنواع المسكنات المختلفة وآلية عملها ومضادات الالتهاب", "55 دقيقة", "أنواع المسكنات ومضادات الالتهاب", "lectures/analgesics.mp4" },
                    { 5, 3, "الجهاز الهيكلي", 4, "دراسة شاملة للجهاز الهيكلي تشمل العظام والمفاصل والغضاريف", "60 دقيقة", "مقدمة في الجهاز الهيكلي", "lectures/skeletal_system.mp4" },
                    { 6, 3, "الجهاز العصبي", 4, "دراسة الجهاز العصبي المركزي والمحيطي ووظائفه المختلفة", "65 دقيقة", "مقدمة في الجهاز العصبي", "lectures/nervous_system.mp4" },
                    { 7, 4, "الإنعاش القلبي الرئوي", 5, "تعلم خطوات الإنعاش القلبي الرئوي الصحيحة للمرضى البالغين والأطفال", "50 دقيقة", "مبادئ الإنعاش القلبي الرئوي", "lectures/cpr.mp4" },
                    { 8, 4, "التعامل مع حالات الطوارئ", 5, "تعلم كيفية التعامل مع حالات الطوارئ الطبية المختلفة وترتيب الأولويات", "45 دقيقة", "كيفية التعامل مع حالات الطوارئ المختلفة", "lectures/emergency_care.mp4" },
                    { 9, 5, "رعاية الأطفال حديثي الولادة", 6, "تعلم كيفية رعاية الأطفال حديثي الولادة والخدج مع التركيز على السلامة", "55 دقيقة", "مبادئ رعاية الأطفال حديثي الولادة", "lectures/neonatal_care.mp4" },
                    { 10, 5, "التغذية عند الأطفال", 6, "تعلم مبادئ التغذية الصحية للأطفال في مختلف المراحل العمرية", "40 دقيقة", "مبادئ التغذية الصحية للأطفال", "lectures/pediatric_nutrition.mp4" }
                });

            migrationBuilder.InsertData(
                table: "lectureMaterials",
                columns: new[] { "Id", "FileName", "FileUrl", "LectureId" },
                values: new object[,]
                {
                    { 1, "مقدمة_العناية_المركزة.pdf", "materials/icu_intro.pdf", 1 },
                    { 2, "مراقبة_العلامات_الحيوية.pdf", "materials/vital_signs.pdf", 2 },
                    { 3, "جدول_العلامات_الحيوية.xlsx", "materials/vital_signs_table.xlsx", 2 },
                    { 4, "مقدمة_علم_الأدوية.pdf", "materials/pharma_intro.pdf", 3 },
                    { 5, "تصنيف_الأدوية.pdf", "materials/drug_classification.pdf", 3 },
                    { 6, "المسكنات_ومضادات_الالتهاب.pdf", "materials/analgesics.pdf", 4 },
                    { 7, "الجهاز_الهيكلي.pdf", "materials/skeletal_system.pdf", 5 },
                    { 8, "صور_تشريحية_للهيكل_العظمي.jpg", "materials/skeletal_images.jpg", 5 },
                    { 9, "الجهاز_العصبي.pdf", "materials/nervous_system.pdf", 6 },
                    { 10, "دليل_الإنعاش_القلبي_الرئوي.pdf", "materials/cpr_guide.pdf", 7 },
                    { 11, "حالات_الطوارئ_الشائعة.pdf", "materials/common_emergencies.pdf", 8 },
                    { 12, "رعاية_حديثي_الولادة.pdf", "materials/neonatal_care.pdf", 9 },
                    { 13, "التغذية_عند_الأطفال.pdf", "materials/pediatric_nutrition.pdf", 10 }
                });

            migrationBuilder.InsertData(
                table: "quizzes",
                columns: new[] { "Id", "CourseId", "LectureId", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1, "اختبار أساسيات العناية المركزة", 2 },
                    { 2, 2, 2, "اختبار علم الأدوية", 2 },
                    { 3, 3, 3, "اختبار التشريح", 3 },
                    { 4, 4, 4, "اختبار الطوارئ الطبية", 4 },
                    { 5, 5, 5, "اختبار طب الأطفال", 5 }
                });

            migrationBuilder.InsertData(
                table: "questions",
                columns: new[] { "Id", "CorrectAnswer", "IsCorrect", "QuizId", "Student_Answer", "Text", "hardnessType", "options" },
                values: new object[,]
                {
                    { 1, "وحدة العناية المركزة", false, 1, "", "ماذا تعني كلمة ICU؟", "easy", "[\"\\u0648\\u062D\\u062F\\u0629 \\u0627\\u0644\\u0639\\u0646\\u0627\\u064A\\u0629 \\u0627\\u0644\\u0645\\u0631\\u0643\\u0632\\u0629\",\"\\u0648\\u062D\\u062F\\u0629 \\u0627\\u0644\\u0631\\u0639\\u0627\\u064A\\u0629 \\u0627\\u0644\\u062F\\u0627\\u062E\\u0644\\u064A\\u0629\",\"\\u0648\\u062D\\u062F\\u0629 \\u0627\\u0644\\u0631\\u0639\\u0627\\u064A\\u0629 \\u0627\\u0644\\u062F\\u0648\\u0644\\u064A\\u0629\"]" },
                    { 2, "120/80 ملم زئبق", false, 1, "", "ما هو المعدل الطبيعي لضغط الدم؟", "medium", "[\"120/80 \\u0645\\u0644\\u0645 \\u0632\\u0626\\u0628\\u0642\",\"140/90 \\u0645\\u0644\\u0645 \\u0632\\u0626\\u0628\\u0642\",\"100/60 \\u0645\\u0644\\u0645 \\u0632\\u0626\\u0628\\u0642\"]" },
                    { 3, "التهاب رئوي مرتبط بالتنفس الصناعي", false, 1, "", "ما هي مضاعفات استخدام جهاز التنفس الصناعي؟", "hard", "[\"\\u0627\\u0644\\u062A\\u0647\\u0627\\u0628 \\u0631\\u0626\\u0648\\u064A \\u0645\\u0631\\u062A\\u0628\\u0637 \\u0628\\u0627\\u0644\\u062A\\u0646\\u0641\\u0633 \\u0627\\u0644\\u0635\\u0646\\u0627\\u0639\\u064A\",\"\\u062A\\u0644\\u0641 \\u0627\\u0644\\u0643\\u0628\\u062F\",\"\\u0641\\u0634\\u0644 \\u0643\\u0644\\u0648\\u064A\"]" },
                    { 4, "تسكين الألم", false, 2, "", "ما هو الاستخدام الرئيسي للباراسيتامول؟", "easy", "[\"\\u062A\\u0633\\u0643\\u064A\\u0646 \\u0627\\u0644\\u0623\\u0644\\u0645\",\"\\u0645\\u0636\\u0627\\u062F \\u062D\\u064A\\u0648\\u064A\",\"\\u0645\\u0636\\u0627\\u062F \\u0644\\u0644\\u0627\\u0644\\u062A\\u0647\\u0627\\u0628\"]" },
                    { 5, "الإسهال", false, 2, "", "ما هي الآثار الجانبية الشائعة للمضادات الحيوية؟", "medium", "[\"\\u0627\\u0644\\u0625\\u0633\\u0647\\u0627\\u0644\",\"\\u0627\\u0631\\u062A\\u0641\\u0627\\u0639 \\u0636\\u063A\\u0637 \\u0627\\u0644\\u062F\\u0645\",\"\\u0627\\u0646\\u062E\\u0641\\u0627\\u0636 \\u0627\\u0644\\u0633\\u0643\\u0631\"]" },
                    { 6, "منع مستقبلات بيتا الأدرينالية", false, 2, "", "ما هو آلية عمل حاصرات بيتا؟", "hard", "[\"\\u0645\\u0646\\u0639 \\u0645\\u0633\\u062A\\u0642\\u0628\\u0644\\u0627\\u062A \\u0628\\u064A\\u062A\\u0627 \\u0627\\u0644\\u0623\\u062F\\u0631\\u064A\\u0646\\u0627\\u0644\\u064A\\u0629\",\"\\u062A\\u062B\\u0628\\u064A\\u0637 \\u0645\\u0636\\u062E\\u0629 \\u0627\\u0644\\u0628\\u0631\\u0648\\u062A\\u0648\\u0646\",\"\\u0645\\u0646\\u0639 \\u0642\\u0646\\u0648\\u0627\\u062A \\u0627\\u0644\\u0643\\u0627\\u0644\\u0633\\u064A\\u0648\\u0645\"]" },
                    { 7, "206 عظمة", false, 3, "", "كم عدد العظام في جسم الإنسان البالغ؟", "easy", "[\"206 \\u0639\\u0638\\u0645\\u0629\",\"300 \\u0639\\u0638\\u0645\\u0629\",\"150 \\u0639\\u0638\\u0645\\u0629\"]" },
                    { 8, "الجلد", false, 3, "", "ما هو أكبر عضو في جسم الإنسان؟", "medium", "[\"\\u0627\\u0644\\u062C\\u0644\\u062F\",\"\\u0627\\u0644\\u0643\\u0628\\u062F\",\"\\u0627\\u0644\\u0631\\u0626\\u062A\\u0627\\u0646\"]" },
                    { 9, "التأكد من سلامة المكان", false, 4, "", "ما هو أول إجراء في الإنعاش القلبي الرئوي؟", "medium", "[\"\\u0627\\u0644\\u062A\\u0623\\u0643\\u062F \\u0645\\u0646 \\u0633\\u0644\\u0627\\u0645\\u0629 \\u0627\\u0644\\u0645\\u0643\\u0627\\u0646\",\"\\u0628\\u062F\\u0621 \\u0627\\u0644\\u0636\\u063A\\u0637\\u0627\\u062A \\u0627\\u0644\\u0635\\u062F\\u0631\\u064A\\u0629\",\"\\u0625\\u0639\\u0637\\u0627\\u0621 \\u0627\\u0644\\u062A\\u0646\\u0641\\u0633 \\u0627\\u0644\\u0635\\u0646\\u0627\\u0639\\u064A\"]" },
                    { 10, "100-120 ضغطة في الدقيقة", false, 4, "", "ما هو معدل الضغطات الصدرية في الإنعاش القلبي الرئوي؟", "hard", "[\"100-120 \\u0636\\u063A\\u0637\\u0629 \\u0641\\u064A \\u0627\\u0644\\u062F\\u0642\\u064A\\u0642\\u0629\",\"80-100 \\u0636\\u063A\\u0637\\u0629 \\u0641\\u064A \\u0627\\u0644\\u062F\\u0642\\u064A\\u0642\\u0629\",\"120-140 \\u0636\\u063A\\u0637\\u0629 \\u0641\\u064A \\u0627\\u0644\\u062F\\u0642\\u064A\\u0642\\u0629\"]" },
                    { 11, "80-120 نبضة في الدقيقة", false, 5, "", "ما هو المعدل الطبيعي لضربات القلب عند الأطفال؟", "easy", "[\"80-120 \\u0646\\u0628\\u0636\\u0629 \\u0641\\u064A \\u0627\\u0644\\u062F\\u0642\\u064A\\u0642\\u0629\",\"60-80 \\u0646\\u0628\\u0636\\u0629 \\u0641\\u064A \\u0627\\u0644\\u062F\\u0642\\u064A\\u0642\\u0629\",\"120-160 \\u0646\\u0628\\u0636\\u0629 \\u0641\\u064A \\u0627\\u0644\\u062F\\u0642\\u064A\\u0642\\u0629\"]" },
                    { 12, "جفاف الفم والعينين", false, 5, "", "ما هي علامات الجفاف عند الأطفال؟", "medium", "[\"\\u062C\\u0641\\u0627\\u0641 \\u0627\\u0644\\u0641\\u0645 \\u0648\\u0627\\u0644\\u0639\\u064A\\u0646\\u064A\\u0646\",\"\\u0627\\u0631\\u062A\\u0641\\u0627\\u0639 \\u062F\\u0631\\u062C\\u0629 \\u0627\\u0644\\u062D\\u0631\\u0627\\u0631\\u0629\",\"\\u0632\\u064A\\u0627\\u062F\\u0629 \\u0627\\u0644\\u062A\\u0628\\u0648\\u0644\"]" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_announcements_CreatedByAdminId",
                table: "announcements",
                column: "CreatedByAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_articles_UserId",
                table: "articles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_contactForms_CreatedByAdminId",
                table: "contactForms",
                column: "CreatedByAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_UserId",
                table: "Courses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_diplomaFeatures_DiplomaId",
                table: "diplomaFeatures",
                column: "DiplomaId");

            migrationBuilder.CreateIndex(
                name: "IX_diplomas_CreatedByAdminId",
                table: "diplomas",
                column: "CreatedByAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_forumtopics_UserId",
                table: "forumtopics",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_lectureMaterials_LectureId",
                table: "lectureMaterials",
                column: "LectureId");

            migrationBuilder.CreateIndex(
                name: "IX_lectures_CourseId",
                table: "lectures",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_lectures_UserId",
                table: "lectures",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_medicalTerms_UserId",
                table: "medicalTerms",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_medicines_applicationUserId",
                table: "medicines",
                column: "applicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_CreatedByAdminId",
                table: "Offers",
                column: "CreatedByAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_questions_QuizId",
                table: "questions",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_quizzes_CourseId",
                table: "quizzes",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_quizzes_LectureId",
                table: "quizzes",
                column: "LectureId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_quizzes_UserId",
                table: "quizzes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_training_Videos_CreatedByAdminId",
                table: "training_Videos",
                column: "CreatedByAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_trainings_CreatedByAdminId",
                table: "trainings",
                column: "CreatedByAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRegisteredTrainings_TrainingId",
                table: "UserRegisteredTrainings",
                column: "TrainingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "announcements");

            migrationBuilder.DropTable(
                name: "articles");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "contactForms");

            migrationBuilder.DropTable(
                name: "diplomaFeatures");

            migrationBuilder.DropTable(
                name: "forumtopics");

            migrationBuilder.DropTable(
                name: "lectureMaterials");

            migrationBuilder.DropTable(
                name: "medicalTerms");

            migrationBuilder.DropTable(
                name: "medicines");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "questions");

            migrationBuilder.DropTable(
                name: "training_Videos");

            migrationBuilder.DropTable(
                name: "UserRegisteredTrainings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "diplomas");

            migrationBuilder.DropTable(
                name: "quizzes");

            migrationBuilder.DropTable(
                name: "trainings");

            migrationBuilder.DropTable(
                name: "lectures");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
