namespace Assignment2;

public static class Extensions
{
    public static IEnumerable<int> Flatten<T>(IEnumerable<IEnumerable<T>> items) =>
      items.SelectMany(x => (IEnumerable<int>) x);

    public static int[] div7great42(int[] ys) =>
      ys.Where(x => (x % 7 == 0) && (x > 42)).ToArray();

    public static int[] leapyears(int[] ys) =>
        ys.Where(x => (x % 4 == 0) && ((x % 100 != 0) || (x % 400 == 0))).ToArray();
    
    public static bool IsSecure(Uri uri) =>
        uri.ToString().StartsWith("https");

    public static int WordCount(String input) =>
        input.Split(" ").Length; 
}
