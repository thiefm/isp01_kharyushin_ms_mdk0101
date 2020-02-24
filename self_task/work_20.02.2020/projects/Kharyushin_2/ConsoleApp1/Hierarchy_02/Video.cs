using System;

namespace ConsoleApp1.Hierarchy_02
{
    class Video : Content
    {
        private double length;

        public Video(string name, DateTime uploadtime, double length)
            : base(name, uploadtime)
        {
            this.length = length;
        }

        public override string ToString()
        {
            return $"{base.ToString()}; Продолжительность: {length}";
        }
    }
}
