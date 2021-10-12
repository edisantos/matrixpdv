using lemosinfotec.matrixerp.Domain.Entities;
using lemosinfotec.matrixErp.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace lemosinfotec.matrixErp.Repository.Repositories
{
    public class ProdtutosRepository:DaoContexto
    {

        public async Task AddNovoProdutos(Produtos mod)
        {
            try
            {
                OpenConnection();
                string strInsert = string.Format(@"INSERT INTO Produtos VALUES(@ProdutoNome,@CodeBarra,NULL,@EmpresaId)");
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strInsert,con))
                {
                    var codebarra = Guid.NewGuid().ToString();
                    cmd.Parameters.AddWithValue("@ProdutoNome", mod.ProdutoNome);
                    cmd.Parameters.AddWithValue("CodeBarra", codebarra);
                    cmd.Parameters.AddWithValue("@EmpresaId", mod.EmpresaId);
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
        public async Task<List<Produtos>> GetProdutos(int EmpresaId)
        {
            try
            {
                OpenConnection();
                List<Produtos> lista = new List<Produtos>();
                string strSelect = string.Format(@"SELECT ProdutoId,ProdutoNome 
                                                    FROM Produtos WHERE EmpresaId = @EmpresaId
                                                    ORDER BY ProdutoId Desc");
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@EmpresaId", EmpresaId);
                   using(Dr = await cmd.ExecuteReaderAsync())
                    {
                        Produtos mod = null;
                        while (await Dr.ReadAsync())
                        {
                            mod = new Produtos();
                            mod.ProdutoId = Convert.ToInt32(Dr[0]);
                            mod.ProdutoNome = Convert.ToString(Dr[1]);
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
        public int Contador(int EmpresaId)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT COUNT(ProdutoId) As Total 
                                                   FROM Produtos WHERE EmpresaId = @EmpresaId");
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@EmpresaId", EmpresaId);
                    using(Dr = cmd.ExecuteReader())
                    {
                        Produtos mod = null;
                        while (Dr.Read())
                        {
                            mod = new Produtos();
                            mod.Total = Convert.ToInt32(Dr[0]);
                        }
                        return mod.Total;
                    }
                }
            }
            catch (Exception ex)
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
        public int Contador(string ProdutoNome)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT COUNT(ProdutoId) As Total FROM Produtos WHERE ProdutoNome = @produto");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@produto", ProdutoNome);
                    using (Dr = cmd.ExecuteReader())
                    {
                        Produtos mod = null;
                        while (Dr.Read())
                        {
                            mod = new Produtos();
                            mod.Total = Convert.ToInt32(Dr[0]);
                        }
                        return mod.Total;
                    }
                }
            }
            catch (Exception ex)
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
        /// <param name="ProdutoNome"></param>
        /// <returns></returns>
        public bool CheckProdutos(string  ProdutoNome)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT ProdutoId,ProdutoNome FROM Produtos WHERE ProdutoNome = @produto");
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@produto", ProdutoNome);
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
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<List<Produtos>> GetProdutosPorItem(string ProdutoNome)
        {
            try
            {
                OpenConnection();
                List<Produtos> lista = new List<Produtos>();
                string strSelect = string.Format(@"SELECT ProdutoId,ProdutoNome FROM Produtos WHERE ProdutoNome = @produto");
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@produto", ProdutoNome);
                    using(Dr = await cmd.ExecuteReaderAsync())
                    {
                        Produtos mod = null;
                        while (await Dr.ReadAsync())
                        {
                            mod = new Produtos();
                            mod.ProdutoId = Convert.ToInt32(Dr[0]);
                            mod.ProdutoNome = Convert.ToString(Dr[1]);
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
