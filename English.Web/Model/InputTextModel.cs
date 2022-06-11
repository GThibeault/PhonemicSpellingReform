namespace English.Web.Model;

public class InputTextModel
{
    public TextModel OriginalText { get; } = new("Original");
    public TextModel PhonemeText { get; } = new("Phoneme");
    public String Language = String.Empty;
}
