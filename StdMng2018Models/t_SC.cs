using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdMng2018Models
{
    [Serializable]
    public class t_SC
    {  private string _Sno = string.Empty;
        private string _Cno = string.Empty;
        private short _Grade = 0;
        /// <summary>
        /// 学号
        /// </summary>
        public string Sno { get => _Sno; set => _Sno = value; }
        /// <summary>
        /// 课程号
        /// </summary>
        public string Cno { get => _Cno; set => _Cno = value; }
        /// <summary>
        /// 成绩
        /// </summary>
        public short Grade { get => _Grade; set => _Grade = value; }
    }
}
