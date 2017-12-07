namespace CodeWarsCollection.CreditCardMask
{
    public static class Kata
    {
        // return masked string
        public static string Maskify(string cc) => string.IsNullOrWhiteSpace(cc) || cc.Length <= 4 ? cc : new string('#', cc.Length - 4) + cc.Substring(cc.Length - 4, 4);

        //public static string Maskify(string cc)
        //{
        //    return string.IsNullOrWhiteSpace(cc) || cc.Length <= 4 ? cc : new string('#', cc.Length - 4) + cc.Substring(cc.Length - 4, 4);
        //}
    }
}
