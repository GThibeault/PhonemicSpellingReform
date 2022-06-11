namespace English.Web.Model.Requests;

public record class PhonemizeRequest(List<String> text, String? language = null);