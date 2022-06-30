using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerApp
{
    public class Roller
    {
        Random random = new Random();
        public string Roll(int num1, int num2)
        {
            int result = 0;
            int[] arr = new int[num1];

            for (int i = 0; i < num1; i++)
            {
                arr[i] = random.Next(1, num2 + 1);
                result += arr[i];
            }
            Array.Sort(arr);

            return $"Total: {result} Rolls: {String.Join(" ", arr)}";
        }

        public string RollDropLowest(int num1, int num2)
        {
            int result = 0;
            int[] arr = new int[num1];

            for (int i = 0; i < num1; i++)
            {
                arr[i] = random.Next(1, num2 + 1);
            }
            Array.Sort(arr);

            for (int i = 1; i < num1; i++)
            {
                result += arr[i];
            }

            return $"Total: {result}  Rolls: {String.Join(" ", arr)}";
        }



    }
}
