using System;

namespace Reflection
{
    
    public class ForInspection : IComparable /// Класс для исследования с помощью рефлексии
    {
        public ForInspection() { }
        public ForInspection(int i) { }
        public ForInspection(string str) { }

        public int Plus(int x, int y) { return x + y; }
        public int Minus(int x, int y) { return x - y; }

        [NewAttribute("Описание для property1")]
        public string property1
        {
            get { return _property1; }
            set { _property1 = value; }
        }
        private string _property1;

        public int property2 { get; set; }

        [NewAttribute(Description = "Описание для property3")]
        public double property3 { get; private set; }

        public int field1;
        public float field2;

        
        public int CompareTo(object obj) /// Реализация интерфейса IComparable
        {
            return 0;
        }
    }
}
