class Progarm
{
    static void Main(string[] args)
    {

    }
}
public class Solution
{
    public IList<IList<int>> GroupThePeople(int[] groupSizes)
    {
        Dictionary<int,List<int>> dictionary = new Dictionary<int,List<int>>();
        for (int i = 0; i < groupSizes.Length; i++)
        {
            if (!dictionary.ContainsKey(groupSizes[i]))
            {
                dictionary[groupSizes[i]] = new List<int>();
            }
            dictionary[groupSizes[i]].Add(i);
        }
        IList<IList<int>> result = new List<IList<int>>();
        foreach (var list in dictionary)
        {
            int key = list.Key;
            List<int> current = new List<int>();
            result.Add(current);
            for (int i = 0; i < list.Value.Count; i++)
            {
                if(current.Count == key)
                {
                    current = new List<int>();
                    result.Add(current);
                }
                current.Add(list.Value[i]);
            }
        }
        return result;
    }
}