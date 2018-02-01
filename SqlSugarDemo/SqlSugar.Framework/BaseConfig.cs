using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar.Model;

namespace SqlSugar.Framework
{
    public class BaseConfig
    {
        public static SqlSugarClient GetInstance()
        {
            SqlSugarClient db = new SqlSugarClient(
                new ConnectionConfig() {
                    ConnectionString = "server=.;uid=sa;pwd=123456;database=SqlSugarDbModel", 
                    DbType = DbType.SqlServer, 
                    IsAutoCloseConnection = true ,
                    InitKeyType = InitKeyType.Attribute
                });
            db.CodeFirst.InitTables(typeof(UserInfo));
            return db;
        }
    }
}
