using System;
using System.Collections.Generic;

namespace MemorizationHelper
{
    class Scripture
    {
        private Reference _reference;  // Store the reference of the scripture.
        private List<Word> _words;    // Store a list of words in the scripture.

        // Constructor for creating a new Scripture object.
        public Scripture(string book, int chapter, int verse, string text)
        {
            _reference = new Reference(book, chapter, verse);  // Create a new Reference object for the scripture.
            _words = new List<Word>();  // Initialize an empty list to store words.

            // Split the input 'text' into words and create Word objects for each word.
            foreach (string part in text.Split(' '))
            {
                _words.Add(new Word(part));
            }
        }

        // Present the scripture, displaying the reference and words.
        public void PresentScripture()
        {
            Console.WriteLine($"{_reference}:");  // Display the reference of the scripture.
            foreach (Word word in _words)
            {
                // Display each word, replacing concealed words with underscores.
                Console.Write(word.IsConcealed() ? new string('_', word.Length()) + " " : word.Text() + " ");
            }
        }

        // Mask a random visible word in the scripture.
        public bool MaskWord()
        {
            List<Word> visibleWords = _words.FindAll(w => !w.IsConcealed());  // Find all visible (not concealed) words.

            // If there are no visible words, return false (no words to mask).
            if (visibleWords.Count == 0)
                return false;

            Random rand = new Random();  // Create a random number generator.
            int index = rand.Next(visibleWords.Count);  // Generate a random index within the visibleWords list.
            visibleWords[index].Conceal();  // Conceal the word at the randomly chosen index.
            return true;  // Return true to indicate that a word was successfully concealed.
        }
    }
}
