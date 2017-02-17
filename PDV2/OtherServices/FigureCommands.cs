using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureServices;

namespace OtherServices
{
     public static class FigurosKomandos
    {

        private static List<Figura> PanaudotosFiguros = new List<Figura>();

        public static Figura Generuoti()
        {
            Random rnd = new Random();
            Figura _figura = new Figura();

            string FigurosPavadinimas = "[]";

            for (int i = 1; i < 2; i++)
            {


                int figurosTipoSkaicius = rnd.Next(1, 5);
                if (figurosTipoSkaicius == 1)
                {
                    FigurosPavadinimas = "Rutulys";
                }

                else if (figurosTipoSkaicius == 2)
                {
                    FigurosPavadinimas = "Kubas";
                }

                else if (figurosTipoSkaicius == 3)
                {
                    FigurosPavadinimas = "Piramide";
                }

                else if (figurosTipoSkaicius == 4)
                {
                    FigurosPavadinimas = "Cilindras";
                }

                else if (figurosTipoSkaicius == 5)
                {
                    FigurosPavadinimas = "Kugis";
                }

                _figura.TaskuKiekis = rnd.Next(1, 10);
                _figura.Pavadinimas = FigurosPavadinimas + _figura.TaskuKiekis.ToString();

                if (PanaudotosFiguros.Contains(_figura) == true)
                {
                    i--;
                }

                else
                {
                    PanaudotosFiguros.Add(_figura);
                }


            }
            return _figura;

        }

    }
}
