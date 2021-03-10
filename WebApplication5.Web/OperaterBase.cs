using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication5
{
    public class OperaterBase
    {
        public OperaterBase()
        {
        }

        private static SqlConnection GetConn()
        {
            string con = ConfigurationManager.ConnectionStrings["Survey"].ConnectionString;
            //创建数据库管道
            SqlConnection sct = new SqlConnection(con);
            return sct;
        }

        public static DataSet getData(string sql)
        {
            //创建数据库管道
            SqlConnection conn = GetConn();
            //创建数据库连接
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            //创建数据容器
            DataSet ds = new DataSet();
            //将sda中的数据填充到数据库容器内
            sda.Fill(ds);
            return ds;
        }

        public static int CommandBySql(string sql)
        {
            //创建数据库管道
            SqlConnection conn = GetConn();
            // 执行语句
            SqlCommand smd = new SqlCommand(sql, conn);
            // 打开数据库链接
            conn.Open();
            // 返回受影响的行数
            int flag = smd.ExecuteNonQuery();
            // 关闭数据库链接
            conn.Close();
            return flag;
        }
    }
}