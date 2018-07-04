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
 * Create Date:2018/7/2 15:20:02
 * CLR版本:4.0.30319.42000
 * File Name:ReadonlySingleton
 * Description: 饿汉式单例类，静态初始化单例类示例1
 * *** 1.sealed表明该单例类不可被继承；
 * *** 2.私有化构造函数使得该单例类不可通过new的方式创建实例，也不可被继承；
 * *** 3.readonly Instance确保只有一个实例；
 * *** 4.类被加载时就创建实例，会提前占用系统资源，称为“饿汉式单例类”，但不会像“懒汉式”那样有额外的加锁开销；
 * *** 5.为使不提前占用系统资源，稍作改动即可，详见ReadonlySingleton2
 * Revision History:
 * *** Modify:
 * *** 
********************************************************************/
#endregion

namespace ConsoleDemo.Singleton
{
    /// <summary>
    /// 饿汉式单例类，静态初始化单例类示例1
    /// </summary>
    public sealed class ReadonlySingleton
    {
        #region 字段

        public int normalX = SetValue(staticX);

        public static int staticX = 1;

        #endregion

        #region 单例
        /// <summary>
        /// 静态初始化单例，只有通过这种写法并且调用这个字段方能是饿汉式单例
        /// </summary>
        public static readonly ReadonlySingleton Instance = new ReadonlySingleton();

        /// <summary>
        /// 私有化构造函数，使得类不可通过new来创建实例
        /// </summary>
        private ReadonlySingleton()
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
