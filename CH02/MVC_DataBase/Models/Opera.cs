using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Empty.Models
{
    public class Opera
    {
        [DisplayName("編號")]
        public int OperaID { get; set; } //語意標註

        [Required(ErrorMessage = "歌劇名稱不可以為空白")]//自訂錯誤訊息
        [StringLength(200)]//條件
        [DisplayName("歌劇名稱")]
        public string Title { get; set; }

        [DisplayName("年代")]
        [CheckYear_custom]
        //public int Year { get; set; }
        public int? Year { get; set; }  //將Year改成可接受Null

        [Required]
        [DisplayName("作者")]
        public string Composer { get; set; }

        //資料也可來自資料庫
        //Code First

    }
}