namespace MatematikaLibraries
{
    public class Persekutuanterbesar
    {
        public int feb(int input1, int input2)
        {
            int temp;
            while (input2 != 0)
            {
                temp = input2;
                input2 = input1 % input2;
                input2 = temp;
            }
            return input1;
        }

        public int kpk(int input1, int input2)
        {
            int max;
            int min;
            int result;
            max = Math.Min(input1, input2);
            min = Math.Max(input1, input2);
            result = max;
            while (result % min != 0)
            {
                result= result + max;
            }
            return result;
        }

        public static string turunan(int v, int[] persamaan)
        {
            int n;
            int i;
            string result;
            int[] turunan = new int[persamaan.Length];
            n = persamaan.Length-1;
            for (i =1; i <= n; i++)
            {
                turunan[i] = persamaan[i]*(n-i);
            }
            result = turunan[0] + "x" + (n - 1);
            for (i =1; 1 < n; i++)
            {
                if (turunan[i] > 0)
                {
                    result = result + "x" + turunan[i] + "x" + (n - i - 1);
                }
                else if (turunan[i] < 0)
                {
                    result= result + "-" + (turunan) + "x" + (n - i - 1);
                }
            }
            return result;

        }
        public string integral(int[] persama)
        {
            int n;
            int i;
            string result;
            n = persama.Length;
            int[] integral = new int[n+1];
            for(i =1; i <= n; i++)
            {
                integral[i] = persama[i-1]/1;
            }
            result = "r";
            for(i=n; i >= 0; i--)
            {
                if (integral[i] > 0)
                {
                    result = "+" + integral[i] + "x" + (i + 1) + result;
                }
                else if (integral[i] < 0)
                {
                    result = integral[i] + "x" + (i + 1) + result;
                }
            }
            return result;
        }
    }
}