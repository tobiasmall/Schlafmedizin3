using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schlaf_Assessment_Tool
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Insomnia Severity Index

            Console.WriteLine("Schwierigkeit, einzuschlafen:");
            string ISIeinzuschlafen = Console.ReadLine();
            int ISIeinzuschlafenZahl = Convert.ToInt32(ISIeinzuschlafen);
            Console.WriteLine("Schwierigkeit, durchzuschlafen:");
            string ISIdurchzuschlafen = Console.ReadLine();
            int ISIdurchzuschlafenZahl = Convert.ToInt32(ISIdurchzuschlafen);
            Console.WriteLine("Das Problem, am Morgen früh aufzuwachen:");
            string ISIaufzuwachen = Console.ReadLine();
            int ISIaufzuwachenZahl = Convert.ToInt32(ISIaufzuwachen);
            Console.WriteLine("Wie zufrieden/unzufrieden sind Sie mit Ihrem aktuellen Schlafverhalten?");
            string ISIunzufrieden = Console.ReadLine();
            int ISIunzufriedenZahl = Convert.ToInt32(ISIunzufrieden);
            Console.WriteLine("In welchem Ausmaß beeinflussen Ihre Schlafprobleme Alltagsfunktionen?");
            string ISIalltagsfunktionen = Console.ReadLine();
            int ISIalltagsfunktionenZahl = Convert.ToInt32(ISIalltagsfunktionen);
            Console.WriteLine("In welchem Ausmaß nehmen Ihre Mitmenschen Ihr Schlafproblem wahr?");
            string ISImitmenschen = Console.ReadLine();
            int ISImitmenschenZahl = Convert.ToInt32(ISImitmenschen);
            Console.WriteLine("Wie besorgt/bedrückt sind Sie durch Ihre Schlafprobleme?");
            string ISIbesorgt = Console.ReadLine();
            int ISIbesorgtZahl = Convert.ToInt32(ISIbesorgt);

            int summeISI = ISIeinzuschlafenZahl + ISIdurchzuschlafenZahl + ISIaufzuwachenZahl + ISIunzufriedenZahl + ISIalltagsfunktionenZahl + ISImitmenschenZahl + ISIbesorgtZahl;

            //  Pittsburgh Sleep Quality Index

            Console.WriteLine("Wann sind Sie zu Bett gegangen?");
            string PSQIzubett = Console.ReadLine();
            var PSQIzuBettZeit = DateTime.Parse(PSQIzubett);
            Console.WriteLine("Wie lange hat es gedauert bis Sie eingeschlafen sind?");
            string PSQIlatenz = Console.ReadLine();
            int PSQIlatenzZahl = Convert.ToInt32(PSQIlatenz);
            Console.WriteLine("Wann sind Sie aufgestanden?");
            string PSQIaufgestanden = Console.ReadLine();
            var PSQIaufgestandenZeit = DateTime.Parse(PSQIaufgestanden);
            // Console.WriteLine("Wie viele Stunden waren Sie im Bett?");
            // string PSQIbettzeit = Console.ReadLine();
            // int PSQIbettzeitZahl = Convert.ToInt32(PSQIbettzeit);
            Console.WriteLine("Wie viele Stunden haben Sie tatsächlich geschlafen?");
            string PSQIschlafdauer = Console.ReadLine();
            int PSQISchlafdauerZahl = Convert.ToInt32(PSQIschlafdauer);
            Console.WriteLine("SCHLAFEFFIZIENZ IN PROZENT (OHNE PROZENTZEICHEN EINGEBEN)");
            string PSQIschlafeffizienz = Console.ReadLine();
            int PSQIschlafeffizientProzent = Convert.ToInt32(PSQIschlafeffizienz);



            Console.WriteLine("Wie oft haben Sie insgesamt in den letzten 4 Wochen schlecht geschlafen weil Sie nicht innerhalb 30 Min eingeschlafen sind?");
            string PSQIschlechtgeschlafeneinschlafen = Console.ReadLine();
            int PSQIschlechtgeschlafeneinschlafenZahl = Convert.ToInt32(PSQIschlechtgeschlafeneinschlafen);
            Console.WriteLine("..weil Sie mitten in der Nacht oder frühmorgens aufgewacht sind?");
            string PSQIschlechtgeschlafenaufgewacht = Console.ReadLine();
            int PSQIschlechtgeschlafenaufgewachtZahl = Convert.ToInt32(PSQIschlechtgeschlafenaufgewacht);
            Console.WriteLine("...weil Sie aufstehen mussten um zur Toilette zu gehen?");
            string PSQIschlechtgeschlafentoilette = Console.ReadLine();
            int PSQIschlechtgeschlafentoiletteZahl = Convert.ToInt32(PSQIschlechtgeschlafentoilette);
            Console.WriteLine("...weil Sie Beschwerden beim Atmen hatten?");
            string PSQIschlechtgeschlafenbeschwerdenatmen = Console.ReadLine();
            int PSQIschlechtgeschlafenbeschwerdenatmenZahl = Convert.ToInt32(PSQIschlechtgeschlafenbeschwerdenatmen);
            Console.WriteLine("...weil Sie husten mussten oder laut geschnarcht haben?");
            string PSQIschlechtgeschlafenhustengeschnarcht = Console.ReadLine();
            int PSQIschlechtgeschlafenhustengeschnarchtZahl = Convert.ToInt32(PSQIschlechtgeschlafenhustengeschnarcht);
            Console.WriteLine("...weil Ihnen zu kalt war?");
            string PSQIschlechtgeschlafenzukalt = Console.ReadLine();
            int PSQIschlechtgeschlafenzukaltZahl = Convert.ToInt32(PSQIschlechtgeschlafenzukalt);
            Console.WriteLine("...weil Ihnen zu warm war?");
            string PSQIschlechtgeschlafenzuwarm = Console.ReadLine();
            int PSQIschlechtgeschlafenzuwarmZahl = Convert.ToInt32(PSQIschlechtgeschlafenzuwarm);
            Console.WriteLine("...weil Sie schlecht geträumt hatten?");
            string PSQIschlechtgeschlafengeträumt = Console.ReadLine();
            int PSQIschlechtgeschlafengeträumtZahl = Convert.ToInt32(PSQIschlechtgeschlafengeträumt);
            Console.WriteLine("...weil Sie Schmerzen hatten?");
            string PSQIschechtgeschlafenschmerzen = Console.ReadLine();
            int PSQIschlechtgeschlafenschmerzenZahl = Convert.ToInt32(PSQIschechtgeschlafenschmerzen);
            Console.WriteLine("...aus anderen Gründen?");
            string PSQIschlechtgeschlafenandere = Console.ReadLine();
            int PSQIschlechtgeschlafenandereZahl = Convert.ToInt32(PSQIschlechtgeschlafenandere);


            Console.WriteLine("Wie oft haben Sie während der letzten 4 Wochen Schlafmittel eingenommen?");
            string PSQIschlafmittel = Console.ReadLine();
            int PSQIschlafmittelZahl = Convert.ToInt32(PSQIschlafmittel);
            Console.WriteLine("Wie oft hatten Sie während der letzten 4 Wochen Schwierigkeiten wachzubleiben?");
            string PSQIschwierigkeitenwachzubleiben = Console.ReadLine();
            int PSQIschwierigkeitenwachzubleibenZahl = Convert.ToInt32(PSQIschwierigkeitenwachzubleiben);
            Console.WriteLine("Hatten Sie während der letzten 4 Wochen Probleme mit genügend Schwung die üblichen Alltagsaufgaben zu erledigen?");
            string PSQIschwung = Console.ReadLine();
            int PSQIschwungZahl = Convert.ToInt32(PSQIschwung);
            Console.WriteLine("Wie würden Sie insgesamt die Qualität Ihres Schlafes beurteilen?");
            string PSQIqualitätinsgesamt = Console.ReadLine();
            int PSQIqualitätinsgesamtZahl = Convert.ToInt32(PSQIschwung);



            //  Auswertung PSQI


            // Komponente 1  Subjektive Schlafqualität

            int Komponente1 = Convert.ToInt32(PSQIqualitätinsgesamt);


            // Komponente 2  Schlaflatenz

            int summefrage2und5 = PSQIlatenzZahl + PSQIschlechtgeschlafeneinschlafenZahl;

            int Komponente2 = 0;

            if (summefrage2und5 < 1)
                Komponente2 = 0;
            if (summefrage2und5 > 0 && summefrage2und5 < 3)
                Komponente2 = 1;
            if (summefrage2und5 > 2 && summefrage2und5 < 5)
                Komponente2 = 2;
            if (summefrage2und5 > 4)
                Komponente2 = 3;

            // Komponente 3  Schlafdauer

            int Komponente3 = 0;

            if (PSQISchlafdauerZahl >= 7.0)
                Komponente3 = 0;
            if (PSQISchlafdauerZahl < 7.0 && PSQISchlafdauerZahl >= 6.0)
                Komponente3 = 1;
            if (PSQISchlafdauerZahl < 6.0 && PSQISchlafdauerZahl >= 5.0)
                Komponente3 = 2;
            if (PSQISchlafdauerZahl < 5.0)
                Komponente3 = 3;

            //  Komponente 4  Schlafeffizienz

            TimeSpan PSQIbettzeit = PSQIaufgestandenZeit - PSQIzuBettZeit;

            TimeSpan span1 = new TimeSpan(0, 24, 0, 0);

            TimeSpan Bettzeit = PSQIbettzeit.Add(span1);

            string BettzeitString = Convert.ToString(Bettzeit);

            Console.WriteLine("Die Bettzeit ist {0}\n", BettzeitString);


            int Komponente4 = 0;

            if (PSQIschlafeffizientProzent >= 85)
                Komponente4 = 0;
            if (PSQIschlafeffizientProzent < 85 && PSQIschlafeffizientProzent >= 75)
                Komponente4 = 1;
            if (PSQIschlafeffizientProzent < 75 && PSQIschlafeffizientProzent >= 65)
                Komponente4 = 2;
            if (PSQIschlafeffizientProzent < 65)
                Komponente4 = 3;

            //  Komponente 5  Schlafstörungen

            int Komponente5 = 0;

            int PSQIsummefragenschlafstörungen = PSQIschlechtgeschlafenaufgewachtZahl + PSQIschlechtgeschlafentoiletteZahl + PSQIschlechtgeschlafenbeschwerdenatmenZahl + PSQIschlechtgeschlafenhustengeschnarchtZahl + PSQIschlechtgeschlafenzukaltZahl + PSQIschlechtgeschlafenzuwarmZahl

