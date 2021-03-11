using System;
using System.Web.UI;
using WebApplication5.BLL;
using WebApplication5.Model;

namespace WebApplication5
{
    public partial class WebForm1 : Page
    {
        private readonly string TiMu = "311522CC-6A44-47E4-8F7E-DCC3A71EE670";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetDiaoYanList();
                RefreshData();
            }
        }

        /// <summary>
        ///     获取调研题目和选项
        /// </summary>
        private void GetDiaoYanList()
        {
            /*
            DataSet dataSet =
                OperaterBase.getData(
                    "select X.Id as X_ID, X.Options as X_Options,X.Numbers as X_Numbers,X.TiMuZhuJian as X_TiMuZhuJian,T.Id as T_Id,T.Title as T_Title,T.SelectionType as T_SelectionType,T.IsOver as T_IsOver from DiaoYanXuanXiang as X right join DiaoYanTiMu as T on X.TiMuZhuJian = T.Id where IsOver = 0 ");
            CheckBoxList1.DataTextField = "X_Options";
            CheckBoxList1.DataValueField = "X_ID";
            CheckBoxList1.DataSource = dataSet;
            CheckBoxList1.DataBind();
            */
            var diaoYanXuanXiangBll = new DiaoYanXuanXiang_BLL();
            var diaoYanXuanXiangModels =
                diaoYanXuanXiangBll.GetModelList("TiMuZhuJian='" + TiMu + "'");
            CheckBoxList1.DataTextField = "Options";
            CheckBoxList1.DataValueField = "Id";
            CheckBoxList1.DataSource = diaoYanXuanXiangModels;
            CheckBoxList1.DataBind();
        }

        /// <summary>
        ///     进行投票操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_OnClick(object sender, EventArgs e)
        {
            var diaoYanXuanXiangBll = new DiaoYanXuanXiang_BLL();
            var diaoYanXuanXiangModel = new DiaoYanXuanXiang_Model();
            // 获取当前选择的选项id进行查询提交数量,之后让后台加1
            var id = "";
            if (CheckBoxList1.SelectedItem != null) id = CheckBoxList1.SelectedItem.Value;

            if (string.IsNullOrEmpty(id))
            {
                Response.Write("请检查是否勾选了内容");
                return;
            }

            diaoYanXuanXiangModel = diaoYanXuanXiangBll.GetModel(new Guid(id));
            diaoYanXuanXiangModel.Numbers = diaoYanXuanXiangModel.Numbers + 1;
            diaoYanXuanXiangBll.Update(diaoYanXuanXiangModel);
            RefreshData();
            GetDiaoYanList();
        }

        /// <summary>
        ///     刷新数据
        /// </summary>
        private void RefreshData()
        {
            var diaoYanXuanXiangBll = new DiaoYanXuanXiang_BLL();
            var diaoYanXuanXiangModel = new DiaoYanXuanXiang_Model();

            var diaoYanXuanXiangModels =
                diaoYanXuanXiangBll.GetModelList("TiMuZhuJian='" + TiMu + "'");
            Repeater1.DataSource = diaoYanXuanXiangModels;
            Repeater1.DataBind();
        }
    }
}