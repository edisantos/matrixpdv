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
    public class CaixaRepostitory:DaoContexto
    {
        public async Task<IEnumerable<Caixas>> GetNumeroCaixas()
        {
            try
            {
                OpenConnection();
                List<Caixas> lista = new List<Caixas>();
                string strSelect = string.Format(@"SELECT Id,Nome FROM Caixas");
                using(cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    using(Dr = await cmd.ExecuteReaderAsync())
                    {
                        Caixas mod = null;
                        while (await Dr.ReadAsync())
                        {
                            mod = new Caixas();
                            mod.Id = Convert.ToInt32(Dr[0]);
                            mod.Nome = Convert.ToInt32(Dr[1]);
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
