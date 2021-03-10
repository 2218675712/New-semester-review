using System;

namespace WebApplication5.Model
{
    /// <summary>
    /// 调研题目
    /// </summary>
    [Serializable]
    public partial class DiaoYanTiMu_Model
    {
        public DiaoYanTiMu_Model()
        {
        }

        #region Model

        private Guid _id;
        private string _title;
        private int? _selectiontype;
        private bool _isover;

        /// <summary>
        /// 
        /// </summary>
        public Guid Id
        {
            set { _id = value; }
            get { return _id; }
        }

        /// <summary>
        /// 要调查的题目
        /// </summary>
        public string Title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 单选多选序号
        ///0单选
        ///1多选

        /// </summary>
        public int? SelectionType
        {
            set { _selectiontype = value; }
            get { return _selectiontype; }
        }

        /// <summary>
        /// 是否结束
        ///true结束
        ///  false未结束
        /// </summary>
        public bool IsOver
        {
            set { _isover = value; }
            get { return _isover; }
        }

        #endregion Model
    }
}