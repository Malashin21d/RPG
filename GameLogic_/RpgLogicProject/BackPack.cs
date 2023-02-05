using System;
namespace RpgLogicProject
{

    //Рюкзак
    public class BackPack
    {
        private readonly Item[] items;
        public int maxWeight { get; set; }


        public BackPack(int Freespace)
        {
            items = new Item[Freespace];
            maxWeight = Freespace + 10;
            for (int i = 0; i < Freespace; i++)
            {
                var Item = new Item("Gecnj", 0);
                items[i] = Item;
            }
        }


        public int count = 0;
        public void Add(Item item)
        {
            int a = GetWeigth();
            int b = GetSpace();
            Console.WriteLine($"Общий вес = {a}, Cвободное место - {b}");
            if (a < maxWeight && b > 0 && count < items.Length)
            {
                items[count] = item;
                count++;
                Console.WriteLine("Предмет теперь у вас в рюкзаке.");
            }
            else
            {
                Console.WriteLine("Перегруз");
            }
        }

        public int GetWeigth()
        {
            int result = 0;
            for (int i = 0; i < items.Length; i++)
            {
                result += items[i].Weigth;
            }
            return result;
        }
        public int GetSpace()
        {
            int Freespace = items.Length;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Weigth != 0)
                {
                    Freespace--;
                }
                else
                {
                    continue;
                }

            }
            return Freespace;
        }
    }
}