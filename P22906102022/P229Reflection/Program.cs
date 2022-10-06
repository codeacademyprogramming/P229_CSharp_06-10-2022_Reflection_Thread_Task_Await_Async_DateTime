using System;
//using P229reflectionLibrary;
using System.Reflection;

namespace P229Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region typeof() and GetType()
            //int a = 5;
            //long b = 564;

            //object[] arr = { "string", 15, b };

            //foreach (var item in arr)
            //{
            //    Type type = item.GetType();
            //    Type type1 = typeof(int);

            //    if (item.GetType().Equals(type1))
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //Console.WriteLine(typeof(int));
            //Console.WriteLine(typeof(long));

            //Console.WriteLine(a.GetType());
            //Console.WriteLine(b.GetType());

            #endregion

            Assembly assembly = Assembly.LoadFrom(@"C:\Users\hamid.mammadov\Desktop\P229reflectionLibrary\P229reflectionLibrary\bin\Debug\netcoreapp3.1\P229reflectionLibrary.dll");

            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                //Console.WriteLine(type.FullName);
                //Console.WriteLine(type.Name);

                if (type.Name == "Human")
                {
                    MemberInfo[] memberInfos = type.GetMembers(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static);

                    foreach (MemberInfo memberInfo in memberInfos)
                    {
                        //Console.WriteLine($"{memberInfo.Name} {memberInfo.MemberType}");

                        if (memberInfo.Name == "ShowInfo")
                        {
                            MethodInfo methodInfo = type.GetMethod("ShowInfo", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static);
                            var ins = Activator.CreateInstance(type);

                            object[] parametrs = { "P229 Reflection" };

                            methodInfo.Invoke(ins, parametrs);
                        }
                    }
                }
            }
        }
    }
}
