using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nurse_IQ.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
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
                    category = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
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
                    autorImage = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    publisheDate = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
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
                    courseRequizetes = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    category = table.Column<string>(type: "VARCHAR(55)", maxLength: 55, nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_medicines_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    DiscountPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[OriginalPrice] * [discountPercentage] / 100", stored: true),
                    LastPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[OriginalPrice] - ([OriginalPrice] * [discountPercentage] / 100)", stored: true),
                    discountPercentage = table.Column<int>(type: "int", nullable: false),
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
                name: "IX_medicines_UserId",
                table: "medicines",
                column: "UserId");

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
