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
    public class EstoqueRepository:DaoContexto
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mod"></param>
        public async void AddEstoque(Estoque mod)
        {
            try
            {
                OpenConnection();
                string strInsert = string.Format(@"INSERT INTO Estoque VALUES(SYSDATETIME(),@ProdutoId,@Quantidade,@ValorUnit,@TipoProdutoId,@EstoqueMin,@FornecedorId,@EmpresaId)");
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strInsert, con))
                {
                    cmd.Parameters.AddWithValue("@ProdutoId", mod.ProdutoId);
                    cmd.Parameters.AddWithValue("@Quantidade", mod.Quantidade);
                    cmd.Parameters.AddWithValue("@ValorUnit", mod.ValorUnit);
                    cmd.Parameters.AddWithValue("@TipoProdutoId", mod.TipoProdutoId);
                    cmd.Parameters.AddWithValue("@EstoqueMin", mod.EstoqueMin);
                    cmd.Parameters.AddWithValue("@FornecedorId", mod.FornecedorId);
                    cmd.Parameters.AddWithValue("@EmpresaId", mod.EmpresaId);
                  await  cmd.ExecuteNonQueryAsync();
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
        public async Task<IEnumerable<Estoque>> GetEstoque(int Empresaid)
        {
            try
            {
                OpenConnection();
                List<Estoque> lista = new List<Estoque>();
                string strSelect = string.Format(@"SELECT A.EstoqueId, A.DataRegistro,B.ProdutoNome,A.Quantidade,
                                                    A.ValorUnit,A.EstoqueMin,D.FornecedorNome
                                                    FROM Estoque A
                                                    INNER JOIN Produtos B ON A.ProdutoId = B.ProdutoId
                                                    INNER JOIN TipoProdutos C ON A.TipoProdutoId = C.Id
                                                    INNER JOIN Fornecedores D ON A.FornecedorId = D.FornecedorId
                                                    WHERE A.EmpresaId = @EmpresaId
                                                    ORDER BY B.ProdutoNome ASC");
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@EmpresaId", Empresaid);
                    using(Dr = await cmd.ExecuteReaderAsync())
                    {
                        Estoque mod = null;
                        while (await Dr.ReadAsync())
                        {
                            mod = new Estoque();
                            mod.EstoqueId = Convert.ToInt32(Dr[0]);
                            mod.DataRegistro = Convert.ToDateTime(Dr[1]);
                            mod.ProdutoNome = Convert.ToString(Dr[2]);
                            mod.Quantidade = Convert.ToInt32(Dr[3]);
                            mod.ValorUnit = Convert.ToDouble(Dr[4]);
                            mod.EstoqueMin = Convert.ToInt32(Dr[5]);
                            mod.FornecedorNome = Convert.ToString(Dr[6]);
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
        public async Task<IEnumerable<Estoque>> GetEstoque(string ProdutoNome)
        {
            try
            {
                OpenConnection();
                List<Estoque> lista = new List<Estoque>();
                string strSelect = string.Format(@"SELECT A.EstoqueId, A.DataRegistro,B.ProdutoNome,A.Quantidade,
                                                    A.ValorUnit,A.EstoqueMin,D.FornecedorNome
                                                    FROM Estoque A
                                                    INNER JOIN Produtos B ON A.ProdutoId = B.ProdutoId
                                                    INNER JOIN TipoProdutos C ON A.TipoProdutoId = C.Id
                                                    INNER JOIN Fornecedores D ON A.FornecedorId = D.FornecedorId
                                                    WHERE B.ProdutoNome = @produto
                                                    ORDER BY B.ProdutoNome ASC");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@produto", ProdutoNome);
                    using (Dr = await cmd.ExecuteReaderAsync())
                    {
                        Estoque mod = null;
                        while (await Dr.ReadAsync())
                        {
                            mod = new Estoque();
                            mod.EstoqueId = Convert.ToInt32(Dr[0]);
                            mod.DataRegistro = Convert.ToDateTime(Dr[1]);
                            mod.ProdutoNome = Convert.ToString(Dr[2]);
                            mod.Quantidade = Convert.ToInt32(Dr[3]);
                            mod.ValorUnit = Convert.ToDouble(Dr[4]);
                            mod.EstoqueMin = Convert.ToInt32(Dr[5]);
                            mod.FornecedorNome = Convert.ToString(Dr[6]);
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
        public async Task<IEnumerable<TipoProdutos>> GetTipos()
        {
            try
            {
                OpenConnection();
                List<TipoProdutos> lista = new List<TipoProdutos>();
                string strSelect = string.Format(@"SELECT Id,Nome FROM TipoProdutos");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    using (Dr = await cmd.ExecuteReaderAsync())
                    {
                        TipoProdutos mod = null;
                        while (await Dr.ReadAsync())
                        {
                            mod = new TipoProdutos();
                            mod.Id = Convert.ToInt32(Dr[0]);
                            mod.Nome = Convert.ToString(Dr[1]);
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
        /// <param name="Id"></param>
        public void ExcluirProduto(int Id)
        {
            try
            {
                OpenConnection();
                string strDelete = string.Format(@"DELETE FROM Estoque WHERE EstoqueId = @id");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strDelete, con))
                {
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ClosedConnection();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ProdutoId"></param>
        /// <returns></returns>
        public async Task<Estoque> CarregarFormulario(string ProdutoNome)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT A.ProdutoId,A.Quantidade,
                            A.ValorUnit,A.TipoProdutoId,
                            A.EstoqueMin,A.FornecedorId 
                            FROM Estoque A
                            INNER JOIN Produtos B ON A.ProdutoId = B.ProdutoId
                            WHERE B.ProdutoNome = @produto");
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@produto", ProdutoNome);
                    using(Dr = await cmd.ExecuteReaderAsync())
                    {
                        Estoque mod = null;
                        while (await Dr.ReadAsync())
                        {
                            mod = new Estoque();
                            mod.ProdutoId = Convert.ToInt32(Dr[0]);
                            mod.Quantidade = Convert.ToInt32(Dr[1]);
                            mod.ValorUnit = Convert.ToDouble(Dr[2]);
                            mod.TipoProdutoId = Convert.ToInt32(Dr[3]);
                            mod.EstoqueMin = Convert.ToInt32(Dr[4]);
                            mod.FornecedorId = Convert.ToInt32(Dr[5]);
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
        public async void AtualizarEstoque(Estoque mod)
        {
            try
            {
                OpenConnection();
                string strUpdate = string.Format(@"UPDATE Estoque SET  DataRegistro = SYSDATETIME(), Quantidade =@quantidade, ValorUnit =@valorUnit, EstoqueMin =@estoqueMin WHERE ProdutoId =@prodId");
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strUpdate, con))
                {
                    cmd.Parameters.AddWithValue("@prodId", mod.ProdutoId);
                    cmd.Parameters.AddWithValue("@quantidade", mod.Quantidade);
                    cmd.Parameters.AddWithValue("@valorUnit", mod.ValorUnit);
                    cmd.Parameters.AddWithValue("@estoqueMin", mod.EstoqueMin);
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
        /// <param name="ProdutoId"></param>
        /// <returns></returns>
        public bool checkEstoque(int ProdutoId)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT ProdutoId FROM Estoque WHERE ProdutoId =@prodId");
                using(cmd =new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@prodId", ProdutoId);
                    using(Dr = cmd.ExecuteReader())
                    {
                        if (Dr.HasRows)
                        {
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
    }
}
