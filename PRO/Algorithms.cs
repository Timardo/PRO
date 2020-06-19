using System;
using System.Globalization;

namespace PRO
{
    class Algorithms
    {
        internal static string ZobrazitCas()
        {
            DateTime current = DateTime.Now;
            string format = "dd.MM.yyyy";
            DateTime startJar = DateTime.ParseExact("22.02.2020", format, CultureInfo.InvariantCulture);
            DateTime startLet = DateTime.ParseExact("01.07.2020", format, CultureInfo.InvariantCulture);
            DateTime startJes = DateTime.ParseExact("29.10.2020", format, CultureInfo.InvariantCulture);
            TimeSpan gapJar = current.Subtract(startJar);
            TimeSpan gapLet = current.Subtract(startLet);
            TimeSpan gapJes = current.Subtract(startJes);
            bool predJar = gapJar.TotalDays < 0;
            bool predLet = gapLet.TotalDays < 0;
            bool predJes = gapJes.TotalDays < 0;
            string ret = (predJar ? "Do" : "Od") + " jarných prázdnin " + (predJar ? "zostáva " + gapJar.Negate().Days : "ubehlo " + gapJar.Days) + (Math.Abs(gapJar.Days) == 1 ? " deň " : Math.Abs(gapJar.Days) > 1 && Math.Abs(gapJar.Days) < 5 ? " dni " :" dní " ) + gapJar.ToString().Substring(gapJar.ToString().IndexOf('.') + 1, gapJar.ToString().LastIndexOf('.') - gapJar.ToString().IndexOf('.') - 1) + Environment.NewLine;
            ret += (predLet ? "Do" : "Od") + " letných prázdnin " + (predLet ? "zostáva " + gapLet.Negate().Days : "ubehlo " + gapLet.Days) + (Math.Abs(gapLet.Days) == 1 ? " deň " : Math.Abs(gapLet.Days) > 1 && Math.Abs(gapLet.Days) < 5 ? " dni " : " dní ") + gapLet.ToString().Substring(gapLet.ToString().IndexOf('.') + 1, gapLet.ToString().LastIndexOf('.') - gapLet.ToString().IndexOf('.') - 1) + Environment.NewLine;
            ret += (predJes ? "Do" : "Od") + " jesenných prázdnin " + (predJes ? "zostáva " + gapJes.Negate().Days : "ubehlo " + gapJes.Days) + (Math.Abs(gapJes.Days) == 1 ? " deň " : Math.Abs(gapJes.Days) > 1 && Math.Abs(gapJes.Days) < 5 ? " dni " : " dní ") + gapJes.ToString().Substring(gapJes.ToString().IndexOf('.') + 1, gapJes.ToString().LastIndexOf('.') - gapJes.ToString().IndexOf('.') - 1) + Environment.NewLine;
            return ret;
        }

        internal static string RokAPocDni(string text)
        {
            try
            {
                string[] split = text.Split(' ');
                int rok = int.Parse(split[0]);
                int pocDni = int.Parse(split[1]) - 1;
                DateTime yr = new DateTime(rok, 1, 1);

                if ((pocDni > 365 && (rok / 4 != 0)) || pocDni > 366 || pocDni < 1)
                    return "Počet zadaných dní nie je v poriadku" + Environment.NewLine;

                DateTime vys = yr.AddDays(pocDni);
                return "Dátum zo zadaných informácií: " + vys.ToString("dd.MM.yyyy", CultureInfo.CurrentCulture) + Environment.NewLine;
            }

            catch
            {
                return "Ďalej to už nepôjde, správny formát: rok(int) počet_dní(int)" + Environment.NewLine;
            }
        }

        internal static string CasoveInfo(string input)
        {
            try
            {
                DateTime current = DateTime.Now;
                DateTime inDate = DateTime.ParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                TimeSpan span = current.Subtract(inDate);
                bool pred = span.TotalDays < 0;
                int i = (int)inDate.DayOfWeek;
                string ret = "";

                if (span.Days == 0)
                    ret += "Zadaný dátum je dnešný, ubehlo toľko, koľko je na hodinách";
                else
                    ret += (pred ? "Do" : "Od") + " zadaného dátumu " + (pred ? "zostáva " + span.Negate().Days : "ubehlo " + span.Days) + (Math.Abs(span.Days) == 1 ? " deň " : Math.Abs(span.Days) > 1 && Math.Abs(span.Days) < 5 ? " dni " : " dní ") + span.ToString().Substring(span.ToString().IndexOf('.') + 1, span.ToString().LastIndexOf('.') - span.ToString().IndexOf('.') - 1) + Environment.NewLine;

                ret += "V deň zadaného dátumu je " + (i + 1) + ". deň v týždni, čo je " + (i == 1 ? "pondelok." : (i == 2 ? "utorok." : (i == 3 ? "streda." : (i == 4 ? "štvrtok." : (i == 5 ? "piatok." : (i == 6 ? "sobota." : "nedeľa.")))))) + Environment.NewLine;
                DateTime yr = new DateTime(inDate.Year, 1, 1);
                TimeSpan denOfYr = inDate.Subtract(yr);
                int k = /*inDate.DayOfYear*/ (int)Math.Truncate(denOfYr.TotalDays) + 1;
                ret += "V deň zadaného dátumu" + (k == 1 ? " uplynul 1 deň" : k > 1 && k < 5 ? " uplynuli " + i + " dni" : " uplunulo " + k + " dní") + " od začiatku roka.";
                return ret + Environment.NewLine;
            }

            catch
            {
                return "Ďalej to už nepôjde, správny formát: yyyy-MM-dd" + Environment.NewLine;
            }
        }
    }
}
