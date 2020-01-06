using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDS006.IDictionaryDemo
{
    class Program
    {
        static void Main()
        {
            // 创建字典并添加元素
            IDictionary d = new SimpleDictionary(3);
            d.Add("小明", 40);
            d.Add("张三", 34);
            d.Add("小李", 1);

            Console.WriteLine("字典中的元素数量 = {0}", d.Count);
            Console.WriteLine("字典元素是否包含 '张三'? {0}", d.Contains("张三"));
            Console.WriteLine("韦小宝的年龄是 {0}", d["张三"]);

            // 显示所有的 key/value 对
            foreach (DictionaryEntry de in d)
            {
                Console.WriteLine("{0} 的年龄是 {1} 。", de.Key, de.Value);
            }

            // 移除：字典中有的
            d.Remove("张三");

            // 移除：字典中没有的
            d.Remove("王五");

            foreach (String s in d.Keys)
                Console.WriteLine(s);

            foreach (Int32 age in d.Values)
                Console.WriteLine(age);

            Console.ReadKey();
        }
    }
}
