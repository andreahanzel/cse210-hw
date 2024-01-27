using System;
using System.Collections.Generic;

namespace MemorizationHelper
{
    class Scripture
    {
        private Reference _reference;  // Reference object for scripture's book, chapter, and verse.
        private List<Word> _words;     // List of Word objects representing each word in the scripture.

        // Constructor to create a Scripture object.
        public Scripture(string book, int chapter, int verse, string text)
        {
            _reference = new Reference(book, chapter, verse); // Initialize the reference.
            _words = new List<Word>(); // Initialize the list of words.

            // Split the text into words and create Word objects for each.
            foreach (string part in text.Split(' '))
            {
                _words.Add(new Word(part));
            }
        }

        // Present the scripture with the reference and words.
        public void PresentScripture()
        {
            Console.WriteLine($"{_reference}:"); // Display the reference.
            foreach (Word word in _words)
            {
                // Display each word, using underscores for concealed words.
                Console.Write(word.IsConcealed() ? new string('_', word.Length()) + " " : word.Text() + " ");
            }
        }

        // Mask a random visible word in the scripture.
        public bool MaskWord()
        {
            List<Word> visibleWords = _words.FindAll(w => !w.IsConcealed()); // Find all non-concealed words.

            // If no visible words left, return false.
            if (visibleWords.Count == 0)
                return false;

            Random rand = new Random(); // Random number generator.
            int index = rand.Next(visibleWords.Count); // Random index for a visible word.
            visibleWords[index].Conceal(); // Conceal the chosen word.
            return true; // Indicate that a word was concealed.
        }
    }
}
