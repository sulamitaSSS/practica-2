
namespace _19._10
{
    public class calkylator
    {
        private int x, y;
        public calkylator(int xKorobka, int yKorobka)
        {
            x = xKorobka;
            y = yKorobka;
        }
        public int Plus()
        {
            return x + y;
        }
        public int Minus()
        {
            return x - y;
        }
        public int Del()
        {
            return x / y;
        }
        public int Umnoj()
        {
            return x * y;
        }
    }
}
