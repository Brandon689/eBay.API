public static class DateTimeStr
{
    public static string Format(DateTime dateTime)
    {
        return dateTime.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffZ");
    }
}