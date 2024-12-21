using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public static class BookValidator
    {
        public delegate bool ValidatorDelegate(Book book, out string errorMessage);

        public static bool Validate(Book book, out string errorMessage)
        {
            var validators = new List<ValidatorDelegate>
        {
            ValidateTitle,
            ValidateAuthor,
            ValidateISBN,
            ValidatePublisher,
            ValidatePublicationDate,
            ValidateNumberOfPages,
            ValidatePrice
        };

            foreach (var validator in validators)
            {
                if (!validator(book, out errorMessage))
                {
                    return false;
                }
            }

            errorMessage = null;
            return true;
        }

        private static bool ValidateTitle(Book book, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(book.Title) || book.Title.Length < 1 || book.Title.Length > 255)
            {
                errorMessage = "Title must be between 1 and 255 characters.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        private static bool ValidateAuthor(Book book, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(book.Author) || book.Author.Length < 3 || book.Author.Length > 128)
            {
                errorMessage = "Author must be between 3 and 128 characters.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        private static bool ValidateISBN(Book book, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(book.ISBN) || book.ISBN.Length != 13)
            {
                errorMessage = "ISBN must be exactly 13 characters.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        private static bool ValidatePublisher(Book book, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(book.Publisher) || book.Publisher.Length < 2 || book.Publisher.Length > 64)
            {
                errorMessage = "Publisher must be between 2 and 64 characters.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        private static bool ValidatePublicationDate(Book book, out string errorMessage)
        {
            if (book.PublicationDate > DateTime.Now)
            {
                errorMessage = "Publication date cannot be in the future.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        private static bool ValidateNumberOfPages(Book book, out string errorMessage)
        {
            if (book.NumberOfPages <= 0)
            {
                errorMessage = "Number of pages must be greater than 0.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        private static bool ValidatePrice(Book book, out string errorMessage)
        {
            if (book.Price <= 0)
            {
                errorMessage = "Price must be greater than 0.";
                return false;
            }
            errorMessage = null;
            return true;
        }
    }
}
