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
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();


            // Insomnia Severity Index

            // Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.WriteLine("INSOMNIA SEVERITY INDEX\n");
            
            Console.WriteLine("Wie oft hatten Sie in den letzten vier Wochen:\nSchwierigkeit, einzuschlafen:\n(0 = keine; 1 = leichte; 2 = mäßige; 3 = starke, 4 = sehr starke)");
            string ISIeinzuschlafen = Console.ReadLine();
            int ISIeinzuschlafenZahl = Convert.ToInt32(ISIeinzuschlafen);
            Console.WriteLine("\nSchwierigkeit, durchzuschlafen:\n(0 = keine; 1 = leichte; 2 = mäßige; 3 = starke, 4 = sehr starke)");
            string ISIdurchzuschlafen = Console.ReadLine();
            int ISIdurchzuschlafenZahl = Convert.ToInt32(ISIdurchzuschlafen);
            Console.WriteLine("\nDas Problem, am Morgen früh aufzuwachen:\n(0 = kein; 1 = leicht; 2 = mäßig; 3 = stark, 4 = sehr stark)");
            string ISIaufzuwachen = Console.ReadLine();
            int ISIaufzuwachenZahl = Convert.ToInt32(ISIaufzuwachen);
            Console.WriteLine("\nWie zufrieden/unzufrieden sind Sie mit Ihrem aktuellen Schlafverhalten?\n(0 = sehr zufrieden, 1 = zufrieden, 2 = neutral, 3 = unzufrieden, 4 = sehr unzufrieden)");
            string ISIunzufrieden = Console.ReadLine();
            int ISIunzufriedenZahl = Convert.ToInt32(ISIunzufrieden);
            Console.WriteLine("\nIn welchem Ausmaß beeinflussen Ihre Schlafprobleme Alltagsfunktionen?\n(0 = überhaupt nicht, 1 = wenig, 2 = etwas, 3 = stark, 4 = sehr stark)");
            string ISIalltagsfunktionen = Console.ReadLine();
            int ISIalltagsfunktionenZahl = Convert.ToInt32(ISIalltagsfunktionen);
            Console.WriteLine("\nIn welchem Ausmaß nehmen Ihre Mitmenschen Ihr Schlafproblem wahr?\n(0 = überhaupt nicht, 1 = wenig, 2 = etwas, 3 = stark, 4 = sehr stark)");
            string ISImitmenschen = Console.ReadLine();
            int ISImitmenschenZahl = Convert.ToInt32(ISImitmenschen);
            Console.WriteLine("\nWie besorgt/bedrückt sind Sie durch Ihre Schlafprobleme?\n(0 = überhaupt nicht, 1 = wenig, 2 = etwas, 3 = stark, 4 = sehr stark)");
            string ISIbesorgt = Console.ReadLine();
            int ISIbesorgtZahl = Convert.ToInt32(ISIbesorgt);

            int summeISI = ISIeinzuschlafenZahl + ISIdurchzuschlafenZahl + ISIaufzuwachenZahl + ISIunzufriedenZahl + ISIalltagsfunktionenZahl + ISImitmenschenZahl + ISIbesorgtZahl;

            // Auswertung Insomnia Severity Index

            if (summeISI < 8)
                Console.WriteLine("\nDER INSOMNIA SEVERITY INDEX IST UNAUFFÄLLIG\n");
            if (summeISI > 7 && summeISI < 15)
                Console.WriteLine("\nDER INSOMNIA SEVERITY INDEX ZEIGT EINE UNTERSCHWELLIGE INSOMNIE\n");
            if (summeISI > 14 && summeISI < 22)
                Console.WriteLine("\nDER INSOMNIA SEVERITY INDEX ZEIGT EINE MITTELGRADIGE INSOMNIE\n");
            if (summeISI > 21)
                Console.WriteLine("\nDER INSOMNIA SEVERITY INDEX ZEIGT EINE SCHWERGRADIGE INSOMNIE\n");

            Console.WriteLine("Weiter mit Enter-Taste\n");
            Console.ReadLine();

            Console.WriteLine("\nPITTSBURGH SLEEP QUALITY INDEX\n");


            //  Pittsburgh Sleep Quality Index

            Console.WriteLine("Die folgenden Fragen beziehen sich auf Ihre üblichen Schlafgewohnheiten und zwar nur während der letzten vier Wochen.\nIhre Antworten sollten möglichst genau sein und sich auf die Mehrzahl der Tage und Nächte während der letzten vier Wochen beziehen.\nBeantworten Sie bitte alle Fragen.\n");


            Console.WriteLine("Wann sind Sie während der letzten vier Wochen gewöhnlich abends zu Bett gegangen?\n(Format hh:mm)");
            string PSQIzubett = Console.ReadLine();
            var PSQIzuBettZeit = DateTime.Parse(PSQIzubett);
            Console.WriteLine("\nWie lange hat es während der letzten vier Wochen gewöhnlich gedauert, bis Sie nachts eingeschlafen sind?\n(1 für unter 15 min; 2 für 16 bis 30 min; 3 für 31 bis 60 min; 4 für mehr als 60 min)");
            string PSQIlatenz = Console.ReadLine();
            int PSQIlatenzZahl = Convert.ToInt32(PSQIlatenz);
            Console.WriteLine("\nWann sind Sie während der letzten vier Wochen gewöhnlich morgens aufgestanden?\n(Format hh:mm)");
            string PSQIaufgestanden = Console.ReadLine();
            var PSQIaufgestandenZeit = DateTime.Parse(PSQIaufgestanden);
            Console.WriteLine("\nWieviele Stunden haben Sie während der letzten vier Wochen pro Nacht tatsächlich geschlafen?\n(Das muß nicht mit der Anzahl der Stunden, die Sie im Bett verbracht haben, übereinstimmen)\n(Format hh:mm)");
            string PSQIschlafdauer = Console.ReadLine();
            TimeSpan PSQIschlafdauerZeit = TimeSpan.Parse(PSQIschlafdauer);

            Console.WriteLine("\n\nBeantworten Sie bitte die folgenden 13 Fragen nach diesem Schema:\n\nWährend der letzten 4 Wochen gar nicht = 0\nWeniger als einmal pro Woche = 1\nEinmal oder zweimal pro Woche = 2\nDreimal oder häufiger pro Woche = 3");
            Console.WriteLine("\nWie oft haben Sie insgesamt in den letzten 4 Wochen schlecht geschlafen\n...weil Sie nicht innerhalb von 30 Min einschlafen konnten?");
            string PSQIschlechtgeschlafeneinschlafen = Console.ReadLine();
            int PSQIschlechtgeschlafeneinschlafenZahl = Convert.ToInt32(PSQIschlechtgeschlafeneinschlafen);
            Console.WriteLine("\n..weil Sie mitten in der Nacht oder frühmorgens aufgewacht sind?");
            string PSQIschlechtgeschlafenaufgewacht = Console.ReadLine();
            int PSQIschlechtgeschlafenaufgewachtZahl = Convert.ToInt32(PSQIschlechtgeschlafenaufgewacht);
            Console.WriteLine("\n...weil Sie aufstehen mussten um zur Toilette zu gehen?");
            string PSQIschlechtgeschlafentoilette = Console.ReadLine();
            int PSQIschlechtgeschlafentoiletteZahl = Convert.ToInt32(PSQIschlechtgeschlafentoilette);
            Console.WriteLine("\n...weil Sie Beschwerden beim Atmen hatten?");
            string PSQIschlechtgeschlafenbeschwerdenatmen = Console.ReadLine();
            int PSQIschlechtgeschlafenbeschwerdenatmenZahl = Convert.ToInt32(PSQIschlechtgeschlafenbeschwerdenatmen);
            Console.WriteLine("\n...weil Sie husten mussten oder laut geschnarcht haben?");
            string PSQIschlechtgeschlafenhustengeschnarcht = Console.ReadLine();
            int PSQIschlechtgeschlafenhustengeschnarchtZahl = Convert.ToInt32(PSQIschlechtgeschlafenhustengeschnarcht);
            Console.WriteLine("\n...weil Ihnen zu kalt war?");
            string PSQIschlechtgeschlafenzukalt = Console.ReadLine();
            int PSQIschlechtgeschlafenzukaltZahl = Convert.ToInt32(PSQIschlechtgeschlafenzukalt);
            Console.WriteLine("\n...weil Ihnen zu warm war?");
            string PSQIschlechtgeschlafenzuwarm = Console.ReadLine();
            int PSQIschlechtgeschlafenzuwarmZahl = Convert.ToInt32(PSQIschlechtgeschlafenzuwarm);
            Console.WriteLine("\n...weil Sie schlecht geträumt hatten?");
            string PSQIschlechtgeschlafengeträumt = Console.ReadLine();
            int PSQIschlechtgeschlafengeträumtZahl = Convert.ToInt32(PSQIschlechtgeschlafengeträumt);
            Console.WriteLine("\n...weil Sie Schmerzen hatten?");
            string PSQIschechtgeschlafenschmerzen = Console.ReadLine();
            int PSQIschlechtgeschlafenschmerzenZahl = Convert.ToInt32(PSQIschechtgeschlafenschmerzen);
            Console.WriteLine("\n...aus anderen Gründen?");
            string PSQIschlechtgeschlafenandere = Console.ReadLine();
            int PSQIschlechtgeschlafenandereZahl = Convert.ToInt32(PSQIschlechtgeschlafenandere);


            Console.WriteLine("\nWie oft haben Sie während der letzten vier Wochen Schlafmittel eingenommen(vom Arzt verschriebene oder frei verkäufliche)?");
            string PSQIschlafmittel = Console.ReadLine();
            int PSQIschlafmittelZahl = Convert.ToInt32(PSQIschlafmittel);
            Console.WriteLine("\nWie oft hatten Sie während der letzten vier Wochen Schwierigkeiten wachzubleiben, etwa beim Autofahren, beim Essen oder bei gesellschaftlichen Anlässen?");
            string PSQIschwierigkeitenwachzubleiben = Console.ReadLine();
            int PSQIschwierigkeitenwachzubleibenZahl = Convert.ToInt32(PSQIschwierigkeitenwachzubleiben);
            Console.WriteLine("\nHatten Sie während der letzten vier Wochen Probleme mit genügend Schwung die üblichen Alltagsaufgaben zu erledigen?\n(keine Probleme = 0; kaum Probleme = 1; etwas Probleme =2; große Probleme = 3)");
            string PSQIschwung = Console.ReadLine();
            int PSQIschwungZahl = Convert.ToInt32(PSQIschwung);
            Console.WriteLine("\nWie würden Sie insgesamt die Qualität Ihres Schlafes beurteilen?\n(sehr gut = 0; ziemlich gut = 1; ziemlich schlecht = 2; sehr schlecht = 3)");
            string PSQIqualitätinsgesamt = Console.ReadLine();
            int PSQIqualitätinsgesamtZahl = Convert.ToInt32(PSQIschwung);

            //  Abschnitt Bettpartner

            int PSQIschnarchenZahl = 0;
            int PSQIatempausenZahl = 0;
            int PSQIbewegungenZahl = 0;
            int PSQIverwirrungZahl = 0;


            Console.WriteLine("\n\nSchlafen Sie allein in Ihrem Zimmer?\n(Ja = 0/Nein = 1)");
            string PSQIschlafeallein = Console.ReadLine();
            int PSQIschlafealleinZahl = Convert.ToInt32(PSQIschlafeallein);

            if (PSQIschlafealleinZahl > 0)
            {
                Console.WriteLine("\n\nBeantworten Sie bitte die folgenden 4 Fragen nach diesem Schema:\nWährend der letzten 4 Wochen gar nicht = 0\nWeniger als einmal pro Woche = 1\nEinmal oder zweimal pro Woche = 2\nDreimal oder häufiger pro Woche = 3\n");

                Console.WriteLine("Bitte fragen Sie Ihre(n) Mitbewohner(in)/Partner(in), ob und wie oft er/sie bei Ihnen folgendes bemerkt hat:\n");

                Console.WriteLine("\nLautes Schnarchen?");
                string PSQIschnarchen = Console.ReadLine();
                PSQIschnarchenZahl = Convert.ToInt32(PSQIschnarchen);

                Console.WriteLine("\nLange Atempausen während des Schlafes?");
                string PSQIatempausen = Console.ReadLine();
                PSQIatempausenZahl = Convert.ToInt32(PSQIatempausen);

                Console.WriteLine("\nZucken oder ruckartige Bewegungen der Beine während des Schlafes?");
                string PSQIbewegungen = Console.ReadLine();
                PSQIbewegungenZahl = Convert.ToInt32(PSQIbewegungen);

                Console.WriteLine("\nNächtliche Phasen von Verwirrung oder Desorientierung während des Schlafes?");
                string PSQIverwirrung = Console.ReadLine();
                PSQIverwirrungZahl = Convert.ToInt32(PSQIverwirrung);

            }

            //  Auswertung PSQI

            Console.WriteLine("\n\nAUSWERTUNG PITTSBURGH SLEEP QUALITY INDEX\n");


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

            TimeSpan siebenstunden = new TimeSpan(0, 7, 0, 0);
            TimeSpan sechsstunden = new TimeSpan(0, 6, 0, 0);
            TimeSpan fünfstunden = new TimeSpan(0, 5, 0, 0);

            if (PSQIschlafdauerZeit >= siebenstunden)
                Komponente3 = 0;
            if (PSQIschlafdauerZeit < siebenstunden && PSQIschlafdauerZeit >= sechsstunden)
                Komponente3 = 1;
            if (PSQIschlafdauerZeit < sechsstunden && PSQIschlafdauerZeit >= fünfstunden)
                Komponente3 = 2;
            if (PSQIschlafdauerZeit < fünfstunden)
                Komponente3 = 3;

            //  Komponente 4  Schlafeffizienz

            TimeSpan PSQIbettzeit = PSQIaufgestandenZeit - PSQIzuBettZeit;

            TimeSpan span1 = new TimeSpan(0, 24, 0, 0);

            TimeSpan Bettzeit = PSQIbettzeit.Add(span1);

            string BettzeitString = Bettzeit.ToString("hh\\:mm");

            Console.WriteLine("Die Bettzeit ist {0} Stunden\n", BettzeitString);

            Console.WriteLine("Die tatsächliche Schlafdauer ist {0} Stunden\n",PSQIschlafdauer);

            double PSQIschlafeffizienzquotient = (double)PSQIschlafdauerZeit.Ticks / Bettzeit.Ticks;

            double PSQIschlafeffizienzProzent = PSQIschlafeffizienzquotient * 100;

            int PSQIschlafeffizienzGerundet = Convert.ToInt32(PSQIschlafeffizienzProzent) ;

            Console.WriteLine("Die Schlafeffizient ist {0}%\n", PSQIschlafeffizienzGerundet);


            int Komponente4 = 0;

            if (PSQIschlafeffizienzProzent >= 85)
                Komponente4 = 0;
            if (PSQIschlafeffizienzProzent < 85 && PSQIschlafeffizienzProzent >= 75)
                Komponente4 = 1;
            if (PSQIschlafeffizienzProzent < 75 && PSQIschlafeffizienzProzent >= 65)
                Komponente4 = 2;
            if (PSQIschlafeffizienzProzent < 65)
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

            Console.WriteLine("Komponente 1, Subjektive Schlafqualität: Wert ist {0}", Komponente1);

            Console.WriteLine("Komponente 2, Schlaflatenz: Wert ist {0}", Komponente2);

            Console.WriteLine("Komponente 3, Schlafdauer: Wert ist {0}", Komponente3);

            Console.WriteLine("Komponente 4, Schlafeffizienz: Wert ist {0}", Komponente4);

            Console.WriteLine("Komponente 5, Schlafstörungen: Wert ist {0}", Komponente5);

            Console.WriteLine("Komponente 6, Schlafmittelkonsum: Wert ist {0}", Komponente6);

            Console.WriteLine("Komponente 7, Tagesschläfrigkeit: Wert ist {0}\n", Komponente7);

            //  Gesamtwert PSQI

            int PSQIgesamtwert = Komponente1 + Komponente2 + Komponente3 + Komponente4 + Komponente5 + Komponente6 + Komponente7;

            Console.WriteLine("DER GESAMTWERT DES PSQI IST {0} PUNKTE\n", PSQIgesamtwert);


            Console.WriteLine("Weiter mit Enter-Taste\n");
            Console.ReadLine();

            Console.WriteLine("\nSTOP-BANG FRAGEBOGEN\n");


            // STOP Bang

            Console.WriteLine("Schnarchen Sie laut (so laut, dass es durch geschlossene Türen hörbar ist oder dass Ihr(e) Bettnachbar(in) Sie nachts mit dem Ellbogen anstößt, weil Sie schnarchen)?\nJa =1 Nein=0");
            string SBschnarchen = Console.ReadLine();
            int SBschnarchenZahl = Convert.ToInt32(SBschnarchen);
            Console.WriteLine("\nSind Sie tagsüber oft müde, erschöpft oder schläfrig (schlafen Sie z. B. beim Autofahren ein)?\nJa = 1 Nein=0");
            string SBmüde = Console.ReadLine();
            int SBmüdeZahl = Convert.ToInt32(SBmüde);
            Console.WriteLine("\nIst es schon einmal jemandem aufgefallen, dass Sie im Schlaf aufhören zu atmen oder keine Luft mehr bekommen/nach Luft schnappen?\nJa =1 Nein=0");
            string SBaufhörenzuatmen = Console.ReadLine();
            int SBaufhörenzuatmenZahl = Convert.ToInt32(SBaufhörenzuatmen);
            Console.WriteLine("\nHaben Sie Bluthochdruck oder werden Sie dagegen behandelt?\nJa=1 Nein=0");
            string SBbluthochdruck = Console.ReadLine();
            int SBbluthochdruckzahl = Convert.ToInt32(SBbluthochdruck);
            Console.WriteLine("\nBody Mass Index über 35 kg/m2?\nJa=1 Nein=0");
            string SBbodymass = Console.ReadLine();
            int SBbodymassZahl = Convert.ToInt32(SBbodymass);
            Console.WriteLine("\nSind Sie über 50 Jahre alt?\nJa=1 Nein=0");
            string SBüberfünfzigjahre = Console.ReadLine();
            int SBüberfünfzigjahreZahl = Convert.ToInt32(SBüberfünfzigjahre);
            Console.WriteLine("\nBei Männern: Haben Sie eine Kragenweite von über 43cm? Bei Frauen: Haben Sie eine Kragenweite von über 41cm?\nJa=1 Nein=0");
            string SBkragenweite = Console.ReadLine();
            int SBkragenweiteZahl = Convert.ToInt32(SBkragenweite);
            Console.WriteLine("\nGeschlecht männlich?\nJa=1 Nein=0");
            string SBmännlich = Console.ReadLine();
            int SBmännlichZahl = Convert.ToInt32(SBmännlich);


            // Auswertung STOP-Bang

            Console.WriteLine("\n\nAUSWERTUNG STOP-BANG FRAGEBOGEN");

            int SBsummefragen1bis4 = SBschnarchenZahl + SBmüdeZahl + SBaufhörenzuatmenZahl + SBbluthochdruckzahl;

            int SBsummefragen1bis8 = SBsummefragen1bis4 + SBbodymassZahl + SBüberfünfzigjahreZahl + SBkragenweiteZahl + SBmännlichZahl;

            int SBhochrisikofaktoren = SBbodymassZahl + SBkragenweiteZahl + SBmännlichZahl;

            Console.WriteLine("\nHochrisikofaktoren Wert = {0}\n", SBhochrisikofaktoren);

            int SBrisikoOSA = 0;

            if (SBsummefragen1bis8 < 3)
            {
                SBrisikoOSA = 1;
                Console.WriteLine("DER STOP-BANG ERGIBT EIN NIEDRIGES RISIKO FÜR OSA");
            }
            if (SBhochrisikofaktoren < 1 && SBsummefragen1bis8 > 2 && SBsummefragen1bis8 < 5)
            {
                SBrisikoOSA = 2;
                Console.WriteLine("DER STOP-BANG ERGIBT EIN MITTLERES RISIKO FÜR OSA");
            }
            if ((SBsummefragen1bis8 > 4) || (SBhochrisikofaktoren > 0 && SBsummefragen1bis4 > 1))
            {
                SBrisikoOSA = 3;
                Console.WriteLine("DER STOP BANG ERGIBT EIN HOHES RISIKO FÜR OSA");

            }
            Console.ReadLine();




            //  GESAMTAUSWERTUNG



            //  OSA

            if (SBrisikoOSA > 1
            ||  PSQIschlechtgeschlafenbeschwerdenatmenZahl > 1
            ||  PSQIschlechtgeschlafenhustengeschnarchtZahl > 1
            ||  PSQIschwierigkeitenwachzubleibenZahl > 1
            ||  PSQIschwungZahl > 2
            ||  PSQIschnarchenZahl > 1
            ||  PSQIatempausenZahl > 1)
            { 
            Console.WriteLine("\n\n\nERGEBNIS DER GESAMTAUSWERTUNG");
            Console.WriteLine("\n\nBei Ihnen sollte zuerst eine obstruktive Schlafapnoe (OSA) ausgeschlossen werden.\nHierzu sollte als nächstes eine ambulante Schlafuntersuchung (Polygraphie) erfolgen.");
            Console.ReadLine();
            Environment.Exit(0);
            }



            //  Verwirrung

            if (PSQIverwirrungZahl > 0)
            {
            Console.WriteLine("\n\n\nERGEBNIS DER GESAMTAUSWERTUNG");
            Console.WriteLine("\n\nDie nächtlichen Verwirrtheitszustände sind ungewöhnlich und sollten besser gründlich untersucht werden.\nHierzu sollten Sie einen erfahrenen Schlafmediziner konsultieren.");
            Console.ReadLine();
            Environment.Exit(0);
            }



            //  Nykturie

            if (PSQIschlechtgeschlafentoiletteZahl > 2)
            {
            Console.WriteLine("\n\n\nERGEBNIS DER GESAMTAUSWERTUNG");
            Console.WriteLine("\n\nBei Ihnen sollte zuerst der nächtliche Harndrang weiter untersucht werden.\nDieser kann eine Reihe von unterschiedlichen Ursachen haben.");
            Console.ReadLine();
            Environment.Exit(0);
            }



            //  PLMS

            if (PSQIbewegungenZahl > 1)
            {
            Console.WriteLine("\n\n\nERGEBNIS DER GESAMTAUSWERTUNG");
            Console.WriteLine("\n\nBei Ihnen sollten zuerst periodische Beinbewegungen im Schlaf (PLMS) als Ursache Ihrer Schlafstörung ausgeschlossen werden.\nDies kann am besten im Schlaflabor erfolgen.\n Zu diesem Zweck sollten Sie...");
            Console.ReadLine();
            Environment.Exit(0);
            }



            //  Schmerzen

            if (PSQIschlechtgeschlafenschmerzenZahl > 1)
            {
            Console.WriteLine("\n\n\nERGEBNIS DER GESAMTAUSWERTUNG");
            Console.WriteLine("\n\nBei Ihnen scheinen Schmerzen zumindest eine der Ursachen der Schlafprobleme zu sein.\nEs sollte zuerst eine ausreichende Schmerztherapie begonnen werden.\n Wen dies nicht möglich ist sollte...");
            Console.ReadLine();
            Environment.Exit(0);
            }



            //  Albträume/Pavor nocturnus

            if (PSQIschlechtgeschlafengeträumtZahl > 1)
            {
             Console.WriteLine("\n\n\nERGEBNIS DER GESAMTAUSWERTUNG");
             Console.WriteLine("\n\nBei Ihnen scheinen Albträume zumindest eine wichtige Ursache der Schlafstörungen zu sein.\nDiese sollten deshalb zuerst behandelt werden. Es gibt verhaltenstherapeutische...");
             Console.ReadLine();
             Environment.Exit(0);
            }



            //  Psychophysiologische Insomnie

            if (summeISI > 7
            &&
              (PSQIlatenzZahl > 1
            || PSQIschlechtgeschlafeneinschlafenZahl >1
            || Komponente3 > 1
            || Komponente4 > 0
            || PSQIschlechtgeschlafenaufgewachtZahl > 1
            ))
            {
            Console.WriteLine("\n\n\nERGEBNIS DER GESAMTAUSWERTUNG");
            Console.WriteLine("\n\nBei Ihnen liegt am wahrscheinlichsten eine psychophysiologische Insomnie vor.\nDiese kann erfolgreich behandelt werden. Es gibt verhaltenstherapeutische...");
            Console.ReadLine();
            Environment.Exit(0);
            }



            //  nicht sicher einzuordnen

            Console.WriteLine("\n\n\nERGEBNIS DER GESAMTAUSWERTUNG");
            Console.WriteLine("\n\nIhre Schlafstörung lässt sich auf Grund der bisher vorliegenden Angaben nicht mit ausreichender Sicherheit einordnen.\nWir empfehlen daher eine Vorstellung bei einem qualifizierten Schlafmediziner.");
            Console.ReadLine();
            Environment.Exit(0);






        }
    }
}
