using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_3
{
    class Person
    {
          //Deklarera/initiera medlemsvariabler.
        public string Förnamn;
        public string Efternamn;
        public string PersNr;

        public string FEL_MEDDELANDE = "Felaktigt inmatat personnummer. Försök igen!";
        public string utskriftMan = "Man";
        public string utskriftKvinna = "Kvinna";

        

          //Metod som kontrollerar att personnumret är korrekt inmatat. Tar emot personnummer som string.
        public string persNrKontroll(string personnummer)
        {
              //Initiera/deklarera variabler/arrayer nödvändiga för kontroll av personnummer.
            string[] allaSiffror; 
            
            string kontrollAvMånad;
            string kontrollAvDag;
            int månadTillInt;
            int dagTillInt;

            int LÄNGD_PERS_NR = 10;
            int MAX_MÅNADER = 12;
            int MAX_DAGAR = 31;

            int[] enskildaSiffror;
            int[] multipliceradeSiffror = new int[20];
            string[] deladeSiffror;
            int[] enbartEnSiffra;

            int temporärVar;
            string bådaSiffror;
            int temporärInt;
            int summaSiffror = 0;
            int restenEfter10 = 0;

              //Lägg in varje siffra från strängen "personnummer" i string arrayen "allaSiffror".
            allaSiffror = personnummer.Where(c => Char.IsDigit(c)).Select(c => c.ToString()).ToArray();
              //Om längden på string arrayen "allaSiffror" inte är 10, returnera felmeddelandet.
            if (allaSiffror.Length != LÄNGD_PERS_NR) return FEL_MEDDELANDE;
             

              //Kontrollera att personnumret/allaSiffror inte har födelsemånad större än 12, samt födelsedag större än 31. 
              //Konvertera till integers.
            kontrollAvMånad = allaSiffror[2] + allaSiffror[3];
            kontrollAvDag = allaSiffror[4] + allaSiffror[5];
            månadTillInt = int.Parse(kontrollAvMånad);
            dagTillInt = int.Parse(kontrollAvDag);
              //Om inskriven månad är större än 12 eller dag större än 31, returnera ett felmeddelande.
            if ((månadTillInt > MAX_MÅNADER) || (dagTillInt > MAX_DAGAR)) return FEL_MEDDELANDE;


              //Initiera ny integer array "enskildaSiffror". 
            enskildaSiffror = new int[allaSiffror.Length];
              // Konvertera över strängarna från string "allaSiffror" till siffror i "enskildaSiffror".
            for (int i = 0; i < allaSiffror.Length; i++)
            {
                temporärVar = int.Parse(allaSiffror[i]);
                enskildaSiffror[i] = temporärVar;
            }

              //Initiera extra variabel till foor-loop.
            int n = 0;
              //For-loop som multiplicerar varannan siffra med 2 och varannan med 1... 
              //under tiden n är mindre än längden på "enskildaSiffror".
              //Om det nya värdet efter att en siffra mulitplicerats med 2 är tvåsiffrigt...
              //separera siffrorna och spara dessa i enskilda platser i arrayen "multipliceradeSiffror".
            for (int i = 0; n < enskildaSiffror.Length; i++)
            {
                multipliceradeSiffror[i] = (enskildaSiffror[n] * 2);

                if (multipliceradeSiffror[i] > 9)
                {
                    bådaSiffror = multipliceradeSiffror[i].ToString();
                    deladeSiffror = bådaSiffror.Where(c => Char.IsDigit(c)).Select(c => c.ToString()).ToArray();
                    enbartEnSiffra = new int[deladeSiffror.Length];

                    for (int j = 0; j < deladeSiffror.Length; j++)
                    {
                        temporärVar = int.Parse(deladeSiffror[j]);
                        enbartEnSiffra[j] = temporärVar;
                    }

                    multipliceradeSiffror[i] = enbartEnSiffra[0];
                    i++;
                    multipliceradeSiffror[i] = enbartEnSiffra[1];
                }

                i++;
                n++;
                multipliceradeSiffror[i] = (enskildaSiffror[n] * 1);
                n++;
            }

              //For-loop som adderar alla enskilda värden i arrayen "multipliceradeSiffror",
              //samt sparar summan i "summaSiffror".
            for (int i = 0; i < multipliceradeSiffror.Length; i++)
            {
                temporärInt = multipliceradeSiffror[i];
                i++;
                summaSiffror += temporärInt + multipliceradeSiffror[i];
            }

              //Initiera ny variabel som får värdet av resterna efter division med 10.
            restenEfter10 = summaSiffror % 10;
              //Om "restenEfter10" är noll, personnummret är ok, returnera personnummret.
            if (restenEfter10 == 0) return(PersNr);
              //Annars är personnummer ej ok, returnera felmeddelande.
            else  return FEL_MEDDELANDE;
        }

          //Metod som kontrollerar om registrerad person är kvinna eller man.
          //Tar emot ett string värde som personnummer.
        public string kollAvKön(string personnummer)
        {
              //Initiera/deklarera variabler samt arrayer.
            double restenEfter2 = 0;
            int temporärVar;

            string[] helaPersNr = personnummer.Where(c => Char.IsDigit(c)).Select(c => c.ToString()).ToArray();
            int[] siffrorna = new int[helaPersNr.Length];

              //For-loop som konverterar string värdena i arrayen "helaPersNr",
              //till integers i arrayen "siffrorna".
            for (int i = 0; i < siffrorna.Length; i++)
            {
                temporärVar = int.Parse(helaPersNr[i]);
                siffrorna[i] = temporärVar;
            }

              //Resten efter division med 2 sparas i varibel.
            restenEfter2 = siffrorna[8] % 2;
              //Om resten är 0, talet är jämt, returnera utskrift för kvinna.
            if (restenEfter2 == 0) return utskriftKvinna;
              //Annars, talet är ojämt, returnera utskrift för man. 
            else return utskriftMan; 
        }
    }
}
