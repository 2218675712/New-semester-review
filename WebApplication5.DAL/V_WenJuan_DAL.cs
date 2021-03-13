using System;
using System.Data;
using System.Text;
using WebApplication5.DBUtility;
using WebApplication5.Model;

namespace WebApplication5.DAL
{
	/// <summary>
	///     数据访问类:V_WenJuan_DAL
	/// </summary>
	public class V_WenJuan_DAL
    {
        #region Method

        /// <summary>
        ///     是否存在该记录
        /// </summary>
        public bool Exists(Guid X_ID, string X_Options, int X_Numbers, Guid X_TiMuZhuJian, Guid T_Id, string T_Title,
            int T_SelectionType, bool T_IsOver)
        {
            var strSql = new StringBuilder();
            strSql.Append("select count(1) from V_WenJuan");
            strSql.Append(" where X_ID='" + X_ID + "' and X_Options='" + X_Options + "' and X_Numbers=" + X_Numbers +
                          " and X_TiMuZhuJian='" + X_TiMuZhuJian + "' and T_Id='" + T_Id + "' and T_Title='" + T_Title +
                          "' and T_SelectionType=" + T_SelectionType + " and T_IsOver=" + T_IsOver + " ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        ///     增加一条数据
        /// </summary>
        public bool Add(V_WenJuan_Model model)
        {
            var strSql = new StringBuilder();
            var strSql1 = new StringBuilder();
            var strSql2 = new StringBuilder();
            if (model.X_ID != null)
            {
                strSql1.Append("X_ID,");
                strSql2.Append("'" + Guid.NewGuid() + "',");
            }

            if (model.X_Options != null)
            {
                strSql1.Append("X_Options,");
                strSql2.Append("'" + model.X_Options + "',");
            }

            if (model.X_Numbers != null)
            {
                strSql1.Append("X_Numbers,");
                strSql2.Append("" + model.X_Numbers + ",");
            }

            if (model.X_TiMuZhuJian != null)
            {
                strSql1.Append("X_TiMuZhuJian,");
                strSql2.Append("'" + Guid.NewGuid() + "',");
            }

            if (model.T_Id != null)
            {
                strSql1.Append("T_Id,");
                strSql2.Append("'" + Guid.NewGuid() + "',");
            }

            if (model.T_Title != null)
            {
                strSql1.Append("T_Title,");
                strSql2.Append("'" + model.T_Title + "',");
            }

            if (model.T_SelectionType != null)
            {
                strSql1.Append("T_SelectionType,");
                strSql2.Append("" + model.T_SelectionType + ",");
            }

            if (model.T_IsOver != null)
            {
                strSql1.Append("T_IsOver,");
                strSql2.Append("" + (model.T_IsOver ? 1 : 0) + ",");
            }

            strSql.Append("insert into V_WenJuan(");
            strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
            strSql.Append(")");
            var rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
                return true;
            return false;
        }

        /// <summary>
        ///     更新一条数据
        /// </summary>
        public bool Update(V_WenJuan_Model model)
        {
            var strSql = new StringBuilder();
            strSql.Append("update V_WenJuan set ");
            if (model.X_ID != null)
                strSql.Append("X_ID='" + model.X_ID + "',");
            else
                strSql.Append("X_ID= null ,");
            if (model.X_Options != null)
                strSql.Append("X_Options='" + model.X_Options + "',");
            else
                strSql.Append("X_Options= null ,");
            if (model.X_Numbers != null)
                strSql.Append("X_Numbers=" + model.X_Numbers + ",");
            else
                strSql.Append("X_Numbers= null ,");
            if (model.X_TiMuZhuJian != null)
                strSql.Append("X_TiMuZhuJian='" + model.X_TiMuZhuJian + "',");
            else
                strSql.Append("X_TiMuZhuJian= null ,");
            if (model.T_Id != null) strSql.Append("T_Id='" + model.T_Id + "',");
            if (model.T_Title != null) strSql.Append("T_Title='" + model.T_Title + "',");
            if (model.T_SelectionType != null)
                strSql.Append("T_SelectionType=" + model.T_SelectionType + ",");
            else
                strSql.Append("T_SelectionType= null ,");
            if (model.T_IsOver != null)
                strSql.Append("T_IsOver=" + (model.T_IsOver ? 1 : 0) + ",");
            else
                strSql.Append("T_IsOver= null ,");
            var n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where X_ID='" + model.X_ID + "' and X_Options='" + model.X_Options + "' and X_Numbers=" +
                          model.X_Numbers + " and X_TiMuZhuJian='" + model.X_TiMuZhuJian + "' and T_Id='" + model.T_Id +
                          "' and T_Title='" + model.T_Title + "' and T_SelectionType=" + model.T_SelectionType +
                          " and T_IsOver=" + model.T_IsOver + " ");
            var rowsAffected = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rowsAffected > 0)
                return true;
            return false;
        }

