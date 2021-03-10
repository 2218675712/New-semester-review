using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WebApplication5.DBUtility;
using WebApplication5.Model;

namespace WebApplication5.DAL
{
	/// <summary>
	/// 数据访问类:DiaoYanXuanXiang_DAL
	/// </summary>
	public partial class DiaoYanXuanXiang_DAL
	{
		public DiaoYanXuanXiang_DAL()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DiaoYanXuanXiang");
			strSql.Append(" where Id='"+Id+"' ");
			return DbHelperSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DiaoYanXuanXiang_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.Id != null)
			{
				strSql1.Append("Id,");
				strSql2.Append("'"+ Guid.NewGuid().ToString() +"',");
			}
			if (model.Options != null)
			{
				strSql1.Append("Options,");
				strSql2.Append("'"+model.Options+"',");
			}
			if (model.Numbers != null)
			{
				strSql1.Append("Numbers,");
				strSql2.Append(""+model.Numbers+",");
			}
			if (model.TiMuZhuJian != null)
			{
				strSql1.Append("TiMuZhuJian,");
				strSql2.Append("'"+ model.TiMuZhuJian +"',");
			}
			strSql.Append("insert into DiaoYanXuanXiang(");
			strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
			strSql.Append(")");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(DiaoYanXuanXiang_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DiaoYanXuanXiang set ");
			if (model.Options != null)
			{
				strSql.Append("Options='"+model.Options+"',");
			}
			if (model.Numbers != null)
			{
				strSql.Append("Numbers="+model.Numbers+",");
			}
			if (model.TiMuZhuJian != null)
			{
				strSql.Append("TiMuZhuJian='"+model.TiMuZhuJian+"',");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where Id='"+ model.Id+"' ");
			int rowsAffected=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(Guid Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DiaoYanXuanXiang ");
			strSql.Append(" where Id='"+Id+"' " );
			int rowsAffected=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DiaoYanXuanXiang ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DiaoYanXuanXiang_Model GetModel(Guid Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" Id,Options,Numbers,TiMuZhuJian ");
			strSql.Append(" from DiaoYanXuanXiang ");
			strSql.Append(" where Id='"+Id+"' " );
			DiaoYanXuanXiang_Model model=new DiaoYanXuanXiang_Model();
			DataSet ds=DbHelperSQL.Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DiaoYanXuanXiang_Model DataRowToModel(DataRow row)
		{
			DiaoYanXuanXiang_Model model=new DiaoYanXuanXiang_Model();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id= new Guid(row["Id"].ToString());
				}
				if(row["Options"]!=null)
				{
					model.Options=row["Options"].ToString();
				}
				if(row["Numbers"]!=null && row["Numbers"].ToString()!="")
				{
					model.Numbers=int.Parse(row["Numbers"].ToString());
				}
				if(row["TiMuZhuJian"]!=null && row["TiMuZhuJian"].ToString()!="")
				{
					model.TiMuZhuJian= new Guid(row["TiMuZhuJian"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,Options,Numbers,TiMuZhuJian ");
			strSql.Append(" FROM DiaoYanXuanXiang ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Id,Options,Numbers,TiMuZhuJian ");
			strSql.Append(" FROM DiaoYanXuanXiang ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM DiaoYanXuanXiang ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from DiaoYanXuanXiang T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		*/

		#endregion  Method
		#region  MethodEx

		#endregion  MethodEx
	}
}

