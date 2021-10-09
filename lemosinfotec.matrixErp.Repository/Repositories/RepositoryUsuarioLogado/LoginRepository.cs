using lemosinfotec.matrixErp.Repository.Repositories;
namespace lemosinfotec.matrixErp.Repository.Repositories.RepositoryUsuarioLogado
{
    public class LoginRepository
    {
        AccountRepository login = new AccountRepository();
        public bool Entrar(string user,string pw)
        {
            return login.LoginDescktop(user, pw);
        }
    }
}
