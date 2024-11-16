using BookStore.Data;
using BookStore.Migrations;
using BookStore.Models.Dtos;
using BookStore.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private readonly ApplicationDBContext applicationDBContext;
        public MasterController( ApplicationDBContext applicationDBContext)
        {
            this.applicationDBContext = applicationDBContext;
        }

        [HttpGet("GetAllBooks")]
        public async Task<ActionResult<IEnumerable<BookMaster>>> GetAllBooks()
        {
            return await applicationDBContext.MasterBooks.ToListAsync();
        }

        [HttpGet("Get-Order-Details")]
        public async Task<ActionResult<IEnumerable<OrderDetails>>> GetOrderDetails()
        {
            return await applicationDBContext.orderDetails.ToListAsync();
        }

        [HttpGet("GetAllCategories")]
        public async Task<ActionResult<IEnumerable<BookCategory>>> GetAllCategories()
        {
            return await applicationDBContext.bookCategories.ToListAsync();
        }


        [HttpPost("create-user")]
        public IActionResult CreateUser(AddCustomerDto addCustomerDto)
        {
            var user = new UserList()
            {
                Name = addCustomerDto.Name,
                Email = addCustomerDto.Email,
                Address = addCustomerDto.Address,
                City = addCustomerDto.City,
                Phone = addCustomerDto.Phone,
                Gender = addCustomerDto.Gender,
                PinCode = addCustomerDto.PinCode,
                DOB = addCustomerDto.DOB,
                UserName = addCustomerDto.UserName,
                Password = addCustomerDto.Password,
                RoleId = 1
            };
            applicationDBContext.UserLists.Add(user);
            applicationDBContext.SaveChanges();
            return Ok(user);
        }
        [HttpPost("create-order-details")]
        public IActionResult CreateOrderDetails(AddOrderDetailsDto addOrderDetails)
        {
            var order = new OrderDetails()
            {
                UserId=addOrderDetails.UserId,
                BookId=addOrderDetails.BookId,
                Status=addOrderDetails.Status,
                Quantity=addOrderDetails.Quantity,
                Price=addOrderDetails.Price,
                CreatedDate=DateTime.Now
                
            };
            applicationDBContext.orderDetails.Add(order);
            applicationDBContext.SaveChanges();
            return Ok(order);
        }

        [HttpGet("get-order-byid")]
        //[Route("\"getOrderByid\"{id:string}")]
        public IActionResult GetOrderDetailsById(string id)
        {
            var order = applicationDBContext.orderDetails.Where(x => x.UserId == id).FirstOrDefault();
            if (order == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(order);
            }

        }

        [HttpPut]
        [Route("\"updateOrder\"{id:guid}")]
        public IActionResult UpdateOrder(Guid id, AddOrderDetailsDto addOrderDetails)
        {
            var entityData = applicationDBContext.orderDetails.Find(id);
            if (entityData == null)
            {
                return NotFound();
            }
            entityData.Status = addOrderDetails.Status;

            applicationDBContext.SaveChanges();
            return Ok(entityData);

        }


        [HttpGet]
        [Route("\"get-book-byid\"{id:guid}")]
        public IActionResult GetBookById(Guid id)
        {
            var book = applicationDBContext.MasterBooks.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(book);
            }

        }
        [HttpGet("get-book-by-category")]
        public IActionResult GetBookByCategory(int categoryId)
        {
            var book = applicationDBContext.MasterBooks.Where(x=>x.CategoryId == categoryId);
            if (book == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(book);
            }

        }

        [HttpPost("create-book")]
        public IActionResult CreateBooks(AddBooksDto addBooksDto)
        {
            var book = new BookMaster()
            {
                Name = addBooksDto.Name,
                ImageUrl = addBooksDto.ImageUrl,
                Price = addBooksDto.Price,
                StockCount = addBooksDto.StockCount,
                Categories = addBooksDto.Category,
                Author = addBooksDto.Author,
                Description = addBooksDto.Description,
                CategoryId = addBooksDto.CategoryId,
                CreatedDate = DateTime.Now
            };
            applicationDBContext.MasterBooks.Add(book);
            applicationDBContext.SaveChanges();
            return Ok(book);
        }

        [HttpGet("get-rating-byid")]
        //[Route("\"getRatingByid\"{id:string}")]
        public IActionResult GetRatingById(string id)
        {
            var rating = applicationDBContext.BookRatings.Where(x => x.BookId == id).FirstOrDefault();
            if (rating == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(rating);
            }

        }
        [HttpPost("create-book-rating")]
        public IActionResult CreateBooksRating(AddBookRatingDto addBookRatingDto)
        {
            var book = new BookRating()
            {
                Review = addBookRatingDto.Review,
                Remarks = addBookRatingDto.Remarks,
                BookId = addBookRatingDto.BookId,
                CustomerId = addBookRatingDto.CustomerId,
                CreatedDate = DateTime.Now
            };
            applicationDBContext.BookRatings.Add(book);
            applicationDBContext.SaveChanges();
            return Ok(book);
        }
        [HttpPost("Login")]
        public IActionResult LoginUser(LoginDto loginDto)
        {
            try
            {
                var user = applicationDBContext.UserLists.Where(x => x.UserName == loginDto.UserName && x.Password == loginDto.Password).FirstOrDefault();
                if (user == null)
                {
                    return Ok(new
                    {
                        id = -1,
                        message = "UserName or Password is incorrect"

                    });
                }
                return Ok(new
                {
                    id = 0,
                    userName = user.Name,
                    roleId = user.RoleId, 
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }


        //[HttpPut]
        //[Route("\"create-book-rating\"{id:guid}")]
        //public IActionResult CreateBookRating(AddBookRatingDto addBookRatingDto)
        //{
        //    var entityData = applicationDBContext.BookRatings.Where(x => x.CustomerId == addBookRatingDto.CustomerId).FirstOrDefault();
        //    if (entityData == null)
        //    {
        //        return NotFound();
        //    }
        //    entityData. = addOrderDetails.Status;

        //    applicationDBContext.SaveChanges();
        //    return Ok(entityData);

        //}

    }
}
