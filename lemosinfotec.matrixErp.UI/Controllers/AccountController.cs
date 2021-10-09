using lemosinfotec.matrixerp.Domain.Entities;
using lemosinfotec.matrixErp.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemosinfotec.matrixErp.UI.Controllers
{
    public class AccountController
    {
        private static DataContexto _context;

        public AccountController(DataContexto context)
        {
            _context = context;
        }

        public static bool Login(string UserName, string Pw)
        {

            try
            {
                var login = _context.Login.Where(u => u.UserName == UserName && u.Password == Pw);

                if (login != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        
        }
    }
}
