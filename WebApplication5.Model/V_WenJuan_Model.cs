using System;

namespace WebApplication5.Model
{
    /// <summary>
    ///     V_WenJuan_Model:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class V_WenJuan_Model
    {
        #region Model

        private Guid _x_id;
        private string _x_options;
        private int? _x_numbers;
        private Guid _x_timuzhujian;
        private Guid _t_id;
        private string _t_title;
        private int? _t_selectiontype;
        private bool _t_isover;

        /// <summary>
        /// </summary>
        public Guid X_ID
        {
            set => _x_id = value;
            get => _x_id;
        }

        /// <summary>
        /// </summary>
        public string X_Options
        {
            set => _x_options = value;
            get => _x_options;
        }

        /// <summary>
        /// </summary>
        public int? X_Numbers
        {
            set => _x_numbers = value;
            get => _x_numbers;
        }

        /// <summary>
        /// </summary>
        public Guid X_TiMuZhuJian
        {
            set => _x_timuzhujian = value;
            get => _x_timuzhujian;
        }

        /// <summary>
        /// </summary>
        public Guid T_Id
        {
            set => _t_id = value;
            get => _t_id;
        }

        /// <summary>
        /// </summary>
        public string T_Title
        {
            set => _t_title = value;
            get => _t_title;
        }

        /// <summary>
        /// </summary>
        public int? T_SelectionType
        {
            set => _t_selectiontype = value;
            get => _t_selectiontype;
        }

        /// <summary>
        /// </summary>
        public bool T_IsOver
        {
            set => _t_isover = value;
            get => _t_isover;
        }

        #endregion Model
    }
}