+ PSQIschlechtgeschlafengeträumtZahl + PSQIschlechtgeschlafenschmerzenZahl + PSQIschlechtgeschlafenandereZahl;

            if (PSQIsummefragenschlafstörungen > 0 && PSQIsummefragenschlafstörungen <= 9)
                Komponente5 = 1;
            if (PSQIsummefragenschlafstörungen > 9 && PSQIsummefragenschlafstörungen <= 18)
                Komponente5 = 2;
            if (PSQIsummefragenschlafstörungen > 18)
                Komponente5 = 3;

            //  Komponente 6  Schlafmittelkonsum

            int Komponente6 = PSQIschlafmittelZahl;

            //  Komponente 7  Tagesschläfrigkeit

            int summefrage8und9 = PSQIschwierigkeitenwachzubleibenZahl + PSQIschwungZahl;

            int Komponente7 = 0;

            if (summefrage8und9 < 1)
                Komponente7 = 0;
            if (summefrage8und9 > 0 && summefrage8und9 < 3)
                Komponente7 = 1;
            if (summefrage8und9 > 2 && summefrage8und9 < 5)
                Komponente7 = 2;
            if (summefrage8und9 > 4)
                Komponente7 = 3;

            //  Ergebnisse Komponenten PSQI

            Console.WriteLine("Das Ergebnis des Insmonia Severity Index ist {0}\n", summeISI);

            Console.WriteLine("Komponente 1 ist {0}\n", Komponente1);

            Console.WriteLine("Komponente 2 ist {0}\n", Komponente2);

            Console.WriteLine("Komponente 3 ist {0}\n", Komponente3);

            Console.WriteLine("Komponente 4 ist {0}\n", Komponente4);

            Console.WriteLine("Komponente 5 ist {0}\n", Komponente5);

            Console.WriteLine("Komponente 6 ist {0}\n", Komponente6);

            Console.WriteLine("Komponente 7 ist {0}\n", Komponente7);

            //  Gesamtwert PSQI

            int PSQIgesamtwert = Komponente1 + Komponente2 + Komponente3 + Komponente4 + Komponente5 + Komponente6 + Komponente7;

            Console.WriteLine("Der Gesamtwert PSQI ist {0}\n", PSQIgesamtwert);

            Console.ReadLine();

        }
    }
}
