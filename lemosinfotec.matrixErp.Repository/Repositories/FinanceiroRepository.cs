using lemosinfotec.matrixerp.Domain.Entities;
using lemosinfotec.matrixErp.Data.Contexto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemosinfotec.matrixErp.Repository.Repositories
{
    public class FinanceiroRepository:DaoContexto
    {

        public async Task<IEnumerable<Financeiros>> GetFinancasDiarias(string Data1,string Data2, int EmpresaId)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT B.DataVendas,D.Nome As Operador,C.ProdutoNome,B.ValorVenda,A.ValorRecebido,A.ValorPago,F.ValorUnit,B.Peso,
                                    E.Nome As TipoPagamento
                                    FROM CaixaVendasBase A
                                    INNER JOIN Vendas B ON A.Id = B.VendasBaseId
                                    INNER JOIN Produtos C ON B.ProdutoId = C.ProdutoId
                                    INNER JOIN Usuarios D ON B.OperadorId = D.Id
                                    INNER JOIN TipoPagamento E ON A.TipoPagamentoId = E.Id
                                    INNER JOIN Estoque F ON C.ProdutoId = F.ProdutoId
                                    WHERE 
                                    CONVERT(VARCHAR(11),B.DataVendas,111) BETWEEN  @Data1 AND @Data2
                                    AND B.EmpresaId = @EmpresaId
                                    ");
                List<Financeiros> lista = new List<Financeiros>();
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@Data1", Data1);
                    cmd.Parameters.AddWithValue("@Data2", Data2);
                    cmd.Parameters.AddWithValue("@EmpresaId", EmpresaId);
                    using(Dr =  await cmd.ExecuteReaderAsync())
                    {
                        Financeiros mod = null;
                        while (await Dr.ReadAsync())
                        {
                            mod = new Financeiros();
                            mod.DataVendas = Convert.ToDateTime(Dr[0]);
                            mod.Operador = Convert.ToString(Dr[1]);
                            mod.ProdutoNome = Convert.ToString(Dr[2]);
                            mod.ValorVenda = Convert.ToDecimal(Dr[3]);
                            mod.ValorRecebido = Convert.ToDecimal(Dr[4]);
                            mod.ValorPago = Convert.ToDecimal(Dr[5]);
                            mod.ValorUnit = Convert.ToDecimal(Dr[6]);
                            mod.Peso = Convert.ToDecimal(Dr[7]);
                            mod.TipoPagamento = Convert.ToString(Dr[8]);
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
        /// <param name="EmpresaId"></param>
        /// <returns></returns>
        public Financeiros GetTotalVendasHoje(int EmpresaId)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT SUM(ValorPago)As ValorPago 
                                                    FROM CaixaVendasBase WHERE 
                                                    CONVERT(VARCHAR(11),DataVendas,111) = CONVERT(VARCHAR(11),SYSDATETIME(),111) AND EmpresaId = @EmpresaId");
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@EmpresaId", EmpresaId);
                    using(Dr = cmd.ExecuteReader())
                    {
                        Financeiros mod = null;
                        while (Dr.Read())
                        {
                            mod = new Financeiros();
                           mod.ValorPago = Convert.ToDecimal(Dr[0]);    

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
        /// /
        /// </summary>
        /// <param name="EmpresaId"></param>
        /// <returns></returns>
        public Financeiros GetTotalVendasWeek(int EmpresaId)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT SUM(ValorPago) AS ValorPago FROM CaixaVendasBase WHERE DATEPART(WEEK,DataVendas) = DATEPART(WEEK,SYSDATETIME())
                  AND EmpresaId = @EmpresaId");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@EmpresaId", EmpresaId);
                    using (Dr = cmd.ExecuteReader())
                    {
                        Financeiros mod = null;
                        while (Dr.Read())
                        {
                            mod = new Financeiros();
                            mod.ValorPago = Convert.ToDecimal(Dr[0]);

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
        /// <param name="EmpresaId"></param>
        /// <returns></returns>
        public Financeiros GetTotalVendasMonth(int EmpresaId)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT SUM(ValorPago) AS ValorPago FROM CaixaVendasBase WHERE DATEPART(Month,DataVendas) = DATEPART(Month,SYSDATETIME())
                  AND EmpresaId = @EmpresaId");
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@EmpresaId", EmpresaId);
                    using (Dr = cmd.ExecuteReader())
                    {
                        Financeiros mod = null;
                        while (Dr.Read())
                        {
                            mod = new Financeiros();
                            mod.ValorPago = Convert.ToDecimal(Dr[0]);

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

        public List<Financeiros> GetGraficoMensal(int EmpresaId)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SET LANGUAGE 'PORTUGUESE'
                                                SELECT DATENAME(month,SYSDATETIME())As Mes, SUM(ValorRecebido)As ValorRecebido FROM CaixaVendasBase
                                                WHERE EmpresaId = @EmpresaId");
                List<Financeiros> lista = new List<Financeiros>();
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    cmd.Parameters.AddWithValue("@EmpresaId", EmpresaId);
                    using (Dr = cmd.ExecuteReader())
                    {
                        Financeiros mod = null;
                        while (Dr.Read())
                        {
                            mod = new Financeiros();
                            mod.Mes = Convert.ToString(Dr[0]);
                            mod.ValorRecebido = Convert.ToDecimal(Dr[1]);
                            lista.Add(mod);

                        }
                        return lista;
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
    }
}
