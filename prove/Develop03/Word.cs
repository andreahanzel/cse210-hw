using System;

namespace MemorizationHelper
{
    
    class Word
    {
        // Field to store the actual text content of the word.
        private string _content;
        // Field to indicate whether the word is concealed or not.
        private bool _concealed;

        // Constructor to initialize a Word object with its content.
        public Word(string content)
        {
            // Set the content of the word.
            _content = content;
            // Initially, the word is not concealed.
            _concealed = false;
        }

        // Mark the word as concealed.
        public void Conceal()
        {
            _concealed = true;
        }

        // Get the text content of the word.
        public string Text()
        {
            return _content;
        }

        // Check if the word is concealed.
        public bool IsConcealed()
        {
            return _concealed;
        }

        // Get the length of the word.
        public int Length()
        {
            return _content.Length;
        }
    }
}
