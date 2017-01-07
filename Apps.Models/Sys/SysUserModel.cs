/**
* 命名空间: Apps.Models
* 功 能： N/A
* 类 名： SysUserModel
* 创建时间： 2017/1/5 22:27:31 
* 创建人：小强
* 电子邮箱：371711105@qq.com
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Models.Sys
{
    public class SysUserModel
    {
        [MaxLength(50)]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [MaxLength(200)]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [MaxLength(200)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [MaxLength(200)]
        [Display(Name = "TrueName")]
        public string TrueName { get; set; }

        [MaxLength(50)]
        [Display(Name = "Card")]
        public string Card { get; set; }

        [MaxLength(200)]
        [Display(Name = "身份证")]
        public string MobileNumber { get; set; }

        [MaxLength(200)]
        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }

        [MaxLength(50)]
        [Display(Name = "QQ")]
        public string QQ { get; set; }

        [MaxLength(200)]
        [Display(Name = "EmailAddress")]
        public string EmailAddress { get; set; }

        [MaxLength(200)]
        [Display(Name = "OtherContact")]
        public string OtherContact { get; set; }

        [MaxLength(200)]
        [Display(Name = "Province")]
        public string Province { get; set; }

        [MaxLength(200)]
        [Display(Name = "City")]
        public string City { get; set; }

        [MaxLength(200)]
        [Display(Name = "Village")]
        public string Village { get; set; }

        [MaxLength(200)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "State")]
        public bool State { get; set; }

        [Display(Name = "CreateTime")]
        public DateTime CreateTime { get; set; }

        [MaxLength(200)]
        [Display(Name = "CreatePerson")]
        public string CreatePerson { get; set; }

        [MaxLength(10)]
        [Display(Name = "Sex")]
        public string Sex { get; set; }

        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }

        [Display(Name = "JoinDate")]
        public DateTime JoinDate { get; set; }

        [MaxLength(10)]
        [Display(Name = "婚姻")]
        public string Marital { get; set; }

        [MaxLength(50)]
        [Display(Name = "党派")]
        public string Political { get; set; }

        [MaxLength(20)]
        [Display(Name = "民族")]
        public string Nationality { get; set; }

        [MaxLength(20)]
        [Display(Name = "籍贯")]
        public string Native { get; set; }

        [MaxLength(50)]
        [Display(Name = "毕业学校")]
        public string School { get; set; }

        [MaxLength(100)]
        [Display(Name = "就读专业")]
        public string Professional { get; set; }

        [MaxLength(20)]
        [Display(Name = "学历")]
        public string Degree { get; set; }

        [MaxLength(50)]
        [Display(Name = "部门")]
        public string DepId { get; set; }

        [MaxLength(50)]
        [Display(Name = "职位")]
        public string PosId { get; set; }

        [MaxLength(3000)]
        [Display(Name = "个人简介")]
        public string Expertise { get; set; }

        [MaxLength(20)]
        [Display(Name = "在职状况")]
        public string JobState { get; set; }

        [MaxLength(200)]
        [Display(Name = "照片")]
        public string Photo { get; set; }

        [MaxLength(200)]
        [Display(Name = "附件")]
        public string Attach { get; set; }

        [MaxLength(50)]
        [Display(Name = "Flag")]
        public string Flag { get; set; }

    }
}
