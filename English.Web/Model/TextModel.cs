namespace English.Web.Model;

public record class TextModel(String Label, String Text = "", Boolean Hidden = true)
{
    public Boolean Hidden { get; set; } = Hidden;
    public String Text { get; set; } = Text;
}
