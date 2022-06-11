namespace English.Web.Model;

public class InputTextModel
{
    public TextModel OriginalText { get; } = new("Original", Hidden: false);
    public TextModel PhonemeText { get; } = new("Phoneme");
    public String Language = String.Empty;
}
