using System;
namespace WebApplication5.Model
{
    /// <summary>
    /// 调研选项
    /// </summary>
    [Serializable]
    public partial class DiaoYanXuanXiang_Model
    {
        public DiaoYanXuanXiang_Model()
        {}
        #region Model
        private Guid _id;
        private string _options;
        private int _numbers;
        private Guid _timuzhujian;
        /// <summary>
        /// 
        /// </summary>
        public Guid Id
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 调研每个题目的选项内容
        /// </summary>
        public string Options
        {
            set{ _options=value;}
            get{return _options;}
        }
        /// <summary>
        /// 选择此调研选项的人数
        /// </summary>
        public int Numbers
        {
            set{ _numbers=value;}
            get{return _numbers;}
        }
        /// <summary>
        /// 题目主键
        /// </summary>
        public Guid TiMuZhuJian
        {
            set{ _timuzhujian=value;}
            get{return _timuzhujian;}
        }
        #endregion Model

    }
}