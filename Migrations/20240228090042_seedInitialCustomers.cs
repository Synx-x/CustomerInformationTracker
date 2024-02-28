using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CustomerInformationTracker.Migrations
{
    /// <inheritdoc />
    public partial class seedInitialCustomers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "ContactPersonEmailAddress", "ContactPersonName", "Name", "TelephoneNumber", "VATNumber" },
                values: new object[,]
                {
                    { -20, "20 Main Rd, Pietermaritzburg", "sibusiso@arksoft.co.za", "Contact Sibusiso", "Sibusiso", "(27) 0120-0020", "VAT0020" },
                    { -19, "19 Main Rd, Polokwane", "bongani@arksoft.co.za", "Contact Bongani", "Bongani", "(27) 0119-0019", "VAT0019" },
                    { -18, "18 Main Rd, Kimberley", "nomzamo@arksoft.co.za", "Contact Nomzamo", "Nomzamo", "(27) 0118-0018", "VAT0018" },
                    { -17, "17 Main Rd, Nelspruit", "senzo@arksoft.co.za", "Contact Senzo", "Senzo", "(27) 0117-0017", "VAT0017" },
                    { -16, "16 Main Rd, Bloemfontein", "siya@arksoft.co.za", "Contact Siya", "Siya", "(27) 0116-0016", "VAT0016" },
                    { -15, "15 Main Rd, Port Elizabeth", "lindiwe@arksoft.co.za", "Contact Lindiwe", "Lindiwe", "(27) 0115-0015", "VAT0015" },
                    { -14, "14 Main Rd, East London", "thandiwe@arksoft.co.za", "Contact Thandiwe", "Thandiwe", "(27) 0114-0014", "VAT0014" },
                    { -13, "13 Main Rd, Durban", "ayanda@arksoft.co.za", "Contact Ayanda", "Ayanda", "(27) 0113-0013", "VAT0013" },
                    { -12, "12 Main Rd, Cape Town", "fikile@arksoft.co.za", "Contact Fikile", "Fikile", "(27) 0112-0012", "VAT0012" },
                    { -11, "11 Main Rd, Johannesburg", "nandi@arksoft.co.za", "Contact Nandi", "Nandi", "(27) 0111-0011", "VAT0011" },
                    { -10, "10 Main Rd, Pietermaritzburg", "themba@arksoft.co.za", "Contact Themba", "Themba", "(27) 0110-0010", "VAT0010" },
                    { -9, "9 Main Rd, Polokwane", "siyanda@arksoft.co.za", "Contact Siyanda", "Siyanda", "(27) 0109-0009", "VAT009" },
                    { -8, "8 Main Rd, Kimberley", "amandla@arksoft.co.za", "Contact Amandla", "Amandla", "(27) 0108-0008", "VAT008" },
                    { -7, "7 Main Rd, Nelspruit", "mpho@arksoft.co.za", "Contact Mpho", "Mpho", "(27) 0107-0007", "VAT007" },
                    { -6, "6 Main Rd, Bloemfontein", "kagiso@arksoft.co.za", "Contact Kagiso", "Kagiso", "(27) 0106-0006", "VAT006" },
                    { -5, "5 Main Rd, Port Elizabeth", "tumi@arksoft.co.za", "Contact Tumi", "Tumi", "(27) 0105-0005", "VAT005" },
                    { -4, "4 Main Rd, East London", "lerato@arksoft.co.za", "Contact Lerato", "Lerato", "(27) 0104-0004", "VAT004" },
                    { -3, "3 Main Rd, Durban", "naledi@arksoft.co.za", "Contact Naledi", "Naledi", "(27) 0103-0003", "VAT003" },
                    { -2, "2 Main Rd, Cape Town", "thabo@arksoft.co.za", "Contact Thabo", "Thabo", "(27) 0102-0002", "VAT002" },
                    { -1, "1 Main Rd, Johannesburg", "sipho@arksoft.co.za", "Contact Sipho", "Sipho", "(27) 0101-0001", "VAT001" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
