using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdMng2018Models
{
    [Serializable]
    public class t_Sdept
    {
        
        private string _SdeptID = string.Empty;
        private string _SdeptName = string.Empty;
        /// <summary>
        /// 所在系的号数
        /// </summary>
        public string SdeptID { get => _SdeptID; set => _SdeptID = value; }
        /// <summary>
        /// 所在系的名称
        /// </summary>
        public string SdeptName { get => _SdeptName; set => _SdeptName = value; }
    }
}
