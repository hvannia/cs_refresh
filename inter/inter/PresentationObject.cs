using System;

namespace inter
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Obj copied to clipboard");
        }

        public void Duplicate()
        {
            Console.WriteLine("object duplicated");
        }
    }
}
