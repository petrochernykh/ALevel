using ALevel9Lesson9.Services.Abstractions;

namespace ALevel9Lesson9
{
    public class App
    {
        private readonly IShoeService _shoeService;

        public App(IShoeService shoeService)
        {
            _shoeService= shoeService;
        }

        public void Run()
        {
            try
            {
                var shoe = _shoeService.GetShoe(new Guid().ToString());
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}
