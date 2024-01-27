using System;

namespace MemorizationHelper
{
    class Reference
    {
        private string _book;
        private int _chapter;
        private int _startVerse;
        private int? _endVerse; // Optional end verse for ranges

        // Constructor for single verse
        public Reference(string book, int chapter, int verse) : this(book, chapter, verse, null)
        {
        }

        // Constructor for verse range
        public Reference(string book, int chapter, int startVerse, int? endVerse)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = startVerse;
            _endVerse = endVerse;
        }

        public override string ToString()
        {
            return _endVerse.HasValue 
                ? $"{_book} {_chapter}:{_startVerse}-{_endVerse.Value}" 
                : $"{_book} {_chapter}:{_startVerse}";
        }
    }
}
