using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Simul
{
    class Program
    {
        public static string PATH = Application.StartupPath + "/data.json";
        public static Dictionary<string, Dictionary<string, string>> uzivatelia = new Dictionary<string, Dictionary<string, string>>();
        public static Dictionary<string, string> aktivnyU = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            if (!File.Exists(PATH))
            {
                uzivatelia.Add("admin", new Dictionary<string, string> {
                    { "Meno", "Janko" },
                    { "Heslo", "adminhaha"},
                    { "Priezvisko", "Hruštička"},
                    { "Typ", "admin"}
                });
                string output = JsonConvert.SerializeObject(uzivatelia);
                File.WriteAllText(PATH, output);
                Console.WriteLine("Základný súbor s dátami vytvorený!");
            }

            else
            {
                uzivatelia = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(File.ReadAllText(Application.StartupPath + "/data.json"));
            }

            for (; ; )
            {
                Console.Write("Program chce vedieť vaše prihlasovacie meno a heslo (oddelené medzerou): ");
                string[] menoHeslo = null;

                foreach (var i in new int[] { 2, 1, 0 })
                {
                    menoHeslo = readLine().Split();
                    menoHeslo[0] = menoHeslo[0].ToLower();

                    if (uzivatelia.ContainsKey(menoHeslo[0]) && uzivatelia[menoHeslo[0]]["Heslo"] == menoHeslo[1])
                    {
                        aktivnyU = uzivatelia[menoHeslo[0]];
                        goto Success;
                    }

                    else
                    {
                        Console.Write("Program nevie rozoznať túto dvojcu údajov, skúste to znova (zostávajúce pokusy -> " + i + "): ");
                    }
                }

                Environment.Exit(0);
                Success:
                switch (aktivnyU["Typ"])
                {
                    case "guest":
                        for (; ; )
                        {
                            if (readLine() == "logout")
                                break;
                        }

                        break;

                    case "user":
                        Console.WriteLine();
                        Console.WriteLine("Ahoj " + aktivnyU["Meno"] + " " + aktivnyU["Priezvisko"] + "!");
                        Console.WriteLine("Ako plnohodnotný užívateľ tohto programu máte na výber dve možnosti:");
                        Console.WriteLine("logout - odhlásenie");
                        Console.WriteLine("password <nové heslo> - zmení heslo");

                        for (; ; )
                        {
                            Console.WriteLine();
                            string input = readLine();

                            if (input == "logout")
                            {
                                break;
                            }

                            else if (input.StartsWith("password ") && input.Split().Length == 2)
                            {
                                aktivnyU["Heslo"] = input.Split()[1];
                                Console.WriteLine("Heslo úspešne zmenené!");
                            }
                        }

                        break;
                    case "admin":
                        Console.WriteLine();
                        Console.WriteLine("Ahoj Admin! Komu sa dnes nabúrame do účtu?");
                        Console.WriteLine("Ako samozvolený vodca tohto programu máš k dispozícii tieto možnosti:");
                        Console.WriteLine("logout - odhlásenie");
                        Console.WriteLine("password <nové heslo> - zmení heslo");
                        Console.WriteLine("adduser <login> - pridá nového užívateľa");
                        Console.WriteLine("deluser <login> - vymaže užívateľa");
                        Console.WriteLine("password <login> <nové heslo> - zmení heslo užívateľa");

                        for (; ; )
                        {
                            Console.WriteLine();
                            string[] detaily = readLine().Split();

                            switch (detaily[0])
                            {
                                case "logout":
                                    goto BreakLabel;

                                case "password":
                                    if (detaily.Length == 3)
                                    {
                                        if (uzivatelia.ContainsKey(detaily[1]))
                                        {
                                            uzivatelia[detaily[1]]["Heslo"] = detaily[2];
                                        }

                                        else
                                        {
                                            Console.WriteLine("Užívateľ " + detaily[1] + " neexistuje!");
                                        }
                                    }

                                    else if (detaily.Length == 2)
                                    {
                                        aktivnyU["Heslo"] = detaily[1];
                                        Console.WriteLine("Heslo úspešne zmenené!");
                                    }
                                    break;

                                case "deluser":
                                    if (uzivatelia.ContainsKey(detaily[1]))
                                    {
                                        if (detaily[1] == menoHeslo[0])
                                        {
                                            Console.WriteLine("Nemožeš vymazať samého seba!");
                                            break;
                                        }

                                        Console.Write("Naozaj chceš odstrániť užívateľa " + detaily[1] + ", menom " + uzivatelia[detaily[1]]["Meno"] + " " + uzivatelia[detaily[1]]["Priezvisko"] + "? (Y/N): ");

                                        switch (Console.ReadLine().ToLower())
                                        {
                                            case "y":
                                                uzivatelia.Remove(detaily[1]);
                                                Console.WriteLine("Užívateľ bol odstránený!");
                                                break;
                                            case "n":
                                                Console.WriteLine("Potom nerozumiem, prečo si to vôbec písal");
                                                break;
                                        }
                                    }

                                    else
                                    {
                                        Console.WriteLine("Takýto užívateľ neexistuje!");
                                    }

                                    break;

                                case "adduser":
                                    if (uzivatelia.ContainsKey(detaily[1]))
                                    {
                                        Console.WriteLine("Užívateľ s týmto loginom už existuje!");
                                        break;
                                    }

                                    Console.WriteLine("Chystáš sa pridať užívateľa " + detaily[1] + ".");
                                    Console.WriteLine("Prosím, zapíš jeho zvyšné údaje nižšie v poradí: Meno Priezvisko Heslo Typ('guest'/'user'/'admin')");
                                    string[] novyU = readLine().Split();

                                    if (!new List<string> { "guest", "user", "admin"}.Contains(novyU[3]))
                                    {
                                        Console.WriteLine("Neznámy typ užívateľa, dovolím si ho nastaviť na 'guest'");
                                        novyU[3] = "guest";
                                    }

                                    Dictionary<string, string> novyUDict = new Dictionary<string, string> {
                                        { "Meno", novyU[0] },
                                        { "Heslo", novyU[2] },
                                        { "Priezvisko", novyU[1] },
                                        { "Typ", novyU[3] }
                                    };

                                    uzivatelia.Add(detaily[1].ToLower(), novyUDict);
                                    Console.WriteLine("Užívateľ bol úspešne pridaný!");
                                    break;
                            }

                            continue;
                            BreakLabel:
                            break;
                        }

                        break;
                }
            }
        }

        public static string readLine()
        {
            string ret = Console.ReadLine();

            if (ret == "stop")
            {
                string output = JsonConvert.SerializeObject(uzivatelia);
                File.WriteAllText(PATH, output);
                Environment.Exit(0);
                return null;
            }

            else return ret;
        }
    }
}
