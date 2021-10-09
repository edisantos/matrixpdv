using lemosinfotec.matrixerp.Domain.Entities;
using lemosinfotec.matrixErp.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemosinfotec.matrixErp.Repository.Repositories
{
    public class FornecedoresRepository:DaoContexto
    {

        public async Task<IEnumerable<Fornecedores>> GetFornecedores()
        {
            try
            {
                OpenConnection();
                List<Fornecedores> lista = new List<Fornecedores>();
                string strSelect = string.Format(@"SELECT FornecedorId,FornecedorNome FROM Fornecedores");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    using (Dr = await cmd.ExecuteReaderAsync())
                    {
                        Fornecedores mod = null;
                        while (await Dr.ReadAsync())
                        {
                            mod = new Fornecedores();
                            mod.FornecedorId = Convert.ToInt32(Dr[0]);
                            mod.FornecedorNome = Convert.ToString(Dr[1]);
                           
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
        public async Task RegistrarFornecedor(Fornecedores mod)
        {
            try
            {
                OpenConnection();
                string strInsert = string.Format(@"INSERT INTO Fornecedores VALUES(@FornecedorNome,@Cnpj,@Endereco,@Numero,@Cep,@Cidade,@Estado,@Telefone,@Celular,NUll,@EmpresaId)");
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strInsert, con))
                {
                    cmd.Parameters.AddWithValue("@FornecedorNome", mod.FornecedorNome.ToUpper());
                    cmd.Parameters.AddWithValue("@Cnpj",mod.Cnpj.ToUpper());
                    cmd.Parameters.AddWithValue("@Endereco",mod.Endereco.ToUpper());
                    cmd.Parameters.AddWithValue("@Numero", mod.Numero);
                    cmd.Parameters.AddWithValue("@Cep", mod.Cep.ToUpper());
                    cmd.Parameters.AddWithValue("@Cidade", mod.Cidade.ToUpper());
                    cmd.Parameters.AddWithValue("@Estado", mod.Estado.ToUpper());
                    cmd.Parameters.AddWithValue("@Telefone", mod.Telefone);
                    cmd.Parameters.AddWithValue("@Celular", mod.Celular);
                    cmd.Parameters.AddWithValue("@EmpresaId", mod.EmpresaId);
                   await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception ex)
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
        public async Task<IEnumerable<Fornecedores>> GetListaFornecedores(string EmpresaId)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT FornecedorId,FornecedorNome,
                                                   Cnpj,Endereco,Numero,Cep,Cidade,Estado,Telefone,Celular
                                                   FROM Fornecedores WHERE EmpresaId = @EmpresaId");
                List<Fornecedores> lista = new List<Fornecedores>();
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@EmpresaId", EmpresaId);
                   using(Dr = await cmd.ExecuteReaderAsync())
                    {
                        Fornecedores mod = null;
                        while (await Dr.ReadAsync())
                        {
                            mod = new Fornecedores();
                            mod.FornecedorId = Convert.ToInt32(Dr[0]);
                            mod.FornecedorNome = Convert.ToString(Dr[1]);
                            mod.Cnpj = Convert.ToString(Dr[2]);
                            mod.Endereco = Convert.ToString(Dr[3]);
                            mod.Numero = Convert.ToInt32(Dr[4]);
                            mod.Cep = Convert.ToString(Dr[5]);
                            mod.Cidade = Convert.ToString(Dr[6]);
                            mod.Estado = Convert.ToString(Dr[7]);
                            mod.Telefone = Convert.ToString(Dr[8]);
                            mod.Celular = Convert.ToString(Dr[9]);
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
        public async Task<IEnumerable<Fornecedores>> GetListaFornecedores(int EmpresaId)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT FornecedorId,FornecedorNome,
                                                   Cnpj,Endereco,Numero,Cep,Cidade,Estado,Telefone,Celular
                                                   FROM Fornecedores WHERE EmpresaId = @EmpresaId");
                List<Fornecedores> lista = new List<Fornecedores>();
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@EmpresaId", EmpresaId);
                   using (Dr = await cmd.ExecuteReaderAsync())
                    {
                        Fornecedores mod = null;
                        while (await Dr.ReadAsync())
                        {
                            mod = new Fornecedores();
                            mod.FornecedorId = Convert.ToInt32(Dr[0]);
                            mod.FornecedorNome = Convert.ToString(Dr[1]);
                            mod.Cnpj = Convert.ToString(Dr[2]);
                            mod.Endereco = Convert.ToString(Dr[3]);
                            mod.Numero = Convert.ToInt32(Dr[4]);
                            mod.Cep = Convert.ToString(Dr[5]);
                            mod.Cidade = Convert.ToString(Dr[6]);
                            mod.Estado = Convert.ToString(Dr[7]);
                            mod.Telefone = Convert.ToString(Dr[8]);
                            mod.Celular = Convert.ToString(Dr[9]);
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
        /// <param name="FornecedorId"></param>
        /// <returns></returns>
        public async Task<Fornecedores> GetFornecedoresById(int FornecedorId)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT FornecedorId,FornecedorNome,
                                                   Cnpj,Endereco,Numero,Cep,Cidade,Estado,Telefone,Celular
                                                   FROM Fornecedores WHERE FornecedorId = @Nome");
               
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", FornecedorId);
                    using (Dr = await cmd.ExecuteReaderAsync())
                    {
                        Fornecedores mod = null;
                        while (await Dr.ReadAsync())
                        {
                            mod = new Fornecedores();
                            mod.FornecedorId = Convert.ToInt32(Dr[0]);
                            mod.FornecedorNome = Convert.ToString(Dr[1]);
                            mod.Cnpj = Convert.ToString(Dr[2]);
                            mod.Endereco = Convert.ToString(Dr[3]);
                            mod.Numero = Convert.ToInt32(Dr[4]);
                            mod.Cep = Convert.ToString(Dr[5]);
                            mod.Cidade = Convert.ToString(Dr[6]);
                            mod.Estado = Convert.ToString(Dr[7]);
                            mod.Telefone = Convert.ToString(Dr[8]);
                            mod.Celular = Convert.ToString(Dr[9]);
                           
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
        /// <param name="Id"></param>
        public void ExcluirFornecedor(int Id)
        {
            try
            {
                OpenConnection();
                string strDelete = string.Format(@"DELETE FROM Fornecedores WHERE FornecedorId = @Id");
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strDelete, con))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
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
        public async void AlterarDadosFornecedor(Fornecedores mod)
        {
            try
            {
                OpenConnection();
                string strUpdate = string.Format(@"UPDATE Fornecedores SET FornecedorNome = @FornecedorNome,
                                                    Cnpj = @Cnpj,Endereco = @Endereco, Numero = @Numero,
                                                    Cep = @Cep,Cidade = @Cidade, Estado = @Estado,Telefone = @Telefone,
                                                    Celular = @Celular
                                                    WHERE FornecedorId = @Id");
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strUpdate, con))
                {
                    cmd.Parameters.AddWithValue("@Id", mod.FornecedorId);
                    cmd.Parameters.AddWithValue("@FornecedorNome", mod.FornecedorNome);
                    cmd.Parameters.AddWithValue("@Cnpj", mod.Cep);
                    cmd.Parameters.AddWithValue("@Endereco", mod.Endereco);
                    cmd.Parameters.AddWithValue("@Numero", mod.Numero);
                    cmd.Parameters.AddWithValue("@Cep", mod.Cep);
                    cmd.Parameters.AddWithValue("@Cidade", mod.Cidade);
                    cmd.Parameters.AddWithValue("@Estado", mod.Estado);
                    cmd.Parameters.AddWithValue("@Telefone", mod.Telefone);
                    cmd.Parameters.AddWithValue("@Celular", mod.Celular);
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
    }
}
