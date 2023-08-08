namespace AbstractClassesAndInterfaces
{
    public class Array : IOutput, IMath, ISort
    {
        private int[] numbers;
        public Array(int[] numbers) => this.numbers = numbers;
        public void Show()
        {
            foreach (int n in numbers)
                Console.WriteLine(n);
        }

        public void Show(string info)
        {
            Console.WriteLine($"{info}");
            Show();
        }

        public int Max()
        {
            int max = int.MinValue;
            foreach (var i in numbers)
                if (i > max)
                    max = i;

            return max;
        }

        public int Min()
        {
            int min = int.MaxValue;

            foreach (var i in numbers)
                if (i < min)
                    min = i;

            return min;
        }

        public float Avg()
        {
            int sum = 0;

            foreach (int number in numbers)
                sum += number;

            return (float)sum / numbers.Length;
        }

        public bool Search(int valueToSearch)
        {
            foreach (int number in numbers)
                if (number == valueToSearch) return true;
            return false;
        }

        public void SortAsc()
        {
            SortByParam(true);
        }
        public void SortDesc()
        {
            SortByParam(false);
        }

        public void SortByParam(bool isAsc)
        {
            int i, j, k;
            int elem;

            for (i = 0; i < numbers.Length; i++)
            {
                k = i;
                elem = numbers[i];

                for (j = i + 1; j < numbers.Length; j++)
                    if (isAsc)
                    {
                        if (numbers[j].CompareTo(elem) < 0)
                        {
                            k = j;
                            elem = numbers[j];
                        }
                    }
                    else
                    {
                        if (numbers[j].CompareTo(elem) > 0)
                        {
                            k = j;
                            elem = numbers[j];
                        }
                    }

                numbers[k] = numbers[i];
                numbers[i] = elem;
            }
            Show();
        }
    }
}
