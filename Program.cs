using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace fruit
{
    internal class Program
    {
        class fruit 
        {
            public string name { get; set; }
            public int weight { get; set; }
            public int price { get; set; }
           
            public fruit()
            {
                this.name = null;
                this.weight = 0;
                this.price = 0;
            }
            public fruit(string name, int weight, int price)
            {
                this.name = name;
                this.weight = weight;
                this.price = price;
            }
            public double buying()
            {
                return(this.price = this.price * this.weight);
            }
        }
        class shop 
        {
            private List<fruit> fruitList;

            public void addfruit(fruit addfruit)
            {
                fruitList.Add(addfruit);
                Console.WriteLine($"{addfruit.name} added to your fruits "); 
            }
            public void removefrriut(fruit removefruit)
            {
                fruitList.Remove(removefruit);
                Console.WriteLine($"{removefruit.name} removed from your fruits ");
            }
            public void menu()
            {
                foreach (fruit menu in fruitList)
                {
                    Console.WriteLine(menu.name, menu.weight, menu.price);
                }
            }

        }
        class user
        { 

            private string name;
            Dictionary<string, double> weight;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("welcom .");
            Console.WriteLine("if you enter number 1 your user , if enter number 2 you are seller");
               int number =Convert.ToInt32(Console.ReadLine());
            if(number == 2)
            {
                Console.WriteLine("enter number 1 to add fruit / enter number 2 to remove fruit / enter number 3 to know weight of fruit");
                int number2=Convert.ToInt32(Console.ReadLine());
            if( number2 == 1)
            {
                Console.WriteLine("name of fruit you want to add : ");
                string nameadd=Console.ReadLine();
                Console.WriteLine("weight of friut you want :");
                int weghtadd = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("price of the fruit");
                    int priceadd = Convert.ToInt32(Console.ReadLine());
                    fruit fruitadd = new fruit(nameadd , weightadd , priceadd);
                    shop shop = new shop();
                    shop.addfruit(fruitadd);

            }
            else if(number2 == 2)
                {
                    Console.WriteLine("name of fruit you want to remove");
                    string nameremove = Console.ReadLine();
                    Console.WriteLine("weight of fruit you want to remove")
                        int weightremove = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("price remove from your friuts");
                    int priceremove = Convert.ToInt32(Console.ReadLine());
                    fruit fruitremove = new fruit(nameremove , weightremove , priceremove);
                    shop shops = new shop();
                    shops.addfruit(fruitremove);
                    
                       
                }
            if (number2 == 3)
                {
                    shop usermenu = new shop();
                    usermenu.menu();
                    Console.WriteLine("fisrt enter your fruit name");
                        string namebuy=Console.ReadLine();
                    Console.WriteLine("now enter weight of fruit");
                    int weightbuy = Convert.ToInt32(Console.ReadLine());
                    fruit buying = new fruit(namebuy, weightbuy);



                }
        }
    }
}
