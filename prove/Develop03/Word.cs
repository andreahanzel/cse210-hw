using System;

namespace MemorizationHelper
{
    class Word
    {
        private string _content;   // Field for the word's text.
        private bool _concealed;   // Field indicating if the word is hidden.

        // Constructor for the Word class.
        public Word(string content)
        {
            _content = content;   // Set the word's content.
            _concealed = false;   // Initially, the word is not hidden.
        }

        // Method to mark the word as hidden.
        public void Conceal()
        {
            _concealed = true;
        }

        // Method to get the word's text.
        public string Text()
        {
            return _content;
        }

        // Method to check if the word is hidden.
        public bool IsConcealed()
        {
            return _concealed;
        }

        // Method to get the length of the word.
        public int Length()
        {
            return _content.Length;
        }
    }
}
