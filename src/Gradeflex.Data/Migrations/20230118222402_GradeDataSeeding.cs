using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Gradeflex.Data.Migrations
{
    /// <inheritdoc />
    public partial class GradeDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Value",
                table: "Grades",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseId", "StudentId", "Type", "Value" },
                values: new object[,]
                {
                    { 1, 14, 1, 1, 8.0 },
                    { 2, 14, 1, 2, 6.0 },
                    { 3, 14, 1, 0, 9.0 },
                    { 4, 9, 2, 1, 6.0 },
                    { 5, 9, 2, 2, 0.0 },
                    { 6, 9, 2, 0, 7.0 },
                    { 7, 15, 3, 1, 2.0 },
                    { 8, 15, 3, 2, 8.0 },
                    { 9, 15, 3, 0, 1.0 },
                    { 10, 7, 4, 1, 0.0 },
                    { 11, 7, 4, 2, 2.0 },
                    { 12, 7, 4, 0, 10.0 },
                    { 13, 15, 5, 1, 10.0 },
                    { 14, 15, 5, 2, 4.0 },
                    { 15, 15, 5, 0, 8.0 },
                    { 16, 20, 6, 1, 6.0 },
                    { 17, 20, 6, 2, 1.0 },
                    { 18, 20, 6, 0, 0.0 },
                    { 19, 19, 7, 1, 7.0 },
                    { 20, 19, 7, 2, 8.0 },
                    { 21, 19, 7, 0, 8.0 },
                    { 22, 20, 8, 1, 6.0 },
                    { 23, 20, 8, 2, 7.0 },
                    { 24, 20, 8, 0, 5.0 },
                    { 25, 9, 9, 1, 1.0 },
                    { 26, 9, 9, 2, 6.0 },
                    { 27, 9, 9, 0, 7.0 },
                    { 28, 19, 10, 1, 10.0 },
                    { 29, 19, 10, 2, 10.0 },
                    { 30, 19, 10, 0, 10.0 },
                    { 31, 17, 11, 1, 4.0 },
                    { 32, 17, 11, 2, 7.0 },
                    { 33, 17, 11, 0, 0.0 },
                    { 34, 10, 12, 1, 2.0 },
                    { 35, 10, 12, 2, 8.0 },
                    { 36, 10, 12, 0, 5.0 },
                    { 37, 6, 13, 1, 10.0 },
                    { 38, 6, 13, 2, 10.0 },
                    { 39, 6, 13, 0, 3.0 },
                    { 40, 11, 14, 1, 8.0 },
                    { 41, 11, 14, 2, 9.0 },
                    { 42, 11, 14, 0, 1.0 },
                    { 43, 7, 15, 1, 7.0 },
                    { 44, 7, 15, 2, 4.0 },
                    { 45, 7, 15, 0, 10.0 },
                    { 46, 14, 16, 1, 8.0 },
                    { 47, 14, 16, 2, 0.0 },
                    { 48, 14, 16, 0, 10.0 },
                    { 49, 1, 17, 1, 8.0 },
                    { 50, 1, 17, 2, 9.0 },
                    { 51, 1, 17, 0, 8.0 },
                    { 52, 15, 18, 1, 5.0 },
                    { 53, 15, 18, 2, 1.0 },
                    { 54, 15, 18, 0, 8.0 },
                    { 55, 3, 19, 1, 10.0 },
                    { 56, 3, 19, 2, 1.0 },
                    { 57, 3, 19, 0, 9.0 },
                    { 58, 2, 20, 1, 4.0 },
                    { 59, 2, 20, 2, 5.0 },
                    { 60, 2, 20, 0, 5.0 },
                    { 61, 20, 21, 1, 10.0 },
                    { 62, 20, 21, 2, 2.0 },
                    { 63, 20, 21, 0, 8.0 },
                    { 64, 4, 22, 1, 2.0 },
                    { 65, 4, 22, 2, 7.0 },
                    { 66, 4, 22, 0, 5.0 },
                    { 67, 3, 23, 1, 9.0 },
                    { 68, 3, 23, 2, 8.0 },
                    { 69, 3, 23, 0, 6.0 },
                    { 70, 13, 24, 1, 3.0 },
                    { 71, 13, 24, 2, 7.0 },
                    { 72, 13, 24, 0, 1.0 },
                    { 73, 15, 25, 1, 8.0 },
                    { 74, 15, 25, 2, 9.0 },
                    { 75, 15, 25, 0, 10.0 },
                    { 76, 7, 26, 1, 6.0 },
                    { 77, 7, 26, 2, 10.0 },
                    { 78, 7, 26, 0, 3.0 },
                    { 79, 9, 27, 1, 6.0 },
                    { 80, 9, 27, 2, 9.0 },
                    { 81, 9, 27, 0, 10.0 },
                    { 82, 19, 28, 1, 2.0 },
                    { 83, 19, 28, 2, 6.0 },
                    { 84, 19, 28, 0, 7.0 },
                    { 85, 2, 29, 1, 1.0 },
                    { 86, 2, 29, 2, 9.0 },
                    { 87, 2, 29, 0, 6.0 },
                    { 88, 7, 30, 1, 8.0 },
                    { 89, 7, 30, 2, 3.0 },
                    { 90, 7, 30, 0, 7.0 },
                    { 91, 6, 31, 1, 6.0 },
                    { 92, 6, 31, 2, 5.0 },
                    { 93, 6, 31, 0, 10.0 },
                    { 94, 8, 32, 1, 9.0 },
                    { 95, 8, 32, 2, 8.0 },
                    { 96, 8, 32, 0, 6.0 },
                    { 97, 11, 33, 1, 3.0 },
                    { 98, 11, 33, 2, 10.0 },
                    { 99, 11, 33, 0, 8.0 },
                    { 100, 4, 34, 1, 9.0 },
                    { 101, 4, 34, 2, 9.0 },
                    { 102, 4, 34, 0, 3.0 },
                    { 103, 15, 35, 1, 4.0 },
                    { 104, 15, 35, 2, 5.0 },
                    { 105, 15, 35, 0, 1.0 },
                    { 106, 5, 36, 1, 7.0 },
                    { 107, 5, 36, 2, 8.0 },
                    { 108, 5, 36, 0, 2.0 },
                    { 109, 2, 37, 1, 8.0 },
                    { 110, 2, 37, 2, 3.0 },
                    { 111, 2, 37, 0, 2.0 },
                    { 112, 11, 38, 1, 6.0 },
                    { 113, 11, 38, 2, 9.0 },
                    { 114, 11, 38, 0, 7.0 },
                    { 115, 12, 39, 1, 10.0 },
                    { 116, 12, 39, 2, 8.0 },
                    { 117, 12, 39, 0, 7.0 },
                    { 118, 16, 40, 1, 0.0 },
                    { 119, 16, 40, 2, 0.0 },
                    { 120, 16, 40, 0, 8.0 },
                    { 121, 16, 41, 1, 10.0 },
                    { 122, 16, 41, 2, 6.0 },
                    { 123, 16, 41, 0, 9.0 },
                    { 124, 11, 42, 1, 10.0 },
                    { 125, 11, 42, 2, 7.0 },
                    { 126, 11, 42, 0, 6.0 },
                    { 127, 4, 43, 1, 7.0 },
                    { 128, 4, 43, 2, 9.0 },
                    { 129, 4, 43, 0, 1.0 },
                    { 130, 12, 44, 1, 10.0 },
                    { 131, 12, 44, 2, 7.0 },
                    { 132, 12, 44, 0, 5.0 },
                    { 133, 9, 45, 1, 6.0 },
                    { 134, 9, 45, 2, 7.0 },
                    { 135, 9, 45, 0, 10.0 },
                    { 136, 9, 46, 1, 7.0 },
                    { 137, 9, 46, 2, 9.0 },
                    { 138, 9, 46, 0, 1.0 },
                    { 139, 3, 47, 1, 10.0 },
                    { 140, 3, 47, 2, 5.0 },
                    { 141, 3, 47, 0, 5.0 },
                    { 142, 20, 48, 1, 9.0 },
                    { 143, 20, 48, 2, 10.0 },
                    { 144, 20, 48, 0, 10.0 },
                    { 145, 12, 49, 1, 9.0 },
                    { 146, 12, 49, 2, 6.0 },
                    { 147, 12, 49, 0, 7.0 },
                    { 148, 7, 1, 1, 9.0 },
                    { 149, 7, 1, 2, 3.0 },
                    { 150, 7, 1, 0, 0.0 },
                    { 151, 1, 2, 1, 9.0 },
                    { 152, 1, 2, 2, 3.0 },
                    { 153, 1, 2, 0, 9.0 },
                    { 154, 6, 3, 1, 10.0 },
                    { 155, 6, 3, 2, 10.0 },
                    { 156, 6, 3, 0, 3.0 },
                    { 157, 19, 4, 1, 9.0 },
                    { 158, 19, 4, 2, 9.0 },
                    { 159, 19, 4, 0, 8.0 },
                    { 160, 1, 5, 1, 6.0 },
                    { 161, 1, 5, 2, 4.0 },
                    { 162, 1, 5, 0, 9.0 },
                    { 163, 17, 6, 1, 1.0 },
                    { 164, 17, 6, 2, 9.0 },
                    { 165, 17, 6, 0, 6.0 },
                    { 166, 17, 7, 1, 7.0 },
                    { 167, 17, 7, 2, 0.0 },
                    { 168, 17, 7, 0, 2.0 },
                    { 169, 19, 8, 1, 7.0 },
                    { 170, 19, 8, 2, 2.0 },
                    { 171, 19, 8, 0, 9.0 },
                    { 172, 4, 9, 1, 10.0 },
                    { 173, 4, 9, 2, 5.0 },
                    { 174, 4, 9, 0, 10.0 },
                    { 175, 18, 10, 1, 7.0 },
                    { 176, 18, 10, 2, 1.0 },
                    { 177, 18, 10, 0, 7.0 },
                    { 178, 8, 11, 1, 10.0 },
                    { 179, 8, 11, 2, 0.0 },
                    { 180, 8, 11, 0, 1.0 },
                    { 181, 9, 12, 1, 10.0 },
                    { 182, 9, 12, 2, 8.0 },
                    { 183, 9, 12, 0, 6.0 },
                    { 184, 9, 13, 1, 0.0 },
                    { 185, 9, 13, 2, 0.0 },
                    { 186, 9, 13, 0, 4.0 },
                    { 187, 13, 14, 1, 6.0 },
                    { 188, 13, 14, 2, 0.0 },
                    { 189, 13, 14, 0, 8.0 },
                    { 190, 17, 15, 1, 7.0 },
                    { 191, 17, 15, 2, 9.0 },
                    { 192, 17, 15, 0, 4.0 },
                    { 193, 12, 16, 1, 8.0 },
                    { 194, 12, 16, 2, 10.0 },
                    { 195, 12, 16, 0, 1.0 },
                    { 196, 4, 17, 1, 7.0 },
                    { 197, 4, 17, 2, 7.0 },
                    { 198, 4, 17, 0, 7.0 },
                    { 199, 1, 18, 1, 4.0 },
                    { 200, 1, 18, 2, 7.0 },
                    { 201, 1, 18, 0, 6.0 },
                    { 202, 15, 19, 1, 4.0 },
                    { 203, 15, 19, 2, 2.0 },
                    { 204, 15, 19, 0, 0.0 },
                    { 205, 15, 20, 1, 1.0 },
                    { 206, 15, 20, 2, 4.0 },
                    { 207, 15, 20, 0, 8.0 },
                    { 208, 12, 21, 1, 10.0 },
                    { 209, 12, 21, 2, 3.0 },
                    { 210, 12, 21, 0, 9.0 },
                    { 211, 1, 22, 1, 6.0 },
                    { 212, 1, 22, 2, 10.0 },
                    { 213, 1, 22, 0, 9.0 },
                    { 214, 10, 23, 1, 7.0 },
                    { 215, 10, 23, 2, 7.0 },
                    { 216, 10, 23, 0, 7.0 },
                    { 217, 8, 24, 1, 9.0 },
                    { 218, 8, 24, 2, 0.0 },
                    { 219, 8, 24, 0, 8.0 },
                    { 220, 3, 25, 1, 6.0 },
                    { 221, 3, 25, 2, 1.0 },
                    { 222, 3, 25, 0, 10.0 },
                    { 223, 13, 26, 1, 4.0 },
                    { 224, 13, 26, 2, 10.0 },
                    { 225, 13, 26, 0, 4.0 },
                    { 226, 16, 27, 1, 9.0 },
                    { 227, 16, 27, 2, 1.0 },
                    { 228, 16, 27, 0, 6.0 },
                    { 229, 20, 28, 1, 9.0 },
                    { 230, 20, 28, 2, 6.0 },
                    { 231, 20, 28, 0, 9.0 },
                    { 232, 16, 29, 1, 0.0 },
                    { 233, 16, 29, 2, 5.0 },
                    { 234, 16, 29, 0, 3.0 },
                    { 235, 13, 30, 1, 6.0 },
                    { 236, 13, 30, 2, 10.0 },
                    { 237, 13, 30, 0, 6.0 },
                    { 238, 1, 31, 1, 10.0 },
                    { 239, 1, 31, 2, 9.0 },
                    { 240, 1, 31, 0, 7.0 },
                    { 241, 7, 32, 1, 7.0 },
                    { 242, 7, 32, 2, 7.0 },
                    { 243, 7, 32, 0, 8.0 },
                    { 244, 17, 33, 1, 10.0 },
                    { 245, 17, 33, 2, 5.0 },
                    { 246, 17, 33, 0, 10.0 },
                    { 247, 15, 34, 1, 6.0 },
                    { 248, 15, 34, 2, 1.0 },
                    { 249, 15, 34, 0, 2.0 },
                    { 250, 5, 35, 1, 4.0 },
                    { 251, 5, 35, 2, 8.0 },
                    { 252, 5, 35, 0, 7.0 },
                    { 253, 6, 36, 1, 9.0 },
                    { 254, 6, 36, 2, 8.0 },
                    { 255, 6, 36, 0, 6.0 },
                    { 256, 5, 37, 1, 6.0 },
                    { 257, 5, 37, 2, 0.0 },
                    { 258, 5, 37, 0, 2.0 },
                    { 259, 14, 38, 1, 7.0 },
                    { 260, 14, 38, 2, 7.0 },
                    { 261, 14, 38, 0, 2.0 },
                    { 262, 11, 39, 1, 6.0 },
                    { 263, 11, 39, 2, 5.0 },
                    { 264, 11, 39, 0, 7.0 },
                    { 265, 9, 40, 1, 4.0 },
                    { 266, 9, 40, 2, 6.0 },
                    { 267, 9, 40, 0, 9.0 },
                    { 268, 5, 41, 1, 6.0 },
                    { 269, 5, 41, 2, 0.0 },
                    { 270, 5, 41, 0, 2.0 },
                    { 271, 8, 42, 1, 6.0 },
                    { 272, 8, 42, 2, 4.0 },
                    { 273, 8, 42, 0, 1.0 },
                    { 274, 15, 43, 1, 0.0 },
                    { 275, 15, 43, 2, 10.0 },
                    { 276, 15, 43, 0, 4.0 },
                    { 277, 13, 44, 1, 1.0 },
                    { 278, 13, 44, 2, 5.0 },
                    { 279, 13, 44, 0, 10.0 },
                    { 280, 5, 45, 1, 5.0 },
                    { 281, 5, 45, 2, 9.0 },
                    { 282, 5, 45, 0, 0.0 },
                    { 283, 4, 46, 1, 4.0 },
                    { 284, 4, 46, 2, 4.0 },
                    { 285, 4, 46, 0, 8.0 },
                    { 286, 4, 47, 1, 2.0 },
                    { 287, 4, 47, 2, 1.0 },
                    { 288, 4, 47, 0, 8.0 },
                    { 289, 18, 48, 1, 8.0 },
                    { 290, 18, 48, 2, 10.0 },
                    { 291, 18, 48, 0, 9.0 },
                    { 292, 18, 49, 1, 3.0 },
                    { 293, 18, 49, 2, 9.0 },
                    { 294, 18, 49, 0, 7.0 },
                    { 295, 13, 1, 1, 10.0 },
                    { 296, 13, 1, 2, 1.0 },
                    { 297, 13, 1, 0, 6.0 },
                    { 298, 3, 2, 1, 5.0 },
                    { 299, 3, 2, 2, 10.0 },
                    { 300, 3, 2, 0, 9.0 },
                    { 301, 4, 3, 1, 5.0 },
                    { 302, 4, 3, 2, 5.0 },
                    { 303, 4, 3, 0, 0.0 },
                    { 304, 14, 4, 1, 10.0 },
                    { 305, 14, 4, 2, 9.0 },
                    { 306, 14, 4, 0, 9.0 },
                    { 307, 6, 5, 1, 5.0 },
                    { 308, 6, 5, 2, 8.0 },
                    { 309, 6, 5, 0, 9.0 },
                    { 310, 13, 6, 1, 6.0 },
                    { 311, 13, 6, 2, 9.0 },
                    { 312, 13, 6, 0, 10.0 },
                    { 313, 12, 7, 1, 8.0 },
                    { 314, 12, 7, 2, 6.0 },
                    { 315, 12, 7, 0, 8.0 },
                    { 316, 7, 8, 1, 2.0 },
                    { 317, 7, 8, 2, 1.0 },
                    { 318, 7, 8, 0, 1.0 },
                    { 319, 16, 9, 1, 10.0 },
                    { 320, 16, 9, 2, 2.0 },
                    { 321, 16, 9, 0, 5.0 },
                    { 322, 8, 10, 1, 0.0 },
                    { 323, 8, 10, 2, 8.0 },
                    { 324, 8, 10, 0, 6.0 },
                    { 325, 18, 11, 1, 8.0 },
                    { 326, 18, 11, 2, 2.0 },
                    { 327, 18, 11, 0, 6.0 },
                    { 328, 16, 12, 1, 10.0 },
                    { 329, 16, 12, 2, 6.0 },
                    { 330, 16, 12, 0, 8.0 },
                    { 331, 1, 13, 1, 9.0 },
                    { 332, 1, 13, 2, 7.0 },
                    { 333, 1, 13, 0, 10.0 },
                    { 334, 7, 14, 1, 6.0 },
                    { 335, 7, 14, 2, 10.0 },
                    { 336, 7, 14, 0, 9.0 },
                    { 337, 13, 15, 1, 10.0 },
                    { 338, 13, 15, 2, 5.0 },
                    { 339, 13, 15, 0, 6.0 },
                    { 340, 11, 16, 1, 3.0 },
                    { 341, 11, 16, 2, 8.0 },
                    { 342, 11, 16, 0, 3.0 },
                    { 343, 6, 17, 1, 10.0 },
                    { 344, 6, 17, 2, 1.0 },
                    { 345, 6, 17, 0, 0.0 },
                    { 346, 2, 18, 1, 10.0 },
                    { 347, 2, 18, 2, 10.0 },
                    { 348, 2, 18, 0, 7.0 },
                    { 349, 2, 19, 1, 9.0 },
                    { 350, 2, 19, 2, 8.0 },
                    { 351, 2, 19, 0, 10.0 },
                    { 352, 6, 20, 1, 5.0 },
                    { 353, 6, 20, 2, 6.0 },
                    { 354, 6, 20, 0, 8.0 },
                    { 355, 19, 21, 1, 9.0 },
                    { 356, 19, 21, 2, 4.0 },
                    { 357, 19, 21, 0, 7.0 },
                    { 358, 16, 22, 1, 10.0 },
                    { 359, 16, 22, 2, 6.0 },
                    { 360, 16, 22, 0, 6.0 },
                    { 361, 1, 23, 1, 3.0 },
                    { 362, 1, 23, 2, 10.0 },
                    { 363, 1, 23, 0, 7.0 },
                    { 364, 20, 24, 1, 0.0 },
                    { 365, 20, 24, 2, 8.0 },
                    { 366, 20, 24, 0, 8.0 },
                    { 367, 2, 25, 1, 10.0 },
                    { 368, 2, 25, 2, 8.0 },
                    { 369, 2, 25, 0, 6.0 },
                    { 370, 18, 26, 1, 10.0 },
                    { 371, 18, 26, 2, 2.0 },
                    { 372, 18, 26, 0, 7.0 },
                    { 373, 1, 27, 1, 10.0 },
                    { 374, 1, 27, 2, 6.0 },
                    { 375, 1, 27, 0, 5.0 },
                    { 376, 11, 28, 1, 1.0 },
                    { 377, 11, 28, 2, 6.0 },
                    { 378, 11, 28, 0, 7.0 },
                    { 379, 6, 29, 1, 5.0 },
                    { 380, 6, 29, 2, 9.0 },
                    { 381, 6, 29, 0, 7.0 },
                    { 382, 19, 30, 1, 9.0 },
                    { 383, 19, 30, 2, 6.0 },
                    { 384, 19, 30, 0, 8.0 },
                    { 385, 15, 31, 1, 9.0 },
                    { 386, 15, 31, 2, 8.0 },
                    { 387, 15, 31, 0, 0.0 },
                    { 388, 11, 32, 1, 2.0 },
                    { 389, 11, 32, 2, 2.0 },
                    { 390, 11, 32, 0, 6.0 },
                    { 391, 18, 33, 1, 2.0 },
                    { 392, 18, 33, 2, 4.0 },
                    { 393, 18, 33, 0, 9.0 },
                    { 394, 9, 34, 1, 10.0 },
                    { 395, 9, 34, 2, 10.0 },
                    { 396, 9, 34, 0, 2.0 },
                    { 397, 9, 35, 1, 7.0 },
                    { 398, 9, 35, 2, 10.0 },
                    { 399, 9, 35, 0, 9.0 },
                    { 400, 16, 36, 1, 2.0 },
                    { 401, 16, 36, 2, 10.0 },
                    { 402, 16, 36, 0, 8.0 },
                    { 403, 9, 37, 1, 0.0 },
                    { 404, 9, 37, 2, 10.0 },
                    { 405, 9, 37, 0, 5.0 },
                    { 406, 20, 38, 1, 3.0 },
                    { 407, 20, 38, 2, 10.0 },
                    { 408, 20, 38, 0, 4.0 },
                    { 409, 20, 39, 1, 3.0 },
                    { 410, 20, 39, 2, 7.0 },
                    { 411, 20, 39, 0, 9.0 },
                    { 412, 15, 40, 1, 10.0 },
                    { 413, 15, 40, 2, 4.0 },
                    { 414, 15, 40, 0, 8.0 },
                    { 415, 3, 41, 1, 3.0 },
                    { 416, 3, 41, 2, 4.0 },
                    { 417, 3, 41, 0, 9.0 },
                    { 418, 19, 42, 1, 9.0 },
                    { 419, 19, 42, 2, 2.0 },
                    { 420, 19, 42, 0, 10.0 },
                    { 421, 16, 43, 1, 8.0 },
                    { 422, 16, 43, 2, 7.0 },
                    { 423, 16, 43, 0, 6.0 },
                    { 424, 14, 44, 1, 6.0 },
                    { 425, 14, 44, 2, 7.0 },
                    { 426, 14, 44, 0, 9.0 },
                    { 427, 1, 45, 1, 8.0 },
                    { 428, 1, 45, 2, 0.0 },
                    { 429, 1, 45, 0, 6.0 },
                    { 430, 2, 46, 1, 2.0 },
                    { 431, 2, 46, 2, 5.0 },
                    { 432, 2, 46, 0, 6.0 },
                    { 433, 10, 47, 1, 3.0 },
                    { 434, 10, 47, 2, 3.0 },
                    { 435, 10, 47, 0, 9.0 },
                    { 436, 7, 48, 1, 10.0 },
                    { 437, 7, 48, 2, 9.0 },
                    { 438, 7, 48, 0, 7.0 },
                    { 439, 20, 49, 1, 8.0 },
                    { 440, 20, 49, 2, 10.0 },
                    { 441, 20, 49, 0, 8.0 },
                    { 442, 17, 1, 1, 7.0 },
                    { 443, 17, 1, 2, 10.0 },
                    { 444, 17, 1, 0, 10.0 },
                    { 445, 2, 2, 1, 7.0 },
                    { 446, 2, 2, 2, 7.0 },
                    { 447, 2, 2, 0, 0.0 },
                    { 448, 16, 3, 1, 1.0 },
                    { 449, 16, 3, 2, 6.0 },
                    { 450, 16, 3, 0, 6.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.AlterColumn<int>(
                name: "Value",
                table: "Grades",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
