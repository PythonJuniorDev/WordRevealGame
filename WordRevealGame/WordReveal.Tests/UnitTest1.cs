namespace WordReveal.Tests
{
    public class WordRevealTests
    {
        // If no letters have been guessed yet, the result should only contain asterisks.
        // Expected result: "******"
        [Fact]
        public void TestRevealWordWithNoGuesses()
        {
            // Arrange
            string word = "junior".ToLower(); // Word to guess
            var guesses = new HashSet<char>(); // No guesses yet

            // Act
            string result = Program.RevealWord(word, guesses);

            // Assert
            Assert.Equal("******", result); // All asterisks
        }

        // Tests whether only the correctly guessed letters are shown in the right positions.
        // Example: "j*n**r" when guessing j, n, r
        [Fact]
        public void TestRevealWordWithSomeGuesses()
        {
            // Arrange
            string word = "junior".ToLower(); // Word to guess
            var guesses = new HashSet<char> { 'j', 'n', 'r' }; // Some guessed letters

            // Act
            string result = Program.RevealWord(word, guesses);

            // Assert
            Assert.Equal("j*n**r", result); // Correct expected result
        }
     
        // Tests if the entire word is correctly shown when all letters have been guessed.
        //  Expected result: "junior"
        [Fact]
        public void TestRevealWordWithAllGuesses()
        {
            // Arrange
            string word = "junior".ToLower(); // Word to guess
            var guesses = new HashSet<char> { 'j', 'u', 'n', 'i', 'o', 'r' }; // All correct guesses

            // Act
            string result = Program.RevealWord(word, guesses);

            // Assert
            Assert.Equal("junior", result); // Full word revealed
        }

        // None of the guessed letters are in the word, so everything remains hidden.
        // Expected result: "******"
        [Fact]
        public void TestRevealWordWithIncorrectGuesses()
        {
            // Arrange
            string word = "junior".ToLower(); // Word to guess
            var guesses = new HashSet<char> { 'x', 'y', 'z' }; // Incorrect guesses

            // Act
            string result = Program.RevealWord(word, guesses);

            // Assert
            Assert.Equal("******", result); // No letters revealed, as all guesses are incorrect
        }
    }
}
