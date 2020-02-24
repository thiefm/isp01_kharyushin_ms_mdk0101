using System;

namespace ConsoleApp1.Hierarchy_02
{
    abstract class Content
    {
        private static int counter = 0;
        private int id;

        private string name;
        private DateTime uploadtime;

        public Content(string name, DateTime uploadtime)
        {
            id = counter;
            counter++;
            this.name = name;
            this.uploadtime = uploadtime;
        }

        public override string ToString()
        {
            return $"ID: {id}; Имя: {name}; Время загрузки: {uploadtime}";
        }
    }
}
