using ALevel9Lesson9.Entities;
using ALevel9Lesson9.Models;
using ALevel9Lesson9.Repositories.Abstractions;
using ALevel9Lesson9.Services.Abstractions;

namespace ALevel9Lesson9.Services
{
    public class ShoeService : IShoeService
    {
        private readonly IShoeRepository _shoeRepository;
        private readonly IUserRepository _userRepository;

        public ShoeService(IShoeRepository shoeRepository, IUserRepository userRepository)
        {
            _shoeRepository = shoeRepository;
            _userRepository = userRepository;
        }

        public string AddShoe(Shoe shoe)
        {
            return _shoeRepository.AddShoe(shoe);
        }

        public bool DeleteShoe(string id)
        {
            return _shoeRepository.DeleteShoe(id);
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
                Style = shoe.Style,
            };
        }

        public string[] AddShoes(List<Shoe> shoes)
        {
            return _shoeRepository.AddShoes(shoes);
        }

        public Shoe[] GetShoeByText(string text)
        {
            var shoes = new List<Shoe>();
            var shoeEntities = _shoeRepository.GetShoeByText(text);

            foreach (var item in shoeEntities)
            {
                shoes.Add(new Shoe()
                {
                    Id = item.Id,
                    Name = _userRepository.ClientName,
                    Description = item.Description,
                    Size = item.Size,
                    Style = item.Style,
                });
            }

            return shoes.ToArray();
        }
    }
}
