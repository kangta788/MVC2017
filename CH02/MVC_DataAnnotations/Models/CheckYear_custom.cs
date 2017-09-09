using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Empty.Models
{

    //自訂驗證 
    public class CheckYear_custom:ValidationAttribute //一定要繼承這個
    {
        //1.驗證邏輯
        public override bool IsValid(object value)
        {
            int year = (int)value;

            if (year > 2017)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        //2.自訂錯誤訊息 建構子
        public CheckYear_custom()
        {
            ErrorMessage = "年分不可以是未來 請注意!";
        }


    }
}