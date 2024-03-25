using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieApi.Migrations
{
    /// <inheritdoc />
    public partial class PopulaFilmes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Movies(Titulo,Diretor,Sinopse,Duracao,CategoryId) VALUES('A Origem','Christopher Nolan','Em A Origem, Dom Cobb é um especialista em roubo de segredos corporativos através do uso de tecnologia de compartilhamento de sonhos.',148,1)");
            migrationBuilder.Sql("INSERT INTO Movies(Titulo,Diretor,Sinopse,Duracao,CategoryId) VALUES('Resgate do Soldado Ryan','Steve Spielberg','Durante a Segunda Guerra Mundial, um grupo de soldados americanos é enviado para trás das linhas inimigas para resgatar um soldado para casa depois que seus três irmãos são mortos em combate.',169,2)");
            migrationBuilder.Sql("INSERT INTO Movies(Titulo,Diretor,Sinopse,Duracao,CategoryId) VALUES('Diário de uma Paixão','Nick Cassavetes','o filme conta a história de um casal apaixonado, Noah e Allie, que são separados pelo destino e pelas circunstâncias sociais.',149,3)");
            migrationBuilder.Sql("INSERT INTO Movies(Titulo,Diretor,Sinopse,Duracao,CategoryId) VALUES('O Iluminado','Stanley Kubrick','O filme segue a história de Jack Torrance, um escritor e alcoólatra que aceita um emprego como zelador de um hotel isolado nas montanhas.',144,4)");
            migrationBuilder.Sql("INSERT INTO Movies(Titulo,Diretor,Sinopse,Duracao,CategoryId) VALUES('Toy Story','John Lasseter',' primeiro filme da trilogia Toy Story segue a vida de brinquedos que ganham vida quando seus donos não estão por perto.',81,5)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Movies");
        }
    }
}
