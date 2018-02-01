using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugar.Model
{
    [SugarTable("UserInfo")]
    public class UserInfo
    {
        [SugarColumn(IsPrimaryKey = true,ColumnDescription="ID")]
        public string Id { get; set; }
        
        [SugarColumn(Length=50,IsNullable=false,ColumnDescription="用户名")]
        public string UserName { get; set; }

        [SugarColumn(Length = 50, IsNullable = false, ColumnDescription = "密码")]
        public string PassWord { get; set; }

        
    }
}
