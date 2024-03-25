using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieApi.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories(Nome) VALUES('Ficção Científica')");
            migrationBuilder.Sql("INSERT INTO Categories(Nome) VALUES('Guerra')"); 
            migrationBuilder.Sql("INSERT INTO Categories(Nome) VALUES('Romance')");
            migrationBuilder.Sql("INSERT INTO Categories(Nome) VALUES('Terror')");
            migrationBuilder.Sql("INSERT INTO Categories(Nome) VALUES('Animação')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categories");
        }
    }
}
