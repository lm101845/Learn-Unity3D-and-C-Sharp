using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 
/// </summary>
/// <remarks>
/// <para/>Author   :  LiMing
/// <para/>Date     :  2021-07-03 11:54
/// </remarks>
namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {//*************程序从本行开始执行********************
            //自上而下逐语句执行
            //注释:给人看的
            //代码:对计算机下达的指令
            //字面意思：控制台.写一行
            //现象：在控制台中显示括号内的文本 
            //作用：将括号中的文本写到控制台中
            //Console.WriteLine("你好，世界");
            Console.WriteLine("请输入您的姓名：");

            //字面意思：控制台读一行
            //现象：暂停程序(按回车键继续)
            //作用：将用户在控制台中输入的文本读取到程序中来
            //Console.ReadLine();
            String name = Console.ReadLine();
            Console.WriteLine("您好:" + name);
            Console.ReadLine();  //让程序在本行暂停

            //=是赋值号，将右边的结果复制一份给左边
            //写代码.cs ——>生成——>exe——>运行
            //*************程序从本行开始结束********************
        }
    }
}
