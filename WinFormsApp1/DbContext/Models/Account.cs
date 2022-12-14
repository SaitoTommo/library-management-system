using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    /// <summary>
    /// 账号类型
    /// </summary>
    public enum AccountRole 
    {
        Admin,
        Student
    }

    public class Account
    {
        /// <summary>
        /// 账号的唯一标识
        /// </summary>
        [Key]
        public int AId { get; set; }
        /// <summary>
        /// 学号
        /// 登陆凭证
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 存储时采用 SHA256(原文+"X") 加密
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 姓名（中文）
        /// </summary>
        public string Name { get; set; }
        public string Gender { get; set; }
        /// <summary>
        /// 身份 管理员（0）或学生（1）
        /// </summary>
        public AccountRole Role { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
