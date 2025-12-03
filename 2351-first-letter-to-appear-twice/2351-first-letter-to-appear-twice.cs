public class Solution {
    public char RepeatedCharacter(string s) {
         HashSet<char> set = new HashSet<char>();
        foreach (char c in s)
        {
            if (!set.Contains(c))
            {
                set.Add(c);
            }
            else
            {
                return c;
            }
        }
        return '\0';

    }
}