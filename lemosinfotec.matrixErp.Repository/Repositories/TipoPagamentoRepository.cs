using lemosinfotec.matrixerp.Domain.Entities;
using lemosinfotec.matrixErp.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace lemosinfotec.matrixErp.Repository.Repositories
{
    public class TipoPagamentoRepository:DaoContexto
    {
        public async Task<IEnumerable<TipoPagamento>> GetPagamentos()
        {
            try
            {
                OpenConnection();

                List<TipoPagamento> lista = new List<TipoPagamento>();
                string strSelect = string.Format(@"SELECT Id,Nome FROM TipoPagamento");
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    using(Dr = await cmd.ExecuteReaderAsync())
                    {
                        TipoPagamento mod = null;
                        while (await Dr.ReadAsync())
                        {
                            mod = new TipoPagamento();
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
    }
}
