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
 * Create Date:2018/7/3 19:32:54
 * CLR版本:4.0.30319.42000
 * File Name:ReadonlySingleton2
 * Description: 饿汉式单例类，静态初始化单例类示例2
 * *** 1.sealed表明该单例类不可被继承；
 * *** 2.私有化构造函数使得该单例类不可通过new的方式创建实例，也不可被继承；
 * *** 3.readonly Instance确保只有一个实例；
 * *** 4.类被加载时就创建实例，会提前占用系统资源，称为“饿汉式单例类”，但不会像“懒汉式”那样有额外的加锁开销；
 * *** 5.为使不提前占用系统资源，稍作改动即可
 * Revision History:
 * *** Modify:
 * *** 
********************************************************************/
#endregion

namespace ConsoleDemo.Singleton
{
    public sealed class ReadonlySingleton2
    {
        #region 字段

        public int normalX = SetValue(staticX);

        public static int staticX = 1;

        #endregion

        #region 单例

        /// <summary>
        /// 静态初始化单例，只有通过这种写法并且调用这个字段方能是饿汉式单例
        /// </summary>
        private static readonly ReadonlySingleton2 _instance = new ReadonlySingleton2();
        /// <summary>
        /// 私有化构造函数，使得类不可通过new来创建实例
        /// </summary>
        private ReadonlySingleton2()
        {
            Console.WriteLine($"normalX={normalX}");
            Console.WriteLine($"staticX={staticX}");
            Console.WriteLine($"normalY={normalY}");
            Console.WriteLine($"staticY={staticY}");
        }

        //写法1：通过属性获取实例
        public static ReadonlySingleton2 Instance
        {
            get { return _instance; }
        }

        //写法2：通过方法获取实例
        public static ReadonlySingleton2 GetInstance()
        {
            return _instance;
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
