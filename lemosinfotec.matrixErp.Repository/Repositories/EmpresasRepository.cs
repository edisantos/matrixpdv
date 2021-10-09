using lemosinfotec.matrixerp.Domain.Entities;
using lemosinfotec.matrixErp.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace lemosinfotec.matrixErp.Repository.Repositories
{
    public class EmpresasRepository:DaoContexto
    {
        public async Task<IEnumerable<Empresas>> GetEmpresas()
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT EmpresaId,EmpresaNome FROM Empresas");
                List<Empresas> lista = new List<Empresas>();
                using (cmd = new Microsoft.Data.SqlClient.SqlCommand(strSelect, con))
                {
                    using(Dr = await cmd.ExecuteReaderAsync())
                    {
                        Empresas mod = null;
                        while (await Dr.ReadAsync())
                        {
                            mod = new Empresas();
                            mod.EmpresaId = Convert.ToInt32(Dr[0]);
                            mod.EmpresaNome = Convert.ToString(Dr[1]);
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
