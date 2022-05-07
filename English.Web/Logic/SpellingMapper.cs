namespace English.Web.Logic;

public class SpellingMapper
{
    public IEnumerable<String> BuildResultText(Dictionary<String, String> phonemeMapping, String text)
    {
        Int32 maxLength = GetMaxClusterLength(phonemeMapping);
        Int32 index = 0;

        List<String> textMapping = new();

        while (index < text.Length)
        {
            IEnumerable<Int32> range = Enumerable.Range(0, Math.Min(maxLength, text.Length - index));
            IEnumerable<String> clusters = range.Select(clusterIndex => text[index..(index + 1 + clusterIndex)]);

            List<String> matchingClusters = clusters.Reverse<String>().Where(phonemeMapping.ContainsKey).ToList();
            String? tentativeMapping = matchingClusters.Select(cluster => phonemeMapping[cluster]).FirstOrDefault();

            String mapping = tentativeMapping ?? text[index].ToString();
            index += matchingClusters.FirstOrDefault()?.Length ?? 1;

            textMapping.Add(mapping);
        }

        String joinedText = String.Join(String.Empty, textMapping);
        IEnumerable<String> resultLines = joinedText.Split(Environment.NewLine);

        return resultLines;
    }

    private Int32 GetMaxClusterLength(Dictionary<String, String> phonemeMapping) => phonemeMapping.Keys.Max(cluster => cluster.Length);
}
