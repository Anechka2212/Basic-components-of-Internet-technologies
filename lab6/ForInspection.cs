﻿namespace Lab6_2_
{
    class ForInspection
    {
        public ForInspection() { }
        public ForInspection(int i) { }
        public ForInspection(string str) { }

        public int Plus(int x, int y) { return x + y; }
        public int Multiply(int x, int y) { return x * y; }

        [New("Description for property1")]
        public string property1
        {
            get { return _property1; }
            set { _property1 = value; }
        }
        private string _property1;

        public int property2 { get; set; }

        [New(Description = "Description for property3")]
        public double property3 { get; private set; }
        public int field1;
        public float field2;
    }
}

