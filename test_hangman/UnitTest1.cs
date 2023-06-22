namespace test_hangman;

[TestClass]
public class GameTests
{
    [TestMethod]
    public void SecretWord_ShowLetters_ReturnsCorrectString()
    {
        SecretWord secretWord = new SecretWord("Hello");

        List<char> guessedLetters = new List<char> { 'H', 'e', 'l' };
        string result = secretWord.ShowLetters(guessedLetters);

        Assert.AreEqual("H e l l _", result);
    }

    [TestMethod]
    public void SecretWord_CheckLetters_ReturnsTrue()
    {
        SecretWord secretWord = new SecretWord("Hello");

        List<char> guessedLetters = new List<char> { 'H', 'e', 'l', 'o' };
        bool result = secretWord.CheckLetters(guessedLetters);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void SecretWord_CheckLetters_ReturnsFalse()
    {
        SecretWord secretWord = new SecretWord("Hello");

        List<char> guessedLetters = new List<char> { 'H', 'e', 'o' };
        bool result = secretWord.CheckLetters(guessedLetters);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void SecretWord_Check_ReturnsTrue()
    {
        SecretWord secretWord = new SecretWord("Hello");

        bool result = secretWord.Check("Hello");

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void SecretWord_Check_ReturnsFalse()
    {
        SecretWord secretWord = new SecretWord("Hello");

        bool result = secretWord.Check("Goodbye");

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Game_PlayOneRound_ReturnsTrue()
    {
        Game game = new Game(10);
        game.PlayOneRound();

        Assert.IsTrue(game.Turns < 10);
    }

    [TestMethod]
    public void Game_Play_ReturnsTrue()
    {
        Game game = new Game(10);
        bool result = game.Play();

        Assert.IsTrue(result);
    }
}