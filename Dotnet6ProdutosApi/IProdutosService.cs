namespace ProdutosApi
{
  public interface IProdutosService
  {
     ICollection<ProdutosModel> GetAll();
     ProdutosModel GetOne(int id);

     ProdutosModel Inserir(ProdutosPostRequestModel request );
  }
}