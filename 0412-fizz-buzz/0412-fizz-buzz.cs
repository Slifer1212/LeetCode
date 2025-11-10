public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> fizzBuzz = new List<string>();


        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                fizzBuzz.Add("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                fizzBuzz.Add("Fizz");
            }
            else if (i % 5 == 0)
            {
                fizzBuzz.Add("Buzz");
            }
            else
            {
                fizzBuzz.Add(i.ToString());
            }
        }

        return fizzBuzz;
    }
}