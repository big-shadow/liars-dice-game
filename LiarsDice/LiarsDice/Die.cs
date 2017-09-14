using System;

namespace LiarsDice
{
    internal enum DieFace
    {
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6
    }

    internal class Die
    {
        private DieFace _dieFace;

        public DieFace DieFace
        {
            get { return _dieFace; }
        }

        public void Roll()
        {
            _dieFace = (DieFace)new Random().Next(1, 7);
        }
    }
}