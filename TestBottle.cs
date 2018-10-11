
using System;
using System.Xml.Schema;

namespace FlaskeOppgaver
{
    public class TestBottle
    {
        public int Capacity { get; }
        public int Content { get; private set; }

        public TestBottle(int capacity)
        {
            Capacity = capacity;
        }

        public void FillToTopFromTap()
        {
            Content = Capacity;
        }

        public void Fill(int volume)
        {
            Content = Math.Min(Content + volume, Capacity);
        }

        public int FillToTop(TestBottle bottle1, TestBottle bottle2)
        {
            var volumeFilled = Capacity - Content;
            Content = Capacity;
            return volumeFilled;

        }

        public int Empty()
        {
            var content = Content;
            Content = 0;
            return content;
        }
    }
}
