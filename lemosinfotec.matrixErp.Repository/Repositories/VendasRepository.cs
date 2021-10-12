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
    public class VendasRepository : DaoContexto
    {
        public Estoque GetValorUnit(int? ProdutoId, int EmpresaId)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT ValorUnit FROM Estoque
                                                   WHERE ProdutoId = @ProdutoId AND EmpresaId = @EmpresaId");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@ProdutoId", ProdutoId);
                    cmd.Parameters.AddWithValue("@EmpresaId", EmpresaId);
                    using (Dr = cmd.ExecuteReader())
                    {
                        Estoque mod = null;
                        while (Dr.Read())
                        {
                            mod = new Estoque();
                            if (!string.IsNullOrEmpty(Convert.ToString(mod.ValorUnit)))
                            {
                                mod.ValorUnit = Convert.ToDouble(Dr[0]);
                            }
                            else
                            {
                                mod.ValorUnit = 0;
                            }

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
        /// <param name="mod"></param>
        public void AbrirCaixa(CaixaVendasBase mod)
        {
            try
            {
                OpenConnection();
                string strInsert = string.Format(@"INSERT INTO CaixaVendasBase VALUES(SYSDATETIME(),NULL,NULL,NULL,NULL,@CaixaId,0,@EmpresaId)");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strInsert, con))
                {

                    cmd.Parameters.AddWithValue("@CaixaId", mod.CaixaId);
                    cmd.Parameters.AddWithValue("@EmpresaId", mod.EmpresaId);
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
        public void RegistrarVendas(Vendas vendas)
        {
            try
            {
                OpenConnection();
                string strInsert = string.Format(@"INSERT INTO Vendas VALUES(SYSDATETIME(),@ProdutoId,@TotalItem,NULL,NULL,1,@OperadorId,@VendasBaseId,@EmpresaId)");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strInsert, con))
                {
                    cmd.Parameters.AddWithValue("@ProdutoId", vendas.ProdutoId);
                    cmd.Parameters.AddWithValue("@TotalItem", vendas.TotalItem);
                    cmd.Parameters.AddWithValue("@OperadorId", vendas.OperadorId);
                    cmd.Parameters.AddWithValue("@VendasBaseId", vendas.VendasBaseId);
                    cmd.Parameters.AddWithValue("@EmpresaId", vendas.EmpresaId);
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
        /// <returns></returns>
        public async Task<IEnumerable<Vendas>> GetVendas(int CaixaId, int EmpresaId)
        {
            try
            {
                OpenConnection();
                List<Vendas> lista = new List<Vendas>();
                string strSelect = string.Format(@"SELECT A.Id,B.ProdutoNome,A.ValorVenda,A.Peso, A.TotalItem FROM Vendas A
                                                    INNER JOIN Produtos B ON A.ProdutoId = B.ProdutoId
                                                    INNER JOIN Estoque C ON A.ProdutoId = C.ProdutoId
                                                    INNER JOIN CaixaVendasBase D ON A.VendasBaseId = D.Id
                                                    WHERE D.CaixaId = @Caixaid AND StatusVendas = 0 
                                                    AND Status = 1 AND A.EmpresaId= @EmpresaId");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@CaixaId", CaixaId);
                    cmd.Parameters.AddWithValue("@EmpresaId", EmpresaId);
                    using (Dr = await cmd.ExecuteReaderAsync())
                    {
                        Vendas mod = null;
                        while (await Dr.ReadAsync())
                        {
                            mod = new Vendas();
                            mod.Id = Convert.ToInt32(Dr[0]);
                            mod.ProdutoNome = Convert.ToString(Dr[1]);
                            mod.ValorVenda = Convert.ToDecimal(Dr[2]);
                            mod.Peso = Convert.ToDecimal(Dr[3]);
                            mod.TotalItem = Convert.ToInt32(Dr[4]);
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
        /// <param name="CaixaId"></param>
        /// <returns></returns>
        public decimal TotalItem(int CaixaId)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT SUM(A.TotalItem) As TotalItem FROM Vendas A
                                                    INNER JOIN CaixaVendasBase B ON A.VendasBaseId = B.Id
                                                    WHERE B.CaixaId = @CaixaId AND B.StatusVendas = 0 AND Status = 1");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@CaixaId", CaixaId);
                    using (Dr = cmd.ExecuteReader())
                    {
                        Vendas mod = null;
                        while (Dr.Read())
                        {
                            mod = new Vendas();
                            mod.TotalItem = Convert.ToInt32(Dr[0]);

                        }
                        return mod.TotalItem;
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
        /// <param name="CaixaId"></param>
        /// <returns></returns>
        public decimal SubTotal(int CaixaId, int EmpresaId)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT SUM(A.ValorVenda)As SubTotal FROM Vendas A
                                                    INNER JOIN Estoque C ON A.ProdutoId = C.ProdutoId
                                                    INNER JOIN CaixaVendasBase D ON A.VendasBaseId = D.Id
                                                    WHERE D.CaixaId = @CaixaId AND D.StatusVendas = 0 
                                                    AND Status = 1 AND A.EmpresaId =@EmpresaId");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@CaixaId", CaixaId);
                    cmd.Parameters.AddWithValue("@Empresaid", EmpresaId);
                    using (Dr = cmd.ExecuteReader())
                    {
                        Vendas mod = null;
                        while (Dr.Read())
                        {
                            mod = new Vendas();
                            mod.SubTotal = Convert.ToDecimal(Dr[0]);

                        }
                        return mod.SubTotal;
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
        public bool CheckProdutoEstoque(int ProdutoId,int EmpresaId)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT ProdutoId FROM Estoque 
                                                    WHERE ProdutoId = @ProdutoId AND EmpresaId =@EmpresaId");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@ProdutoId", ProdutoId);
                    cmd.Parameters.AddWithValue("@EmpresaId", EmpresaId);
                    using (Dr = cmd.ExecuteReader())
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
        public Estoque CheckQtyEstoque(int ProdutoId, int EmpresaId)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT ProdutoId,Quantidade,EstoqueMin FROM ESTOQUE
                                                    WHERE ProdutoId = @ProdutoId AND EmpresaId = @EmpresaId");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@produtoId", ProdutoId);
                    cmd.Parameters.AddWithValue("@EmpresaId", EmpresaId);
                    using (Dr = cmd.ExecuteReader())
                    {
                        Estoque mod = null;
                        while (Dr.Read())
                        {
                            mod = new Estoque();
                            mod.ProdutoId = Convert.ToInt32(Dr[0]);
                            mod.Quantidade = Convert.ToInt32(Dr[1]);
                            mod.EstoqueMin = Convert.ToInt32(Dr[2]);

                        }
                        return mod;
                    }
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
        public void AtualiarEstoqueVendas(Estoque mod)
        {
            try
            {
                OpenConnection();
                string strUpdate = string.Format(@"UPDATE Estoque SET Quantidade = @Quantidade WHERE ProdutoId = @Id");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strUpdate, con))
                {
                    cmd.Parameters.AddWithValue("@Id", mod.ProdutoId);
                    cmd.Parameters.AddWithValue("@Quantidade", mod.Quantidade);
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
        /// <returns></returns>
        public CaixaVendasBase CheckStatusCaixa(int CaixaId, int EmpresaId)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT Id,StatusVendas
                                                    FROM CaixaVendasBase
                                                    WHERE CaixaId = @CaixaId 
                                                          AND StatusVendas = 0
                                                          AND EmpresaId = @EmpresaId");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@CaixaId", CaixaId);
                    cmd.Parameters.AddWithValue("@EmpresaId", EmpresaId);
                    using (Dr = cmd.ExecuteReader())
                    {
                        CaixaVendasBase mod = null;
                        while (Dr.Read())
                        {
                            mod = new CaixaVendasBase();
                            mod.Id = Convert.ToInt32(Dr[0]);
                            mod.StatusVendas = Convert.ToInt32(Dr[1]);
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
        public int GetVendasId(int Id, int EmpresaId)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT A.Id FROM Vendas A
                                                    INNER JOIN Estoque B ON A.ProdutoId = B.ProdutoId
                                                    WHERE A.ProdutoId = @Id AND Peso is null AND A.EmpresaId =@EmpresaId");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@EmpresaId", EmpresaId);
                    using (Dr = cmd.ExecuteReader())
                    {
                        Vendas mod = null;
                        while (Dr.Read())
                        {
                            mod = new Vendas();
                            mod.Id = Convert.ToInt32(Dr[0]);

                        }
                        return mod.Id;
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
        /// <returns></returns>
        public decimal GetValorUnitById(int Id, int EmpresaId)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT B.ValorUnit FROM Vendas A
                                                    INNER JOIN Estoque B ON A.ProdutoId = B.ProdutoId
                                                    WHERE A.Id = @Id AND A.EmpresaId = @EmpresaId");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@EmpresaId", EmpresaId);
                    using (Dr = cmd.ExecuteReader())
                    {
                        Vendas mod = null;
                        while (Dr.Read())
                        {
                            mod = new Vendas();
                            mod.ValorUnit = Convert.ToDecimal(Dr[0]);

                        }
                        return mod.ValorUnit;
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
        public void AddValorVendaAndPeso(Vendas vendas)
        {
            try
            {
                OpenConnection();
                string strUpdate = string.Format(@"UPDATE Vendas SET ValorVenda = @ValorVenda, Peso = @Peso WHERE Id = @Id");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strUpdate, con))
                {
                    cmd.Parameters.AddWithValue("@Id", vendas.Id);
                    cmd.Parameters.AddWithValue("@ValorVenda", vendas.ValorVenda);
                    cmd.Parameters.AddWithValue("@Peso", vendas.Peso);
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
        /// <param name="Id"></param>
        public async void RemoveItemVenda(int Id)
        {
            try
            {
                OpenConnection();
                string strUpdate = string.Format(@"UPDATE Vendas SET Status = 2 WHERE Id = @Id");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strUpdate, con))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
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
        public async void PagamentoCaixaBase(CaixaVendasBase mod, int Id)
        {
            try
            {
                OpenConnection();
                string strUpdate = string.Format(@"UPDATE CaixaVendasBase SET ValorRecebido = @ValorRecebido,ValorPago =@ValorPago,ValorTroco =@ValorTroco,TipoPagamentoId =@TipoPagamentoId WHERE Id = @Id");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strUpdate, con))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@ValorRecebido", mod.ValorRecebido);
                    cmd.Parameters.AddWithValue("@ValorPago", mod.ValorPago);
                    cmd.Parameters.AddWithValue("@ValorTroco", mod.ValorTroco);
                    cmd.Parameters.AddWithValue("@TipoPagamentoId", mod.TipoPagamentoId);
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
        /// <param name="Id"></param>
        /// <returns></returns>
        public decimal GetSomaValoresGastos(int Id)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT SUM(ValorVenda) As ValorVenda
                                                    FROM vendas 
                                                    WHERE VendasBaseId = @Id AND Status = 1");
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    using(Dr = cmd.ExecuteReader())
                    {
                        Vendas mod = null;
                        while (Dr.Read())
                        {
                            mod = new Vendas();
                            mod.ValorVenda = Convert.ToDecimal(Dr[0]);
                        }
                        return mod.ValorVenda;
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
        /// <returns></returns>
        public CaixaVendasBase GetValoresPagamentos(int Id)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT Id,ValorRecebido,ValorPago,ValorTroco 
                                                   FROM CaixaVendasBase WHERE Id = @Id");
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    using(Dr = cmd.ExecuteReader())
                    {
                        CaixaVendasBase mod = null;
                        while (Dr.Read())
                        {
                            mod = new CaixaVendasBase();
                            mod.Id = Convert.ToInt32(Dr[0]);
                            mod.ValorRecebido = Convert.ToDecimal(Dr[1]);
                            mod.ValorPago = Convert.ToDecimal(Dr[2]);
                            mod.ValorTroco = Convert.ToDecimal(Dr[3]);

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
        public void FinalizarVenda(int Id)
        {
            try
            {
                OpenConnection();
                string strUpdate = string.Format(@"UPDATE CaixaVendasBase SET StatusVendas = 1 
                                                        WHERE Id = @Id");
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strUpdate, con))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
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
        /// <returns></returns>
        public Vendas GetVendasProdutoById(int Id)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT ProdutoId FROM Vendas WHERE Id = @Id");
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    using(Dr = cmd.ExecuteReader())
                    {
                        Vendas mod = null;
                        while (Dr.Read())
                        {
                            mod = new Vendas();
                            mod.ProdutoId = Convert.ToInt32(Dr[0]);
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
                ClosedConnection(); ;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ProdutoId"></param>
        public async void RetornoEstoqueAposRemoverItem(int ProdutoId)
        {
            try
            {
                OpenConnection();
                string strUpdate = string.Format(@"UPDATE Estoque SET Quantidade = Quantidade + 1 WHERE ProdutoId = @ProdutoId");
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strUpdate, con))
                {
                    cmd.Parameters.AddWithValue("@ProdutoId", ProdutoId);
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
    }
}
