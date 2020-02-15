using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdMng2018Models
{
    [Serializable]
    public class t_Student
    {
        
        private string _Sno = string.Empty;
        private string _Sname = string.Empty;
        private string _Sgender = string.Empty;
        private DateTime _Sbirth;
        private string _Sdept = string.Empty;
        //private Byte _Simage = 0;
        private string _e_mail = string.Empty;
        //private int Sage = 0;

        /// <summary>
        /// 学号
        /// </summary>
        public string Sno { get => _Sno; set => _Sno = value; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Sname { get => _Sname; set => _Sname = value; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sgender { get => _Sgender; set => _Sgender = value; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime Sbirth { get => _Sbirth; set => _Sbirth = value; }
        /// <summary>
        /// 所在系别
        /// </summary>
        public string Sdept { get => _Sdept; set => _Sdept = value; }
        /// <summary>
        /// 学生的照片
        /// </summary>
        //public byte Simage { get => _Simage; set => _Simage = value; }
        /// <summary>
        /// 学生的EMAIL
        /// </summary>
        
        public string E_mail { get => _e_mail; set => _e_mail = value; }
    }
}
