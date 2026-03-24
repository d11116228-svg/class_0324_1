namespace Class_0324_1
{
    public class Test
    {
        private int Mid;
        private const int Final = 99;

        // 1 個參考
        public int MyMid { get; } = 56;

        // 2 個參考
        public int MyFinal
        {
            get
            {
                return Final;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    //Final = value;
                }
                else
                {
                    //Final = 0;
                }
            }
        }
    }