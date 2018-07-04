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
 * Create Date:2018/7/3 20:29:51
 * CLR版本:4.0.30319.42000
 * File Name:LazySingleton
 * Description: 使用Lazy创建单例类示例
 * *** 1.sealed表明该单例类不可被继承；
 * *** 2.私有化构造函数使得该单例类不可通过new的方式创建实例，也不可被继承；
 * *** 3.readonly _instance确保只有一个实例；
 * *** 4.第一次使用时创建类的实例，不会提前占用系统资源
 * Revision History:
 * *** Modify:
 * *** 
********************************************************************/
#endregion

namespace ConsoleDemo.Singleton
{
    /// <summary>
    /// 使用Lazy创建单例类示例
    /// </summary>
    public sealed class LazySingleton
    {
        #region 字段

        public int normalX = SetValue(staticX);

        public static int staticX = 1;

        #endregion

        #region 单例
        private static readonly Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(() => new LazySingleton());

        private LazySingleton()
        {
            Console.WriteLine($"normalX={normalX}");
            Console.WriteLine($"staticX={staticX}");
            Console.WriteLine($"normalY={normalY}");
            Console.WriteLine($"staticY={staticY}");
        }

        //写法1：通过属性获取实例
        public static LazySingleton Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        //写法2：通过方法获取实例
        public static LazySingleton GetInstance()
        {
            return _instance.Value;
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
