
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

        public int Empty()
        {
            var content = Content;
            Content = 0;
            return content;
        }

        public void FillToTop(TestBottle bottle)
        {
            var fullBottle = Capacity - Content;
            var realFillVolume = Math.Min(fullBottle, bottle.Content);
            Content += realFillVolume;
            bottle.Content -= realFillVolume;

        }

    }
}
