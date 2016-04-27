using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;


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

    // 一個自訂的 attribute 能允許目標物定義一個 type (繼承 Attribute 類別)
    public class DisasterTypeAttribute : Attribute
    {
        // 當這個 attribute 被設定時，這個建構子(constructor)會被呼叫
        public DisasterTypeAttribute(Disaster type)
        {
            theType = type;
        }

        // 設定一個內部的變數
        protected Disaster theType;

        // 設定一個公開的屬性...
        public Disaster Type
        {
            get { return theType; }
            set { theType = Type; }
        }
    }

    // 一個測試類別，在每個方法上都定義一個它屬於的 type
    class DisasterlTypeTestClass
    {
        [DisasterType(Disaster.Flood)]
        public void FloodMethod() { }

        [DisasterType(Disaster.Landslide)]
        public void Landslidemethod() { }

        [DisasterType(Disaster.Fire)]
        public void FireMethod() { }
    }

    //以下示範如何使用 attribute
    class DemoClass
    {
        //以下用 Console 模式下運作
        static void Main(string[] args)
        {
            DisasterlTypeTestClass testClass = new DisasterlTypeTestClass();
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


