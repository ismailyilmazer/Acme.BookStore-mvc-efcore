using Acme.BookStore.Permissions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books;

public class BookAppService_1 :
      CrudAppService<
        Book, //The Book entity
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto>, //Used to create/update a book
    IBookAppService //implement the IBookAppService
{
    public BookAppService_1(IRepository<Book, Guid> repository)
        : base(repository)
    {

    }

    public Task<ListResultDto<AuthorLookupDto>> GetAuthorLookupAsync()
    {
        throw new NotImplementedException();
    }
}
