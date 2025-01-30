using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;
using System;

namespace StringLibraryTest;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestStartsWithUpper()
    {
        Console.WriteLine("Running: TestStartsWithUpper");

        // Tests that we expect to return true.
        string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва", "Bob" };
        foreach (var word in words)
        {
            bool result = word.StartsWithUpper();
            Console.WriteLine($"Checking '{word}': Result = {result}");
            Assert.IsTrue(result,
                   string.Format("Expected for '{0}': true; Actual: {1}",
                                 word, result));
        }
    }

    [TestMethod]
    public void TestDoesNotStartWithUpper()
    {
        Console.WriteLine("Running: TestDoesNotStartWithUpper");

        // Tests that we expect to return false.
        string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство",
                           "1234", ".", ";", " " };
        foreach (var word in words)
        {
            bool result = word.StartsWithUpper();
            Console.WriteLine($"Checking '{word}': Result = {result}");
            Assert.IsFalse(result,
                   string.Format("Expected for '{0}': false; Actual: {1}",
                                 word, result));
        }
    }

    [TestMethod]
    public void DirectCallWithNullOrEmpty()
    {
        Console.WriteLine("Running: DirectCallWithNullOrEmpty");

        // Tests that we expect to return false.
        string?[] words = { string.Empty, null };
        foreach (var word in words)
        {
            bool result = StringLibrary.StartsWithUpper(word);
            Console.WriteLine($"Checking '{word ?? "<null>"}': Result = {result}");
            Assert.IsFalse(result,
                   string.Format("Expected for '{0}': false; Actual: {1}",
                                 word == null ? "<null>" : word, result));
        }
    }
}
