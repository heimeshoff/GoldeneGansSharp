using System.Collections.Generic;

namespace GoldeneGans
{
    class Program
    {
        public IList<Item> Items;
        static void Main(string[] args)
        {
            System.Console.WriteLine("Willkommen in der Goldenen Gans!");

            var app = new Program()
            {
                Items = new List<Item>
                                          {
                                              new Item {Name = "+5 Geschicklichkeits Weste", VerkaufenIn = 10, Qualitaet = 20},
                                              new Item {Name = "Alter Gouda", VerkaufenIn = 2, Qualitaet = 0},
                                              new Item {Name = "Leckerer Lebertran", VerkaufenIn = 5, Qualitaet = 7},
                                              new Item {Name = "Fedoras", VerkaufenIn = 0, Qualitaet = 80},
                                              new Item
                                                  {
                                                      Name = "Backstage-Pässe für ein Delphi Perry Konzert",
                                                      VerkaufenIn = 15,
                                                      Qualitaet = 20
                                                  },
                                              new Item {Name = "Mana Kuchen", VerkaufenIn = 3, Qualitaet = 6}
                                          }

            };

            app.aktualisiere_qualitaet();

            System.Console.ReadKey();

        }

        public void aktualisiere_qualitaet()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Alter Gouda" && Items[i].Name != "Backstage-Pässe für ein Delphi Perry Konzert")
                {
                    if (Items[i].Qualitaet > 0)
                    {
                        if (Items[i].Name != "Fedoras")
                        {
                            Items[i].Qualitaet = Items[i].Qualitaet - 1;
                        }
                    }
                }
                else
                {
                    if (Items[i].Qualitaet < 50)
                    {
                        Items[i].Qualitaet = Items[i].Qualitaet + 1;

                        if (Items[i].Name == "Backstage-Pässe für ein Delphi Perry Konzert")
                        {
                            if (Items[i].VerkaufenIn < 11)
                            {
                                if (Items[i].Qualitaet < 50)
                                {
                                    Items[i].Qualitaet = Items[i].Qualitaet + 1;
                                }
                            }

                            if (Items[i].VerkaufenIn < 6)
                            {
                                if (Items[i].Qualitaet < 50)
                                {
                                    Items[i].Qualitaet = Items[i].Qualitaet + 1;
                                }
                            }
                        }
                    }
                }

                if (Items[i].Name != "Fedoras")
                {
                    Items[i].VerkaufenIn = Items[i].VerkaufenIn - 1;
                }

                if (Items[i].VerkaufenIn < 0)
                {
                    if (Items[i].Name != "Alter Gouda")
                    {
                        if (Items[i].Name != "Backstage-Pässe für ein Delphi Perry Konzert")
                        {
                            if (Items[i].Qualitaet > 0)
                            {
                                if (Items[i].Name != "Fedoras")
                                {
                                    Items[i].Qualitaet = Items[i].Qualitaet - 1;
                                }
                            }
                        }
                        else
                        {
                            Items[i].Qualitaet = Items[i].Qualitaet - Items[i].Qualitaet;
                        }
                    }
                    else
                    {
                        if (Items[i].Qualitaet < 50)
                        {
                            Items[i].Qualitaet = Items[i].Qualitaet + 1;
                        }
                    }
                }
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }

        public int VerkaufenIn { get; set; }

        public int Qualitaet { get; set; }
    }
}
