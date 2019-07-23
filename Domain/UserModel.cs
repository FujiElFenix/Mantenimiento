using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CLConexion;

namespace Domain
{
    public class UserModel
    {
        DaoUser userdao = new DaoUser();
        public bool LoginUser(string user, string pass) {
            return userdao.Login(user,pass);
        }
    }
}
