using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region 摘要信息
/********************************************************************
 * Copyright (C) 2018 DCQTECH
 * 版权所有
 * Author:tangshiqiao
 * Create Date:2018/7/2 14:15:31
 * CLR版本:4.0.30319.42000
 * File Name:TimeHelper
 * Description: 输出格式化时间字符串
 * Revision History:
 * *** Modify:
 * *** 
********************************************************************/
#endregion

namespace ConsoleDemo.Common
{
    /// <summary>
    /// 输出格式化时间字符串
    /// </summary>
    public class TimeHelper
    {
        public static string PrintDate()
        {
            return DateTime.Now.ToString("yyyy-MM-dd");
        }

        public static string PrintTime()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }

        public static string PrintMillisecond()
        {
            return DateTime.Now.ToString("HH:mm:ss.ffff");
        }

        public static string PrintDateTime()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static string PrintDateTimeMillisecond()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff");
        }
    }
}
