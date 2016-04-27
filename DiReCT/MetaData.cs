using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Reflection;


namespace DiReCT
{
    // An enumeration of disasters. Start at 1 (0 = uninitialized).
    public enum Disaster
    {
        // Disasters
        Flood = 1,
        Landslide,
        Fire,
    }
    
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    // 一個自訂的 attribute 能允許目標物定義一個 type (繼承 Attribute 類別)
    public class DisasterTypeAttribute : Attribute
    {
        // constructor
        public DisasterTypeAttribute(Disaster type)
        {
            theType = type;
        }
        // 內部變數
        protected Disaster theType;
        // 公開的屬性
        public Disaster Type
        {
            get { return theType; }
            set { theType = Type; }
        }
    }

    // 一個測試類別，在每個方法上都定義一個它屬於的 type
    class DisasterTypeTestClass
    {
        [DisasterType(Disaster.Flood)]
        public void FloodMethod() { }

        [DisasterType(Disaster.Landslide)]
        public void Landslidemethod() { }

        [DisasterType(Disaster.Fire)]
        public void FireMethod() { }
    }

    
    class DemoClass
    {
        
        static void Main(string[] args)
        {
            DisasterTypeTestClass testClass = new DisasterTypeTestClass();
            Type type = testClass.GetType();

            // 將 DisasterTypeTestClass 的方法透過 foreach 全部取出
            foreach (MethodInfo mInfo in type.GetMethods())
            {
                // 將每一個 function 透過 foreach 取得 attribute 的集合
                foreach (Attribute attr in
                    Attribute.GetCustomAttributes(mInfo))
                {
                    // 檢查是否為 DisasterType 的資料型態如果是將它列印出來
                    if (attr.GetType() == typeof(DisasterTypeAttribute))
                        Console.WriteLine(
                            "Method {0} has a type {1} attribute.",
                            mInfo.Name, ((DisasterTypeAttribute)attr).Type);
                }

            }
        }
    }
}


