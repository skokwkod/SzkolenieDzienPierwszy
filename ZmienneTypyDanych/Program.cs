using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZmienneTypyDanych
{
    class Program
    {
        static void Main(string[] args)
        {
            //string nazwaZmiennej;

            //nazwaZmiennej = "abcd";
            //Console.WriteLine(nazwaZmiennej);


            //byte vByte = 255;
            //Console.WriteLine($"vByte: {vByte}");
            //Console.WriteLine($"byte min {Byte.MinValue}," +
            //    $"              byte max {Byte.MaxValue}");

            //sbyte sByte = 7;
            //Console.WriteLine($"vByte: {sByte}");
            //Console.WriteLine($"sbyte min {SByte.MinValue}," +
            //    $"              sbyte max {SByte.MaxValue}");

            //short vShort = 7;
            //Console.WriteLine($"short: {vShort}");
            //Console.WriteLine($"short min {Int16.MinValue}," +
            //    $"              short max {Int16.MaxValue}");

            //ushort uShort = 7;
            //Console.WriteLine($"ushort: {uShort}");
            //Console.WriteLine($"ushort min {UInt16.MinValue}," +
            //    $"              ushort max {UInt16.MaxValue}");

            //int vInt = 7;
            //Console.WriteLine($"int: {vInt}");
            //Console.WriteLine($"int min {Int32.MinValue}," +
            //    $"              ushort max {Int32.MaxValue}");

            //uint vuInt = 7;
            //Console.WriteLine($"uint: {vuInt}");
            //Console.WriteLine($"uint min {UInt32.MinValue}," +
            //    $"              uint max {UInt32.MaxValue}");

            //long vLong = 7;
            //Console.WriteLine($"long: {vLong}");
            //Console.WriteLine($"long min {Int64.MinValue}," +
            //    $"              long max {Int64.MaxValue}");

            //ulong vuLong = 7;
            //Console.WriteLine($"ulong: {vuLong}");
            //Console.WriteLine($"ulong min {UInt64.MinValue}," +
            //    $"              ulong max {UInt64.MaxValue}");



            //float vFloat = 0.4588f;
            //Console.WriteLine($"float: {vFloat}");
            //Console.WriteLine($"float min {Single.MinValue}," +
            //    $"              float max {Single.MaxValue}");

            //Console.WriteLine($"Wartosc float po formatowaniu {vFloat.ToString("0.00")}");
            //Console.WriteLine($"Wartosc float po formatowaniu {vFloat.ToString("#.000")}");

            //double vDouble = 0.4588;
            //Console.WriteLine($"Double: {vDouble}");
            //Console.WriteLine($"Double min {Double.MinValue}," +
            //    $"              Double max {Double.MaxValue}");


            //decimal vDecimal = 0.4588m;
            //Console.WriteLine($"Decimal: {vDecimal}");
            //Console.WriteLine($"Decimal min {Decimal.MinValue}," +
            //    $"              Decimal max {Decimal.MaxValue}");

            //bool vBool = true;
            //Console.WriteLine($"bool: {vBool}");
            //int? zmiennaNull = null;

            //char vChar = 'a';
            //Console.WriteLine($"vChar: {vChar}");

            //string imie = "Jan";
            //string nazwisko = "   Kowalski   ";
            //Console.WriteLine($" Imie: {imie.ToUpper()}, Nazwisko: {nazwisko.ToLower()}");
            //Console.WriteLine($"{imie}{nazwisko}");
            //Console.WriteLine($"{imie.Trim()}{nazwisko.Trim()}");
            //Console.WriteLine($"{imie}{nazwisko.Substring(2,2)}");

            //string sciezka1 = "C:\\windows\\";
            //string sciezka2 = $@"C:\windows\";

            //Console.WriteLine(sciezka1+" "+sciezka2);


            //dynamic zmiennaVar = 1.234f;

            //Console.WriteLine($"Zmienna var: {zmiennaVar.GetType()}");
            //zmiennaVar = "asasa";
            //Console.WriteLine($"Zmienna var: {zmiennaVar.GetType()}");

            //object obiekt = 0;
            //Console.WriteLine(obiekt);
            //Console.WriteLine(obiekt.GetType());
            //obiekt = "Hello World";
            //Console.WriteLine(obiekt);
            //Console.WriteLine(obiekt.GetType());


            ////DateTime


            //Console.WriteLine($"Teraz {DateTime.Now}");
            //Console.WriteLine($"Dzisiaj {DateTime.Today}");
            //Console.WriteLine($"Teraz {DateTime.Today.AddDays(-1)}");
            //Console.WriteLine($"Jutro {DateTime.Today.AddDays(1)}");
            //Console.WriteLine($"Dzień roku: {DateTime.Today.DayOfYear}");
            //Console.WriteLine($"Teraz {DateTime.UtcNow}");


            //DateTime date1 = DateTime.Now;
            //DateTime date2 = DateTime.UtcNow;

            //Console.WriteLine(date2+"   "+ date2.ToLocalTime());
            //Console.WriteLine($"Data krotki format {date1.ToShortDateString()}");
            //Console.WriteLine($"Data dlugi format {date1.ToLongDateString()}");

            //Console.WriteLine($"Data krotki format {date1.ToShortTimeString()}");
            //Console.WriteLine($"Data dlugi format {date1.ToLongTimeString()}");

            //Console.WriteLine($"Nasz format {date1.ToString("yyyy/MM/dd  hh:mm:ss")}");
            //Console.WriteLine($"Nasz format {date1.ToString("yyyy/MM/dd  HH:mm:ss")}");

            //DateTime dateTime = new DateTime(2017, 9, 18);

            //Console.WriteLine(dateTime.ToLongDateString());

            //Console.WriteLine(typeof(string));
            //Console.WriteLine(typeof(DateTime));

            //Console.WriteLine($"Dzień roku: {DateTime.Now.DayOfYear}");
            //Console.WriteLine($"Przestepny: {DateTime.IsLeapYear(DateTime.Now.Year).ToString()}");
            //Console.WriteLine($"Jutro dzien: {DateTime.Today.AddDays(1).DayOfWeek}");

            //string imie1;
            //string nazwisko1;
            //Console.WriteLine("Podaj imię;");
            //imie1 = Console.ReadLine();
            //Console.WriteLine("Podaj nazwisko;");
            //nazwisko1 = Console.ReadLine();
            //Console.WriteLine($"Inicjaly: {imie1.Substring(0,1).ToUpper()}{nazwisko1.Substring(0,1).ToUpper()}");

            float a = 1, b = 0;
            Console.WriteLine(a/b);

            Console.ReadKey();
        }
    }
}
