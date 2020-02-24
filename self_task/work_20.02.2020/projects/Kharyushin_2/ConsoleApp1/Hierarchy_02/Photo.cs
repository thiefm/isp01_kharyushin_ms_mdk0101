using System;

namespace ConsoleApp1.Hierarchy_02
{
    class Photo : Content
    {
        private string whoisonpicture;

        public Photo(string name, DateTime uploadtime, string whoisonpicture)
            : base(name, uploadtime)
        {
            this.whoisonpicture = whoisonpicture;
        }

        public override string ToString()
        {
            return $"{base.ToString()}; Загрузил: {whoisonpicture}";
        }
    }
}
