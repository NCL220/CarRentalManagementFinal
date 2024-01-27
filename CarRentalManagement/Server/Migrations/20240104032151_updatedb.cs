using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class updatedb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51374408-78ae-4636-b319-d71529f3ed16", "AQAAAAIAAYagAAAAEAFkjpU5CpvcTvOp4UiKNX9D3XuSvo84cd0yHNEatbtkLOwjb6iHqBLn/I32Vb0QTA==", "bae813e1-cc0c-4b4c-8798-148b8f03dfdb" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 11, 21, 51, 580, DateTimeKind.Local).AddTicks(4199), new DateTime(2024, 1, 4, 11, 21, 51, 580, DateTimeKind.Local).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 11, 21, 51, 580, DateTimeKind.Local).AddTicks(4210), new DateTime(2024, 1, 4, 11, 21, 51, 580, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 11, 21, 51, 580, DateTimeKind.Local).AddTicks(4514), new DateTime(2024, 1, 4, 11, 21, 51, 580, DateTimeKind.Local).AddTicks(4515) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 11, 21, 51, 580, DateTimeKind.Local).AddTicks(4517), new DateTime(2024, 1, 4, 11, 21, 51, 580, DateTimeKind.Local).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 11, 21, 51, 580, DateTimeKind.Local).AddTicks(4706), new DateTime(2024, 1, 4, 11, 21, 51, 580, DateTimeKind.Local).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 11, 21, 51, 580, DateTimeKind.Local).AddTicks(4708), new DateTime(2024, 1, 4, 11, 21, 51, 580, DateTimeKind.Local).AddTicks(4709) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 11, 21, 51, 580, DateTimeKind.Local).AddTicks(4710), new DateTime(2024, 1, 4, 11, 21, 51, 580, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 11, 21, 51, 580, DateTimeKind.Local).AddTicks(4711), new DateTime(2024, 1, 4, 11, 21, 51, 580, DateTimeKind.Local).AddTicks(4711) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a97bcb6d-e062-43de-8c0e-db7d6279eaaa", "AQAAAAIAAYagAAAAELGcMFMoNBUf/1R0kaP6Iu5IzPsLi2YMPonTEFr4bHoaEvtZXHld8KWazPZmfejreA==", "57d9b115-c063-4840-9c53-420d8fae160c" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4255), new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4270), new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4561), new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4563), new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4564) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4735), new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4735) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4737), new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4737) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4738), new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4739) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4740), new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4740) });
        }
    }
}
