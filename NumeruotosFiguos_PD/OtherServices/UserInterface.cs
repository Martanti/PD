using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureServices;
using PlayersServies;


namespace OtherServices
{
    public static class UserInterface
    {
        public static int ZaidejoEjimas(Player _ZaidejoInfo, Bankas _bankoInfo, int taskuPoolas)
        {
            int grazinamasPiniguPoolas = taskuPoolas;

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Jusu turimos figuros \n");
            /*foreach(var item in _ZaidejoInfo.TurimosFiguros)
            {
                Console.WriteLine("{0}", item.Pavadinimas);
            }
            */
            for (int i = 0; i < _ZaidejoInfo.TurimosFiguros.Count; i++)
            {
                Console.WriteLine("{0}", _ZaidejoInfo.TurimosFiguros[i].Pavadinimas);
            }

            Console.WriteLine("\nBanko turima figura\n");
            Console.WriteLine("{0}", _bankoInfo.TurimosFiguros[0].Pavadinimas);       
            Console.WriteLine("------------------------------------------------------ \n");
            Console.WriteLine("Jusu veiksmas\n1 - Traukti korta\n2 - Padidinti statotmu tasku suma\n3 - Uzbaigti rounda");

            int zaidejoAtsakymas;

            bool arGeraiIvede = true;
            arGeraiIvede = Int32.TryParse(Console.ReadLine(), out zaidejoAtsakymas);

            while (arGeraiIvede == false)
            {
                Console.WriteLine("Įvyko klaida, prašome įvesti dar kartą");
                arGeraiIvede = Int32.TryParse(Console.ReadLine(), out zaidejoAtsakymas);

            }
            //prideti figura
            if (zaidejoAtsakymas == 1)
            {
                _ZaidejoInfo.TurimosFiguros.Add(NaujaFigura.Generuoti());
                _ZaidejoInfo.RaundoTaskai += _ZaidejoInfo.TurimosFiguros[_ZaidejoInfo.TurimosFiguros.Count - 1].TaskuKiekis;

            }

            //pakeisti statoma suma
            else if (zaidejoAtsakymas == 2)
            {
                Console.WriteLine("\nPrasome ivesti tasku suma, kuri bus prideta prie esamos statomos tasku sumos");
                int zaidejoAtsakymas2;

                bool arGeraiIvede2 = true;
                arGeraiIvede2 = Int32.TryParse(Console.ReadLine(), out zaidejoAtsakymas2);

                while (arGeraiIvede2 == false || (zaidejoAtsakymas2 >0 && (zaidejoAtsakymas2 <= _ZaidejoInfo.BendriTaskai && zaidejoAtsakymas2 <= _bankoInfo.BendriTaskai)))
                {
                    Console.WriteLine("Įvyko klaida, prašome įvesti dar kartą arba didesne suma");
                    arGeraiIvede2 = Int32.TryParse(Console.ReadLine(), out zaidejoAtsakymas2);

                }
                _ZaidejoInfo.BendriTaskai -= zaidejoAtsakymas2;
                _bankoInfo.BendriTaskai -= zaidejoAtsakymas2;
                grazinamasPiniguPoolas += zaidejoAtsakymas2*2;

            }

            //uzbaigti raunda
            else if (zaidejoAtsakymas == 3)
            {
                if (_ZaidejoInfo.RaundoTaskai > 21)
                {
                    Console.WriteLine("Tu pralaimejai, tavo raundo taskai virsijo 21");
                    _bankoInfo.BendriTaskai += grazinamasPiniguPoolas;
                }

                else
                {
                    if (_bankoInfo.RaundoTaskai <= 16)
                    {
                        Console.WriteLine("Bankas traukia reikiama figura");
                        _bankoInfo.TurimosFiguros.Add(NaujaFigura.Generuoti());
                        _bankoInfo.RaundoTaskai += _bankoInfo.TurimosFiguros[_bankoInfo.TurimosFiguros.Count - 1].TaskuKiekis;

                    }

                    if (_bankoInfo.RaundoTaskai > 21)
                    {
                        Console.WriteLine("Bankas pralaimejo, nes surinko daugiau nei 21 taskus");
                        _ZaidejoInfo.BendriTaskai += grazinamasPiniguPoolas;
                    }
                    else
                    {
                        if (_ZaidejoInfo.RaundoTaskai == 21)
                        {
                            Console.WriteLine("TU LAIMEJAI! \nSurinkai Auksini 21 taska");
                            _ZaidejoInfo.BendriTaskai += grazinamasPiniguPoolas;
                        }
                        else if (_ZaidejoInfo.RaundoTaskai > _bankoInfo.RaundoTaskai)
                        {
                            Console.WriteLine("TU LAIMEJAI! \n Surinkai daugiau tasku nei bankas");
                            _ZaidejoInfo.BendriTaskai += grazinamasPiniguPoolas;
                        }

                        else
                        {
                            Console.WriteLine("TU PRALAIMEJAI! Bankas surinko daugiau tasku nei tu!");
                            _bankoInfo.BendriTaskai += grazinamasPiniguPoolas;
                        }

                    }

                }

                grazinamasPiniguPoolas = 0;
            }

            return grazinamasPiniguPoolas;
        }



    }
}
