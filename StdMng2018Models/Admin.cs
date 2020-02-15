using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdMng2018Models
{
    [Serializable]//序列化  此类不能被继承
    public class Admin
    {
        private string _loginId=string.Empty;
        private string _loginPwd=string.Empty;
        /// <summary>
        /// 用户ID
        /// </summary>
        public string LoginPwd { get => _loginPwd; set => _loginPwd = value; }
        /// <summary>
        /// 密码
        /// </summary>
        public string LoginId { get => _loginId; set => _loginId = value; }
    }
}
