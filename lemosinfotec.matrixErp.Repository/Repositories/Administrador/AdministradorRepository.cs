using lemosinfotec.matrixerp.Domain.Entities;
using lemosinfotec.matrixErp.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemosinfotec.matrixErp.Repository.Repositories.Administrador
{
    public class AdministradorRepository : DaoContexto
    {

        public async Task<IEnumerable<Administradores>> GetContaUsuarios()
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT A.Id,A.DataCadastro,A.Nome,A.SobreNome,A.Email,
                                                A.Endereco,A.Numero,A.Cidade,A.Estado,C.EmpresaNome,
                                                A.Ativo,A.DataVencimento,A.DiaVencimento,
                                                B.UserName,E.Name As Permissoes
                                                FROM Usuarios A
                                                INNER JOIN Login B ON A.Id = B.UsuarioId
                                                INNER JOIN Empresas C ON A.EmpresaId = C.EmpresaId
                                                INNER JOIN Permissoes D ON A.Id = D.UsuarioId
                                                INNER JOIN AspNetRoles E ON D.RoleId = E.Id");
                List<Administradores> lista = new List<Administradores>();
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    using (Dr = await cmd.ExecuteReaderAsync())
                    {
                        Administradores mod = null;
                        while (await Dr.ReadAsync())
                        {
                            mod = new Administradores();
                            mod.Id = Convert.ToInt32(Dr[0]);
                            mod.DataCadastro = Convert.ToDateTime(Dr[1]);
                            mod.Nome = Convert.ToString(Dr[2]);
                            mod.SobreNome = Convert.ToString(Dr[3]);
                            mod.Email = Convert.ToString(Dr[4]);
                            mod.Endereco = Convert.ToString(Dr[5]);
                            mod.Numero = Convert.ToInt32(Dr[6]);
                            mod.Cidade = Convert.ToString(Dr[7]);
                            mod.Estado = Convert.ToString(Dr[8]);
                            mod.EmpresaNome = Convert.ToString(Dr[9]);
                            mod.Ativo = Convert.ToBoolean(Dr[10]);
                            mod.DataVencimento = Convert.ToDateTime(Dr[11]);
                            mod.DiaVencimento = Convert.ToInt32(Dr[12]);
                            mod.UserName = Convert.ToString(Dr[13]);
                            mod.Permissoes = Convert.ToString(Dr[14]);
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
    }
}
