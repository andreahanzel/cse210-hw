using System;

namespace MemorizationHelper
{
    // Class to represent a scripture reference (book, chapter, and verse).
    class Reference
    {
        // Store the book name, chapter number, and verse number of the scripture reference.
        private string _book;
        private int _chapter;
        private int _verse;

        // Constructor to initialize a Reference object with a book name, chapter number, and verse number.
        public Reference(string book, int chapter, int verse)
        {
            // Set the book name.
            _book = book;
            // Set the chapter number.
            _chapter = chapter;
            // Set the verse number.
            _verse = verse;
        }

        // Override the ToString method to return the scripture reference in a standard format.
        public override string ToString()
        {
            // Format and return the reference as "Book Chapter:Verse".
            return $"{_book} {_chapter}:{_verse}";
        }
    }
}
