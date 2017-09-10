using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_DataBaseContext.Models
{
    public class CheckValidYear : ValidationAttribute
    {
        public CheckValidYear()
        {
            ErrorMessage = "The earliest opera is Daphne, 1598, by Corsi, Peri, and Rinuccini";
        }

        public override bool IsValid(object value)
        {
            int year = (int)value;

            if (year >= 2017)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

    }
}