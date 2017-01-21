using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureServices;

namespace PlayersServies
{
    public class Player
    {
        public Player() { }
        public string Name;
        public int BendriTaskai;
        public int RaundoTaskai;
        public List<Figura> TurimosFiguros = new List<Figura>();
    }
}
