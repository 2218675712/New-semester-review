using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication5.BLL;
using WebApplication5.DBUtility;
using WebApplication5.Model;

namespace WebApplication5
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               GetTiMu();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        
        /// <summary>
        /// 获取题目
        /// </summary>
        private void GetTiMu()
        {
            DropDownList1.DataSource = DbHelperSQL.Query("select * from DiaoYanTiMu");
            // 绑定下拉框文字
            DropDownList1.DataTextField = "Title";
            //绑定下拉框value值
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("题目名称", "0"));
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            DiaoYanXuanXiang_BLL diaoYanXuanXiangBll = new DiaoYanXuanXiang_BLL();
            DiaoYanXuanXiang_Model diaoYanXuanXiangModel = new DiaoYanXuanXiang_Model();
            diaoYanXuanXiangModel.Id=Guid.NewGuid();
            diaoYanXuanXiangModel.Numbers = 0;
            diaoYanXuanXiangModel.Options = TextBox1.Text;
            diaoYanXuanXiangModel.TiMuZhuJian = new Guid(DropDownList1.SelectedValue);
            bool result=diaoYanXuanXiangBll.Add(diaoYanXuanXiangModel);
            if (result)
            {
                Response.Write("添加成功");

            }
            else
            {
                Response.Write("添加失败,请重试");
            }
            TextBox1.Text = "";

        }
    }
}