using lemosinfotec.matrixerp.Domain.Entities;
using lemosinfotec.matrixErp.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace lemosinfotec.matrixErp.Repository.Repositories
{
    public class AccountRepository:DaoContexto
    {
       
        public bool GetLogin(string UserName, string Password)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT B.Nome,B.Email,B.Ativo,B.EmpresaId FROM Login A
                                                        INNER JOIN Usuarios B ON A.UsuarioId = B.Id
                                                        WHERE A.UserName = @User AND A.Password = @pw AND B.Ativo = 1");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@user", UserName);
                    cmd.Parameters.AddWithValue("pw", Password);
                    using (Dr = cmd.ExecuteReader())
                    {
                        if (Dr.HasRows)
                        {
                            Usuarios mod = null;
                            while (Dr.Read())
                            {
                                mod = new Usuarios();
                                mod.Nome = Convert.ToString(Dr[0]);
                                mod.Email = Convert.ToString(Dr[1]);
                                mod.EmpresaId = Convert.ToInt32(Dr[2]);

                            }
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        
                    }
                  
                }
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                ClosedConnection();
            }
        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public bool LoginDescktop(string UserName, string Password)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT B.Id,B.Nome,B.Email,B.Ativo,B.EmpresaId FROM Login A
                                                        INNER JOIN Usuarios B ON A.UsuarioId = B.Id
                                                        WHERE A.UserName = @User AND A.Password = @pw AND B.Ativo = 1");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@user", UserName);
                    cmd.Parameters.AddWithValue("pw", Password);
                    using (Dr = cmd.ExecuteReader())
                    {
                        if (Dr.HasRows)
                        {
                            while (Dr.Read())
                            {
                                UserLoginCache.Id = Dr.GetInt32(0);
                                UserLoginCache.Nome = Dr.GetString(1);
                                UserLoginCache.Email = Dr.GetString(2);
                                UserLoginCache.Ativo = Dr.GetBoolean(3);
                                UserLoginCache.EmpresaId = Dr.GetInt32(4);
                            }
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }

                }
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                ClosedConnection();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Permissoes CheckRole(int Usuarioid)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT RoleId FROM Permissoes WHERE UsuarioId = @Id");
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@Id", Usuarioid);
                    using(Dr = cmd.ExecuteReader())
                    {
                        Permissoes mod = null;
                        while (Dr.Read())
                        {
                            mod = new Permissoes();
                            mod.RoleId = Convert.ToInt32(Dr[0]);
                        }
                        return mod;
                    }
                }
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                ClosedConnection();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task RegistrarUsuarios(Usuarios mod)
        {
            try
            {
                OpenConnection();
                string strInsert = string.Format(@"INSERT INTO Usuarios VALUES(SYSDATETIME(),NULL,@Nome,@SobreNome,@Email,@Endereco,@Numero,@Cidade,@Estado,@EmpresaId,1,@DataVencimento,@DiaVencimento)");
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strInsert, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", mod.Nome.ToUpper());
                    cmd.Parameters.AddWithValue("@SobreNome", mod.SobreNome.ToUpper());
                    cmd.Parameters.AddWithValue("@Email", mod.Email);
                    cmd.Parameters.AddWithValue("@Endereco", mod.Endereco.ToUpper());
                    cmd.Parameters.AddWithValue("@Numero", mod.Numero);
                    cmd.Parameters.AddWithValue("@Cidade", mod.Cidade.ToUpper());
                    cmd.Parameters.AddWithValue("@Estado", mod.Estado.ToUpper());
                    cmd.Parameters.AddWithValue("@EmpresaId", mod.EmpresaId);
                    cmd.Parameters.AddWithValue("@DataVencimento", mod.DataVencimento);
                    cmd.Parameters.AddWithValue("@DiaVencimento", mod.DiaVencimento);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            finally{
                ClosedConnection();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Usuarios>> GetUsuarios()
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT Id,Nome +' '+ SobreNome As NomeCompleto FROM Usuarios");
                List<Usuarios> lista = new List<Usuarios>();
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    using(Dr = await cmd.ExecuteReaderAsync())
                    {
                        Usuarios mod = null;
                        while (Dr.Read())
                        {
                            mod = new Usuarios();
                            mod.Id = Convert.ToInt32(Dr[0]);
                            mod.NomeCompleto = Convert.ToString(Dr[1]);
                            lista.Add(mod);
                        }
                        return lista;
                    }
                }
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                ClosedConnection();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Roles>> GetRoles()
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT Id,Name FROM AspNetRoles");
                List<Roles> lista = new List<Roles>();
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    using (Dr = await cmd.ExecuteReaderAsync())
                    {
                        Roles mod = null;
                        while (Dr.Read())
                        {
                            mod = new Roles();
                            mod.Id = Convert.ToInt32(Dr[0]);
                            mod.Name = Convert.ToString(Dr[1]);
                            lista.Add(mod);
                        }
                        return lista;
                    }
                }
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                ClosedConnection();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public async Task RegistrarLogin(LoginModel login)
        {
            try
            {
                OpenConnection();
                string strInsert = string.Format(@"INSERT INTO Login VALUES(@UserName,@Password,@UsuarioId)");
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strInsert, con))
                {
                    cmd.Parameters.AddWithValue("@UserName", login.UserName);
                    cmd.Parameters.AddWithValue("@Password", login.Password);
                    cmd.Parameters.AddWithValue("@UsuarioId", login.UsuarioId);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                ClosedConnection();
            }
        }

        public async Task RegistrarPermissoes(Permissoes permissoes)
        {
            try
            {
                OpenConnection();
                string strInsert = string.Format(@"INSERT INTO Permissoes VALUES(@UsuarioId,@RoleId)");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strInsert, con))
                {
                    cmd.Parameters.AddWithValue("@UsuarioId", permissoes.UsuarioId);
                    cmd.Parameters.AddWithValue("@RoleId", permissoes.RoleId);
                   
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                ClosedConnection();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Usuarios GetUsuarioById(int Id)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT Id, Nome,EmpresaId FROM Usuarios WHERE Id = @Id");
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    using(Dr = cmd.ExecuteReader())
                    {
                        Usuarios mod = null;
                        while (Dr.Read())
                        {
                            mod = new Usuarios();
                            mod.Id = Convert.ToInt32(Dr[0]);
                            mod.Nome = Convert.ToString(Dr[1]);
                            mod.EmpresaId = Convert.ToInt32(Dr[2]);
                        }
                        return mod;
                    }
                }

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                ClosedConnection();
            }
        }
    }
}
