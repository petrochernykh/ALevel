using ALevel9Lesson9.Entities;
using ALevel9Lesson9.Models;
using ALevel9Lesson9.Repositories.Abstractions;
using ALevel9Lesson9.Services.Abstractions;

namespace ALevel9Lesson9.Services
{
    public class ShoeService : IShoeService
    {
        private readonly IShoeRepository _shoeRepository;

        public ShoeService(IShoeRepository shoeRepository)
        {
            _shoeRepository = shoeRepository;
        }

        public string AddShoe(Shoe shoe)
        {
            throw new NotImplementedException();
        }

        public bool DeleteShoe(string id)
        {
            throw new NotImplementedException();
        }

        public Shoe GetShoe(string id)
        {
            var shoe = _shoeRepository.GetShoe(id);

            return new Shoe()
            {
                Id = shoe.Id,
                Name = shoe.Name,
                Description = shoe.Description,
                Size = shoe.Size,
                Style= shoe.Style,
            };
        }
    }
}
