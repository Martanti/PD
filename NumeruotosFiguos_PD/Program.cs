using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureServices;
using PlayersServies;
using OtherServices;

namespace NumeruotosFiguos_PD
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ar norite pradėti naują žaidimą? \nT/N");
            string arNoriteZaisti = Console.ReadLine();
            
            while (arNoriteZaisti == "T" || arNoriteZaisti == "t")
            {

                //zaideju deklaravimas            
                Player zaidejas = new Player();
                Bankas bank = new Bankas();

                Console.WriteLine("Žaidėjo vardas");
                zaidejas.Name = Console.ReadLine();

                zaidejas.BendriTaskai = 500;
                bank.BendriTaskai = 10000000;
                while (true)
                {
                    Console.WriteLine("------------------------------------------------------ ");
                    Console.WriteLine("Prasideda naujas raundas");
                    Console.WriteLine("------------------------------------------------------ \n");
                    Console.WriteLine("\nTurite {0} tasku(u)", zaidejas.BendriTaskai);
                    Console.WriteLine("Bankas turi {0} tasku(s)", bank.BendriTaskai);



                    Console.WriteLine("\nKiek taškų norite statyti?");
                    int statomiZaidejoTaskai;

                    bool arGeraiIvede = true;
                    arGeraiIvede = Int32.TryParse(Console.ReadLine(), out statomiZaidejoTaskai);

                    while (arGeraiIvede == false || statomiZaidejoTaskai > zaidejas.BendriTaskai)
                    {
                        Console.WriteLine("Įvyko klaida, prašome įvesti dar kartą arba mazesne suma");
                        arGeraiIvede = Int32.TryParse(Console.ReadLine(), out statomiZaidejoTaskai);

                    }


                    zaidejas.BendriTaskai -= statomiZaidejoTaskai;
                    bank.BendriTaskai -= statomiZaidejoTaskai;

                    int raundoPiniguBankas = statomiZaidejoTaskai * 2;

                    for (int i = 0; i < 2; i++)
                    {
                        zaidejas.TurimosFiguros.Add(NaujaFigura.Generuoti());
                        zaidejas.RaundoTaskai += zaidejas.TurimosFiguros[zaidejas.TurimosFiguros.Count - 1].TaskuKiekis;

                        bank.TurimosFiguros.Add(NaujaFigura.Generuoti());
                        bank.RaundoTaskai += bank.TurimosFiguros[bank.TurimosFiguros.Count - 1].TaskuKiekis;

                    }

                    while(true)
                    {
                        UserInterface.ZaidejoEjimas(zaidejas, bank, raundoPiniguBankas);

                        if (raundoPiniguBankas == 0)
                        {
                            Console.WriteLine("/nPasibaige raundas");
                            break;
                        }
                    }
                    if (zaidejas.BendriTaskai <= 0)
                    {
                        Console.WriteLine("Deja, nebeturite daugiau tasku, kad galetumete testi \nJusu tasku kiekis yra nepakankamas, kad butu issaugotas i zaideju lentele");
                    }
                    else
                    {
                        if (zaidejas.BendriTaskai == 10000500)
                        {
                            Console.WriteLine("Sveikiname!!! \nJus, {0}, pasiekete masksimalu zaidimo tasku kieki!\nIrasisime Jus i zaideju lentele", zaidejas.Name);
                            //kodas kuris iraso i sql lentele
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Norite testi zaidima ar uzbaigti (jus rezultatas bus irasytas i duomenu baze) \ntesti/baigti");
                            if (Console.ReadLine().ToLower() == "baigti")
                            {
                                //kodas kuris iraso i sql lentele
                                break;
                            }
                        }


                    }



                }
            }


        }
    }
}
