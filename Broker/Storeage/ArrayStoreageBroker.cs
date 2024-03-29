﻿
using System;
using Book.CRUD.Models;

namespace Book.CRUD.Broker.Storeage
{
    public class ArrayStoreageBroker : IStoreageBroker
    {
        private Books[] BooksInfo { get; set; } = new Books[10];

        public ArrayStoreageBroker()
        {
            BooksInfo[0] = new Books()
            {
                Id = 1,
                Name = "O'tgan kunlar",
                Author = "Abdullo Qodiriy"
            };
            BooksInfo[1] = new Books()
            {
                Id = 2,
                Name = "Shum bola",
                Author = "G'ofur G'ulom"
            };
        }
        public Books ReadBook(int id)
        {
            for(int itaration = 0; itaration <= BooksInfo.Length; itaration++)
            {
                Books bookInfoLine = BooksInfo[itaration];
                if (bookInfoLine.Id == id)
                {
                    return bookInfoLine;
                }
            }

            return new Books();
        }

        public Books[] GetAllBook() => BooksInfo;

        public Books AddBook(Books book)
        {
            for (int itaration = 0; itaration < BooksInfo.Length; itaration++)
            {
                if (BooksInfo[itaration] is null)
                {
                    var bookInfo = new Books()
                    {
                        Id = book.Id,
                        Name = book.Name,
                        Author = book.Author
                    };
                    BooksInfo[itaration] = bookInfo;
                    return book;
                }
            }
            return new Books();
        }
    }

}
