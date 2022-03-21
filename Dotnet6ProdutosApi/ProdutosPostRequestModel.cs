namespace ProdutosApi
  {
  public class ProdutosPostRequestModel
  {
    public string Descricao { get; set; }
    public decimal Custo { get; set; }
    public decimal Preco { get; set; }
    public decimal Estoque { get; set; }
    public string? Foto { get; set; }
    public UnidadeDeMedidaEnum Unidade {get;set;}
  }
}