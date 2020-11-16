using System;
using SqlSugar;
namespace AbaabaSystem.Service
{
    public class DBContext
    {
        public SqlSugarClient Instance
        {
            get
            {
                return new SqlSugarClient(new ConnectionConfig()
                {
                    ConnectionString = "Server=.;Database=AbaabaSystemDB;Uid=abaabasystem;Pwd=xiongjie520",
                    DbType = DbType.MySql,
                    IsAutoCloseConnection = true,
                    InitKeyType = InitKeyType.Attribute
                });
            }
        }
    }
}
