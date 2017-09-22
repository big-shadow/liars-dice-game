namespace LiarsDice
{
    public enum DieFace
    {
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6
    }

    public class Die
    {
        private DieFace _dieFace;

        public DieFace DieFace
        {
            get { return _dieFace; }
        }

        public void Roll()
        {
            _dieFace = (DieFace)RandomNumber.Between(1, 6);
        }
    }
}