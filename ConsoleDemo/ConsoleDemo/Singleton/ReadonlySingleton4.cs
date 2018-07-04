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
 * Create Date:2018/7/3 20:15:33
 * CLR版本:4.0.30319.42000
 * File Name:ReadonlySingleton4
 * Description: 通过内部类创建单例实例，可以达到延迟加载的目的
 * Revision History:
 * *** Modify:
 * *** 
********************************************************************/
#endregion

namespace ConsoleDemo.Singleton
{
    public sealed class ReadonlySingleton4
    {
        #region 字段

        public int normalX = SetValue(staticX);

        public static int staticX = 1;

        #endregion

        #region 单例
        private class InnerInstance
        {
            internal static ReadonlySingleton4 _instance = new ReadonlySingleton4();
        }

        private ReadonlySingleton4()
        {
            Console.WriteLine($"normalX={normalX}");
            Console.WriteLine($"staticX={staticX}");
            Console.WriteLine($"normalY={normalY}");
            Console.WriteLine($"staticY={staticY}");
        }

        public static ReadonlySingleton4 Instance
        {
            get { return InnerInstance._instance; }
        }

        public static ReadonlySingleton4 GetInstance()
        {
            return InnerInstance._instance;
        }
        #endregion

        #region 其他

        public int normalY = SetValue(staticY);

        public static int staticY = 1;

        private static int SetValue(int val)
        {
            return val;
        }

        #endregion
    }
}
