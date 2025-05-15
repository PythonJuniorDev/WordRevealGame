# 🔤 Word Reveal

A simple console-based word guessing game built in C#. Users guess letters to reveal a hidden word. Includes tests to make sure everything works correctly.

---

## 🎯 Features

- ✅ Real-time letter guessing with immediate feedback
- ✅ Case-insensitive input handling
- ✅ Automatically reveals correct guesses in the word
- ✅ Shows unrevealed letters as asterisks (`*`)
- ✅ Game ends once the full word is revealed
- ✅ Includes unit tests for different guessing scenarios

---

## 🧠 How It Works

- The word `"HelloWorld"` is hidden and converted to lowercase.
- The player types one letter at a time.
- Correct guesses are revealed in their respective positions.
- The game continues until all letters are guessed.

---

## 🧪 Testing

The project includes unit tests for the core method `RevealWord()`:

- ✅ **No guesses** → returns only asterisks  
- ✅ **Some correct guesses** → reveals matching letters  
- ✅ **All letters guessed** → reveals the full word  
- ✅ **Incorrect guesses** → no letters revealed  

Tests are written using `[Fact]` from the testing framework **xUnit**.

---

## 🛠 Example Output 

```bash
Welcome to Word Reveal.

Try guessing a letter!

Enter a letter:
Current word: h*******
...
Congrats, you revealed the full word: helloworld
```

---

## 🚀 Getting Started
📦 Prerequisites
    - .NET 8.0 SDK or later
    - C#-compatible IDE (e.g., Visual Studio, Rider, VS Code)

---

## ▶️ Running the Game
```bash
dotnet run --project WordReveal
```

---

## 🧪 Running Tests
```bash
dotnet test
```
