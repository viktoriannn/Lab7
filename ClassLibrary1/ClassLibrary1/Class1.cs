namespace ClassLibrary1
{
    public class CMassive
    {
        private double[] mass;
        //конструкторы
        public CMassive(int length)
        {
            mass = new double[length];
        }
        public CMassive(double[] massValue)
        {
            mass = new double[massValue.Length];
            mass = massValue;
        }
        //длина массива
        public int getLengthMass
        {
            get { return mass.Length; }
        }
        //индексатор
        public double this[int i]
        {
            get { return mass[i]; }
            set { mass[i] = value; }
        }
        //кол-во отрицательных эл-ов
        public int GetCount()
        {
            int count = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < 0) count++;
            }
            return count;
        }
        //кол-во эл-ов после индекса
        public int GetCount(int position)
        {
            int count = mass.Length - 1 - position;
            return count > 0 ? count : 0;
        }
        //кол-во эл-ов больших числа
        public int GetCount(double threshold)
        {
            int count = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < 0 && mass[i] > threshold)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
