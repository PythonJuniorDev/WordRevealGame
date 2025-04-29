namespace WordReveal
{
    public class Program
    {
        static void Main()
        {
            string hiddenWord = "HelloWorld".ToLower(); // Word to guess

            HashSet<char> guessedLetters = new HashSet<char>(); // Store guessed letters

            Console.WriteLine("\nWelcome to Word Reveal.");
            Console.WriteLine("\nTry guessing a letter!");

            while (true)
            {
                Console.WriteLine("\nEnter a letter: ");
                char guess = char.ToLower(Console.ReadKey().KeyChar); // Read and convert input to lowercase
                Console.WriteLine();

                // Check if input is a valid letter
                if (!char.IsLetter(guess))
                {
                    Console.WriteLine("Please enter a valid letter.");
                    continue; // Skip the rest of the loop and ask for input again
                }

                guessedLetters.Add(guess); // Add guessed letter to set

                string revealed = RevealWord(hiddenWord, guessedLetters); // Reveal word based on guesses
                Console.WriteLine("Current word: " + revealed);

                // Check if the full word has been guessed
                if (!revealed.Contains('*'))
                {
                    Console.WriteLine("\nCongrats, you revealed the full word: " + hiddenWord + "\n");
                    break; // Exit loop when word is fully guessed
                }
            }
        }

        // Function to reveal the word based on guessed letters
        public static string RevealWord(string word, HashSet<char> guesses)
        {
            if (string.IsNullOrEmpty(word))
            {
                return "No word provided"; // Handle edge case where no word is provided
            }

            char[] revealedWord = new char[word.Length];

            // Loop through each letter in the word
            for (int i = 0; i < word.Length; i++)
            {
                // If the letter is in the guessed set, reveal it; otherwise, show '*'
                if (guesses.Contains(word[i]))
                {
                    revealedWord[i] = word[i];
                }
                else
                {
                    revealedWord[i] = '*';
                }
            }

            return new string(revealedWord); // Return the revealed word as a string
        }
    }
}
