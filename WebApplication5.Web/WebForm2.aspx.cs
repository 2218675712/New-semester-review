using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication5.BLL;
using WebApplication5.Model;

namespace WebApplication5
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string title = TextBox1.Text;
            string options = RadioButtonList1.SelectedValue;
            DiaoYanTiMu_Model diaoYanTiMuModel = new DiaoYanTiMu_Model();
            DiaoYanTiMu_BLL diaoYanTiMuBll = new DiaoYanTiMu_BLL();
            diaoYanTiMuModel.Id = Guid.NewGuid();
            diaoYanTiMuModel.Title = title;
            diaoYanTiMuModel.SelectionType = Int32.Parse(options);
            diaoYanTiMuModel.IsOver = false;
            bool result = diaoYanTiMuBll.Add(diaoYanTiMuModel);
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