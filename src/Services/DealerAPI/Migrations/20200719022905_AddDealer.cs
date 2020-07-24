using Microsoft.EntityFrameworkCore.Migrations;

namespace DealerAPI.Migrations
{
    public partial class AddDealer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dealer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TradingName = table.Column<string>(nullable: false),
                    CompanyName = table.Column<string>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    Cnpj = table.Column<string>(nullable: false),
                    Cep = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    AddressNumber = table.Column<int>(nullable: false),
                    AddressComplement = table.Column<string>(maxLength: 100, nullable: false),
                    District = table.Column<string>(nullable: false),
                    Uf = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    OwnerName = table.Column<string>(nullable: false),
                    OwnerCpf = table.Column<string>(nullable: false),
                    DealerEmail = table.Column<string>(nullable: false),
                    DealerWebsite = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealer", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dealer");
        }
    }
}