        /// <summary>
        ///     删除一条数据
        /// </summary>
        public bool Delete(Guid X_ID, string X_Options, int X_Numbers, Guid X_TiMuZhuJian, Guid T_Id, string T_Title,
            int T_SelectionType, bool T_IsOver)
        {
            var strSql = new StringBuilder();
            strSql.Append("delete from V_WenJuan ");
            strSql.Append(" where X_ID='" + X_ID + "' and X_Options='" + X_Options + "' and X_Numbers=" + X_Numbers +
                          " and X_TiMuZhuJian='" + X_TiMuZhuJian + "' and T_Id='" + T_Id + "' and T_Title='" + T_Title +
                          "' and T_SelectionType=" + T_SelectionType + " and T_IsOver=" + T_IsOver + " ");
            var rowsAffected = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rowsAffected > 0)
                return true;
            return false;
        }

        /// <summary>
        ///     得到一个对象实体
        /// </summary>
        public V_WenJuan_Model GetModel(Guid X_ID, string X_Options, int X_Numbers, Guid X_TiMuZhuJian, Guid T_Id,
            string T_Title, int T_SelectionType, bool T_IsOver)
        {
            var strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" X_ID,X_Options,X_Numbers,X_TiMuZhuJian,T_Id,T_Title,T_SelectionType,T_IsOver ");
            strSql.Append(" from V_WenJuan ");
            strSql.Append(" where X_ID='" + X_ID + "' and X_Options='" + X_Options + "' and X_Numbers=" + X_Numbers +
                          " and X_TiMuZhuJian='" + X_TiMuZhuJian + "' and T_Id='" + T_Id + "' and T_Title='" + T_Title +
                          "' and T_SelectionType=" + T_SelectionType + " and T_IsOver=" + T_IsOver + " ");
            var model = new V_WenJuan_Model();
            var ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
                return DataRowToModel(ds.Tables[0].Rows[0]);
            return null;
        }

        /// <summary>
        ///     得到一个对象实体
        /// </summary>
        public V_WenJuan_Model DataRowToModel(DataRow row)
        {
            var model = new V_WenJuan_Model();
            if (row != null)
            {
                if (row["X_ID"] != null && row["X_ID"].ToString() != "") model.X_ID = new Guid(row["X_ID"].ToString());
                if (row["X_Options"] != null) model.X_Options = row["X_Options"].ToString();
                if (row["X_Numbers"] != null && row["X_Numbers"].ToString() != "")
                    model.X_Numbers = int.Parse(row["X_Numbers"].ToString());
                if (row["X_TiMuZhuJian"] != null && row["X_TiMuZhuJian"].ToString() != "")
                    model.X_TiMuZhuJian = new Guid(row["X_TiMuZhuJian"].ToString());
                if (row["T_Id"] != null && row["T_Id"].ToString() != "") model.T_Id = new Guid(row["T_Id"].ToString());
                if (row["T_Title"] != null) model.T_Title = row["T_Title"].ToString();
                if (row["T_SelectionType"] != null && row["T_SelectionType"].ToString() != "")
                    model.T_SelectionType = int.Parse(row["T_SelectionType"].ToString());
                if (row["T_IsOver"] != null && row["T_IsOver"].ToString() != "")
                {
                    if (row["T_IsOver"].ToString() == "1" || row["T_IsOver"].ToString().ToLower() == "true")
                        model.T_IsOver = true;
                    else
                        model.T_IsOver = false;
                }
            }

            return model;
        }

        /// <summary>
        ///     获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            var strSql = new StringBuilder();
            strSql.Append("select X_ID,X_Options,X_Numbers,X_TiMuZhuJian,T_Id,T_Title,T_SelectionType,T_IsOver ");
            strSql.Append(" FROM V_WenJuan ");
            if (strWhere.Trim() != "") strSql.Append(" where " + strWhere);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        ///     获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            var strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0) strSql.Append(" top " + Top);
            strSql.Append(" X_ID,X_Options,X_Numbers,X_TiMuZhuJian,T_Id,T_Title,T_SelectionType,T_IsOver ");
            strSql.Append(" FROM V_WenJuan ");
            if (strWhere.Trim() != "") strSql.Append(" where " + strWhere);
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        ///     获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            var strSql = new StringBuilder();
            strSql.Append("select count(1) FROM V_WenJuan ");
            if (strWhere.Trim() != "") strSql.Append(" where " + strWhere);
            var obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
                return 0;
            return Convert.ToInt32(obj);
        }

        /// <summary>
        ///     分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            var strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
                strSql.Append("order by T." + @orderby);
            else
                strSql.Append("order by T.T_IsOver desc");
            strSql.Append(")AS Row, T.*  from V_WenJuan T ");
            if (!string.IsNullOrEmpty(strWhere.Trim())) strSql.Append(" WHERE " + strWhere);
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        */

        #endregion Method

        #region MethodEx

        #endregion MethodEx
    }
}