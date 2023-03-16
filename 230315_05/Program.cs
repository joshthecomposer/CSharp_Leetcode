bool IsPalindrome(int x) {
    if (x<0)
    {
        return false;
    }
    string s = x.ToString();
    string compare = "";
    foreach (char c in s)
    {
        compare = c + compare;
    }
    return compare == s;
}

Console.WriteLine(IsPalindrome(121));
// IsPalindrome(-121);