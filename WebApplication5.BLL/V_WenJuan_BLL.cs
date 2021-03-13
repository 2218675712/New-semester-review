using System;
using System.Collections.Generic;
using System.Data;
using WebApplication5.DAL;
using WebApplication5.Model;

namespace WebApplication5.BLL
{
	/// <summary>
	///     V_WenJuan_BLL
	/// </summary>
	public class V_WenJuan_BLL
    {
        private readonly V_WenJuan_DAL dal = new V_WenJuan_DAL();

        #region BasicMethod

        /// <summary>
        ///     是否存在该记录
        /// </summary>
        public bool Exists(Guid X_ID, string X_Options, int X_Numbers, Guid X_TiMuZhuJian, Guid T_Id, string T_Title,
            int T_SelectionType, bool T_IsOver)
        {
            return dal.Exists(X_ID, X_Options, X_Numbers, X_TiMuZhuJian, T_Id, T_Title, T_SelectionType, T_IsOver);
        }

        /// <summary>
        ///     增加一条数据
        /// </summary>
        public bool Add(V_WenJuan_Model model)
        {
            return dal.Add(model);
        }

        /// <summary>
        ///     更新一条数据
        /// </summary>
        public bool Update(V_WenJuan_Model model)
        {
            return dal.Update(model);
        }

        /// <summary>
        ///     删除一条数据
        /// </summary>
        public bool Delete(Guid X_ID, string X_Options, int X_Numbers, Guid X_TiMuZhuJian, Guid T_Id, string T_Title,
            int T_SelectionType, bool T_IsOver)
        {
            return dal.Delete(X_ID, X_Options, X_Numbers, X_TiMuZhuJian, T_Id, T_Title, T_SelectionType, T_IsOver);
        }

        /// <summary>
        ///     得到一个对象实体
        /// </summary>
        public V_WenJuan_Model GetModel(Guid X_ID, string X_Options, int X_Numbers, Guid X_TiMuZhuJian, Guid T_Id,
            string T_Title, int T_SelectionType, bool T_IsOver)
        {
            return dal.GetModel(X_ID, X_Options, X_Numbers, X_TiMuZhuJian, T_Id, T_Title, T_SelectionType, T_IsOver);
        }

        /// <summary>
        ///     获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

        /// <summary>
        ///     获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }

        /// <summary>
        ///     获得数据列表
        /// </summary>
        public List<V_WenJuan_Model> GetModelList(string strWhere)
        {
            var ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        ///     获得数据列表
        /// </summary>
        public List<V_WenJuan_Model> DataTableToList(DataTable dt)
        {
            var modelList = new List<V_WenJuan_Model>();
            var rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                V_WenJuan_Model model;
                for (var n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null) modelList.Add(model);
                }
            }

            return modelList;
        }

        /// <summary>
        ///     获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        ///     分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }

        /// <summary>
        ///     分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion BasicMethod

        #region ExtensionMethod

        #endregion ExtensionMethod
    }
}