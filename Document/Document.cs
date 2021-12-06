using System;

namespace FileApi
{
    public class Document
    {
        public Document()
        {

        }

        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }
        public int Category { get; set; }

        public bool Upload()
        {
            return false;
        }

        public bool Download(int id)
        {
            return false;
        }
    }
}