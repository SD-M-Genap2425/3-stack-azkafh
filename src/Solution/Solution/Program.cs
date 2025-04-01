using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        HistoryManager history = new HistoryManager();

        history.KunjungiHalaman("google.com");
        history.KunjungiHalaman("example.com");
        history.KunjungiHalaman("stackoverflow.com");

        Console.WriteLine($"Halaman saat ini: {history.LihatHalamanSaatIni()}");

        Console.WriteLine("Kembali ke halaman sebelumnya...");
        string urlSebelumnya = history.Kembali();
        Console.WriteLine($"Halaman saat ini: {history.LihatHalamanSaatIni()}");

        history.TampilkanHistory();



        BracketValidator validator = new BracketValidator();

        string[] ekspresiValid = { "[{}](){}", "([]{[]})[]{{}()}" };
        string[] ekspresiInvalid = { "(]", "([)]", "{[}" };

        foreach (var ekspresi in ekspresiValid)
        {
            Console.WriteLine($"Ekspresi '{ekspresi}' valid? {validator.ValidasiEkspresi(ekspresi)}");
        }

        foreach (var ekspresi in ekspresiInvalid)
        {
            Console.WriteLine($"Ekspresi '{ekspresi}' valid? {validator.ValidasiEkspresi(ekspresi)}");
        }



        string[] text = { "Kasur ini rusak", "Ibu Ratna antar ubi", "Hello World" };

        foreach (var testCase in text)
        {
            bool result = PalindromeChecker.CekPalindrom(testCase);
            Console.WriteLine($"Input: \"{testCase}\"\nOutput: {result}\n");
        }

    }
}
