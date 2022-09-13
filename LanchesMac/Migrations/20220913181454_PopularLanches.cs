using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
            "VALUES( 1, 'Pão, hamburguer, ovo, presunto, queijo e batata palha', 'Delicioso pão de hamburguer com ovo frito, prescunto e queijo de primeira qualidade acompanhado com batata palha', 1 , 'https://macoratti.net/imagens/lanches/cheesesalada1.jpg', 'https://macoratti.net/imagens/lanches/cheesesalada1.jpg', 0 , 'Cheese Salada', 12.50)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
            "VALUES( 2, 'Pão, presunto, mussarela e tomate', 'Delicioso pão francês quentinho com um delicioso queijo mussarela derretido', 1 , 'https://macoratti.net/imagens/lanches/mistoquente4.jpg', 'https://macoratti.net/imagens/lanches/mistoquente4.jpg', 0 , 'Misto quente', 9.00)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
            "VALUES( 1, 'Pão, hamburguer, ovo, presunto, queijo e batata palha', 'Delicioso pão de hamburguer com ovo frito, prescunto e queijo de primeira qualidade acompanhado com batata palha', 1 , 'https://macoratti.net/imagens/lanches/cheesesalada1.jpg', 'https://macoratti.net/imagens/lanches/cheesesalada1.jpg', 0 , 'Cheese Salada', 12.50)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
            "VALUES( 2, 'Pão integral, alface, tomate, peito de peru e queijo', 'Maravilhoso lanche natural feito com peito de peru e com pão integral', 1 , 'https://macoratti.net/imagens/lanches/lanchenatural.jpg', 'https://macoratti.net/imagens/lanches/lanchenatural.jpg', 1 , 'Lanche Natural Peito de Peru', 8.50)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE * FROM Lanches");
        }
    }
}
