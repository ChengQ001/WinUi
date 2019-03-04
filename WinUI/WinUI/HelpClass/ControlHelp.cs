using CCWin;
using CCWin.SkinControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WinUI.HelpClass
{
    public class ControlHelp
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str">输入内容</param>
        /// <param name="type">1数字或者小数</param>
        /// <param name="msg">提示语(什么框)</param>
        /// <returns></returns>
        public static bool Validate(string str, int type,string msg="")
        {
            var regexStr = "";
            switch (type)
            {
                case 1:
                    regexStr = @"^(-?\d+)(\.\d+)?$";
                    break;
                default:
                    break;
            }
            Regex regex = new Regex(regexStr);
            Match match = regex.Match(str);
            if (match.Success)
                return true;
            else
            {
                switch (type)
                {
                    case 1:
                        MessageBoxEx.Show(msg + "只能输入数字或者小数");
                        break;
                    default:
                        break;
                }
               
                return false;

            }
        }
    }
}
