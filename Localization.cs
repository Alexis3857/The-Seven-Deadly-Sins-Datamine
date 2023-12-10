using _7dsgcDatamine;

public static class Localization
{
    public static string Localize(this int si)
    {
        return Localizer.GetString(si.ToString());
    }

    public readonly static StringLocalize Localizer = new StringLocalize();
}