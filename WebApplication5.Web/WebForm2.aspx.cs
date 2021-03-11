using System;
using System.Web.UI;
using WebApplication5.BLL;
using WebApplication5.Model;

namespace WebApplication5
{
    public partial class WebForm2 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var title = TextBox1.Text;
            var options = RadioButtonList1.SelectedValue;
            var diaoYanTiMuModel = new DiaoYanTiMu_Model();
            var diaoYanTiMuBll = new DiaoYanTiMu_BLL();
            diaoYanTiMuModel.Id = Guid.NewGuid();
            diaoYanTiMuModel.Title = title;
            diaoYanTiMuModel.SelectionType = int.Parse(options);
            diaoYanTiMuModel.IsOver = false;
            var result = diaoYanTiMuBll.Add(diaoYanTiMuModel);
            if (result)
                Response.Write("添加成功");
            else
                Response.Write("添加失败,请重试");

            TextBox1.Text = "";
        }
    }
}