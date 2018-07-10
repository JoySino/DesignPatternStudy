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
 * Create Date:2018/7/3 19:44:57
 * CLR版本:4.0.30319.42000
 * File Name:ReadonlySingleton3
 * Description: 添加静态构造函数，可以达到延迟加载的目的
 * Revision History:
 * *** Modify:
 * *** 
********************************************************************/
#endregion

namespace ConsoleDemo.Singleton
{
    public sealed class ReadonlySingleton3
    {
        #region 字段

        public int normalX = SetValue(staticX);

        public static int staticX = 1;

        #endregion

        #region 单例
        /// <summary>
        /// 静态初始化单例，只有通过这种写法并且调用这个字段方能是饿汉式单例
        /// </summary>
        public static readonly ReadonlySingleton3 Instance = new ReadonlySingleton3();

        /// <summary>
        /// 定义一个静态构造函数，使得静态字段在调用的时候才被初始化
        /// </summary>
        static ReadonlySingleton3()
        {
            Console.WriteLine("ReadonlySingleton3____Static");
        }
        /// <summary>
        /// 私有化构造函数，使得类不可通过new来创建实例
        /// </summary>
        private ReadonlySingleton3()
        {
            Console.WriteLine($"normalX={normalX}");
            Console.WriteLine($"staticX={staticX}");
            Console.WriteLine($"normalY={normalY}");
            Console.WriteLine($"staticY={staticY}");
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
