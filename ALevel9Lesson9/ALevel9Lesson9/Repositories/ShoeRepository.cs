using ALevel9Lesson9.Entities;
using ALevel9Lesson9.Exceptions;
using ALevel9Lesson9.Models;
using ALevel9Lesson9.Repositories.Abstractions;

namespace ALevel9Lesson9.Repositories
{
    public class ShoeRepository : IShoeRepository
    {
        private readonly List<ShoeEntity> _mockStorage = new List<ShoeEntity>();

        public ShoeEntity GetShoe(string id)
        {
            foreach (var item in _mockStorage)
            {
                if(item.Id.ToString() == id)
                {
                    return item;
                }
            }

            throw new ShoeNotFoundException($"Shoe with id {id} not found");
        }

        public string AddShoe(Shoe shoe)
        {
            var shoeEntity = new ShoeEntity()
            {
                Id = Guid.NewGuid(),
                Description= shoe.Description,
                Name = shoe.Name,
                Size= shoe.Size,
                Style= shoe.Style,
            };

            _mockStorage.Add(shoeEntity);

            return shoeEntity.Id.ToString();
        }

        public string[] AddShoes(List<Shoe> shoes)
        {
            var entityShoes = new List<ShoeEntity>();
            var ids = new List<string>();

            foreach (var shoe in shoes) 
            {
                var entityShoe = new ShoeEntity()
                {
                    Id = Guid.NewGuid(),
                    Description = shoe.Description,
                    Name = shoe.Name,
                    Size = shoe.Size,
                    Style = shoe.Style,
                };

                ids.Add(entityShoe.Id.ToString());
                entityShoes.Add(entityShoe);
                _mockStorage.Add(entityShoe);
            }

            return ids.ToArray();
        }

        public ShoeEntity[] GetShoeByText(string text)
        {
            var shoes = new List<ShoeEntity>();

            foreach (var item in _mockStorage)
            {
                if (item.Name.Trim().ToLower().Contains(text.ToLower()) || item.Description.Trim().ToLower().Contains(text.ToLower()))
                {
                    shoes.Add(item);
                }
            }

            return shoes.ToArray();
        }

        public bool DeleteShoe(string id)
        {
            var shoe = GetShoe(id);

            return _mockStorage.Remove(shoe);
        }
    }
}
