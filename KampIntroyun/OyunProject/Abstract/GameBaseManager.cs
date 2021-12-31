using OyunProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunProject.Abstract
{
    public class GameBaseManager : IGameService
    {
        public void Delete(Game game)
        {
            Console.WriteLine($"{game.Name} silindi.");
        }

        public void Register(Game game)
        {
            Console.WriteLine($"{game.Name} eklendi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine($"{game.Name} güncellendi.");
        }
    }
}
