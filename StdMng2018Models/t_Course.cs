using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdMng2018Models
{
    [Serializable]
    public class t_Course
    {
        private string _Cno = string.Empty;
        private string _Cname = string.Empty;
        private string _CPno = string.Empty;
        private short _Ccredit =0;

        /// <summary>
        /// 课程号
        /// </summary>
        public string Cno { get => _Cno; set => _Cno = value; }
        /// <summary>
        /// 课程名
        /// </summary>
        public string Cname { get => _Cname; set => _Cname = value; }
        /// <summary>
        /// 先行课
        /// </summary>
        public string CPno { get => _CPno; set => _CPno = value; }
        /// <summary>
        /// 学分
        /// </summary>
        public short Ccredit { get => _Ccredit; set => _Ccredit = value; }
    }
}
