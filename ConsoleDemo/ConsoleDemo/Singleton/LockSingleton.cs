using System;


#region 摘要信息
/********************************************************************
 * Copyright (C) 2018 DCQTECH
 * 版权所有
 * Author:tangshiqiao
 * Create Date:2018/7/2 14:11:34
 * CLR版本:4.0.30319.42000
 * File Name:LockSingleton
 * Description: 多线程安全单例模式示例
 * *** 1.sealed表明该单例类不可被继承；
 * *** 2.私有化构造函数使得该单例类不可通过new的方式创建实例，也不可被继承；
 * *** 3.加锁使得多线程可以安全创建实例；
 * *** 4.加锁前进行判断可减少加锁的次数，提高性能；
 * *** 5.加锁后还需进行非空判断，防止两个线程同时读锁时都判定实例为空，那么第一个线程结束后第二个线程还以为实例为空，这样就会创建不只一个实例；
 * *** 6.如此只有在程序第一次访问时才创建实例，此法被称为 “懒汉式单例类”，但缺点是加锁增加了系统开销
 * Revision History:
 * *** Modify:
 * *** 
********************************************************************/
#endregion

namespace ConsoleDemo.Singleton
{
    /// <summary>
    /// 多线程安全单例模式示例
    /// </summary>
    public sealed class LockSingleton
    {
        #region 字段

        public int normalX = SetValue(staticX);

        public static int staticX = 1;

        #endregion

        #region 单例

        private static LockSingleton _instance;
        private static readonly object lockObj = new object();
        /// <summary>
        /// 私有化构造函数，使得类不可通过new来创建实例
        /// </summary>
        private LockSingleton()
        {
            Console.WriteLine($"normalX={normalX}");
            Console.WriteLine($"staticX={staticX}");
            Console.WriteLine($"normalY={normalY}");
            Console.WriteLine($"staticY={staticY}");
        }

        //写法1：通过属性获取实例
        public static LockSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (lockObj)
                    {
                        if (_instance == null)
                        {
                            _instance = new LockSingleton();
                        }
                    }
                }
                return _instance;
            }
        }

        //写法2：通过方法获取实例
        public static LockSingleton GetInstance()
        {
            //这里可以copy属性Instance中的代码
            return Instance;
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
