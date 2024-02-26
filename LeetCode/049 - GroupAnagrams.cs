public class GroupAnagram
{
    string[] strings = { "eat", "tea", "tan", "ate", "nat", "bat" };
    IList<IList<string>> list;

    public void Execute()
    {
        list = GroupAnagrams(strings);

        foreach (var item in list)
        {
            Console.WriteLine(string.Join(",", item));
        }
    }

    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string sorted = new string(chars);

            if (!anagrams.ContainsKey(sorted)) anagrams[sorted] = new List<string>();

            anagrams[sorted].Add(str);
        }

        return anagrams.Select(x => x.Value).ToList<IList<string>>();
    }
}