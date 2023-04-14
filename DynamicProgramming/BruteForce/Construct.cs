namespace DynamicProgramming.BruteForce
{
    public class Construct
    {
        public static bool CanConstruct(string target, string[] wordBank)
        {
            if (target == "")
            {
                return true;
            }

            for (int i = 0; i < wordBank.Length; i++)
            {
                if (target.IndexOf(wordBank[i]) == 0)
                {
                    string suffix = target[wordBank[i].Length..];
                    if (CanConstruct(suffix, wordBank))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static int CountConstruct(string target, string[] wordBank)
        {
            if (target == "")
            {
                return 1;
            }

            int totalCount = 0;

            for (int i = 0; i < wordBank.Length; i++)
            {
                if (target.IndexOf(wordBank[i]) == 0)
                {
                    int numWaysForRest = CountConstruct(target[wordBank[i].Length..], wordBank);
                    totalCount += numWaysForRest;
                }
            }
            return totalCount;
        }

        public static List<List<string>> AllConstruct(string target, string[] wordBank)
        {
            if (string.IsNullOrEmpty(target))
            {
                return new List<List<string>> { new List<string>() };
            }

            List<List<string>> result = new();

            foreach (string word in wordBank)
            {
                if (target.StartsWith(word))
                {
                    string suffix = target[word.Length..];
                    List<List<string>> suffixWays = AllConstruct(suffix, wordBank);
                    List<List<string>> targetWays = new();

                    foreach (List<string> way in suffixWays)
                    {
                        List<string> newWay = new(way);
                        newWay.Insert(0, word);
                        targetWays.Add(newWay);
                    }

                    result.AddRange(targetWays);
                }
            }
            return result;
        }
    }
}
