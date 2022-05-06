using System.Linq;

namespace English.Web.Logic.Phonemes;

public interface IPhonemeFetcher
{
    public IEnumerable<String> GetPhonemes() => GetPhonemeDict().Keys.ToList();
    public Dictionary<String, String> GetPhonemeDict() => GetPhonemes().ToDictionary(phoneme => phoneme, phoneme => phoneme);
}
