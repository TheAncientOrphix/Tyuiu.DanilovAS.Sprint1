using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DanilovAS.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return string.Empty;

            char[] delimiters = { ' ', '.', ',', '!', '?', ':', ';', '\t', '\n', '\r', '(', ')', '[', ']', '"', '\'' };
            string[] words = value.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            var processedWords = words.Select(word =>
            {
                if (word.Length % 2 == 1) // нечётная длина
                {
                    int midIndex = word.Length / 2;
                    return word.Remove(midIndex, 1);
                }
                return word;
            });
            return string.Join(" ", processedWords);
        }

            
    }
}
