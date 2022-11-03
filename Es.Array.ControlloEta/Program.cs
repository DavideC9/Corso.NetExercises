using System;
using System.Globalization;

namespace EsercizioArray
{
    class Program
    {
        static void Main(string[] args)
        {

            Citta Milano = new("Milano", 7500);

            Cittadino Mauro = new("Mauro", "Del Prete","" ,  "via del furno","", Milano);


            
            Milano.AggiungiCittadino(Mauro);

            Cittadino Fabio = new("Fabio", "Lauro",  , "via del catanio","", Milano);

            Milano.AggiungiCittadino(Fabio);



            

            Citta Roma = new("Roma", 423456543);

            Cittadino Antonio = new("Antonio", "ranallo", , "trastevere","", Roma);

            Roma.AggiungiCittadino(Antonio);



            Milano._Anagrafica.ForEach(PrintCitizen);
            Roma._Anagrafica.ForEach(PrintCitizen);


            Console.WriteLine("\n");

            CreateTimeSpan();
        }

        static void PrintCitizen(Cittadino person)
        {
            Console.WriteLine("\nCitta':" + person._citta._nome);
            Console.WriteLine("Numero abitanti : " + person._citta._Anagrafica.Count + "\nNumero massimo di abitanti :"+ person._citta._numMaxabitanti +
                "\nNumero di abitanti ancora possibili:"+ (person._citta._numMaxabitanti - person._citta._Anagrafica.Count));
            Console.WriteLine("Nome : " + person._nome + "\nCognome: " + person._cognome + "\n Data Di Nascita "+ person._datadinascita +"\nIndirizzo: " + person._indirizzo );
            
      
        }






        ///////////
        ///
        

        public static void TimezonesList(DateTime currentTime)
        {
            Console.WriteLine("Los Angeles: {0}",
                              TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "Pacific Standard Time"));
            Console.WriteLine("Chicago: {0}",
                              TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "Central Standard Time"));
            Console.WriteLine("New York: {0}",
                              TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "Eastern Standard Time"));
            Console.WriteLine("London: {0}",
                              TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "GMT Standard Time"));
            Console.WriteLine("Moscow: {0}",
                              TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "Russian Standard Time"));
            Console.WriteLine("New Delhi: {0}",
                              TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "India Standard Time"));
            Console.WriteLine("Beijing: {0}",
                              TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "China Standard Time"));
            Console.WriteLine("Tokyo: {0}",
                              TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "Tokyo Standard Time"));
        }


        public static void GetdateFromInput()
        {
            Console.WriteLine("Inserire una  data: ");
            string input = Console.ReadLine();

            DateTime result;

            if (DateTime.TryParse(input, out result))
            {
                Console.WriteLine($" -  TryParse {result}");
            }
            else
            {
                Console.WriteLine($" - TryParse  Failed! ");

            }

        }
        public static void ForcingFormat()
        {

            string[] dateFormats = new string[] { "yyyy/MM/dd" };
            CultureInfo cultureInfo = new CultureInfo("en-US");

            Console.WriteLine("Inserire una  data: ");
            string input = Console.ReadLine();

            DateTime result;


            if (DateTime.TryParseExact(input,
                dateFormats,
                cultureInfo,
                DateTimeStyles.AdjustToUniversal,
                out result))
            {
                Console.WriteLine($" -  TryParse {result}");
            }
            else
            {
                Console.WriteLine($" - TryParse  Failed! ");

            }

        }

        public static void CreateDayOfWeek()
        {
            DateTime birthday = new DateTime(1982, 01, 14);
            DateTime today = DateTime.Now;


            if (birthday.DayOfWeek == today.DayOfWeek)
                Console.WriteLine("Today is the same day of your birthday!");
            else
                Console.WriteLine($"You were born on {birthday.DayOfWeek} but today is {today.DayOfWeek}");

            CultureInfo cultureInfo = new CultureInfo("fr-FR");

            var bd = cultureInfo.DateTimeFormat.GetDayName(birthday.DayOfWeek);
            var td = cultureInfo.DateTimeFormat.GetDayName(today.DayOfWeek);

            if (bd == td)
                Console.WriteLine("Today is the same day of your birthday!");
            else
                Console.WriteLine($"You were born on {bd} but today is {td}");


            //DateTime myDate = new DateTime(2022,11,02,10,30,45);  
            //int year = myDate.Year;
            //int Month = myDate.Month;
            //int Day = myDate.Day;
            //int Hour = myDate.Hour;
            //int Minute = myDate.Minute;
            //int Second = myDate.Second;

        }
        public static void AutomaticConvertion()
        {
            DateTime dateTime = DateTime.Now;

            string dateInUSA = dateTime.ToString("D", new CultureInfo("en-US"));
            string dateInFR = dateTime.ToString("D", new CultureInfo("fr-FR"));
            string dateInIT = dateTime.ToString("D", new CultureInfo("it"));
            string dateInDE = dateTime.ToString("D", new CultureInfo("de"));

            Console.WriteLine(dateInUSA);
            Console.WriteLine(dateInFR);
            Console.WriteLine(dateInIT);
            Console.WriteLine(dateInDE);
        }

        public static void CreateTimeSpan()
        {

            //TimeSpan timeSpanoggi = new TimeSpan(0, 0, 0, 0);





            //TimeSpan timeSpan = new TimeSpan(30, 0, 0, 0);


            //Console.WriteLine(timeSpan);

            DateTime mydate = DateTime.Now;



            // 30 gg in piu
            //DateTime mydate2 = DateTime.Now.Add(timeSpan);

            Console.WriteLine(mydate);
            Console.WriteLine(mydate.ToString("D"));
            Console.WriteLine(mydate.ToString("g"));


            //Console.WriteLine(mydate2);


            // 120 gg in piu 
            //DateTime mydate3 = DateTime.Now.AddDays(120);
            //Console.WriteLine(mydate3);

            // 90 gg in piu 
            //Console.WriteLine(mydate3.Subtract(timeSpan));

        }


    }

    
}

