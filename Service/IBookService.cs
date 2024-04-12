using Book.CRUD.Models;

namespace Book.CRUD.Service
{
    internal interface IBookService
    {
        Books GetBook(int id);
        Books[] ReadAllBook();
        Books InsertBook(Books book);
        bool Update(Books book);
        bool Delete(int id);
    }
}
