using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arbeitsblatt Aufgaben zu Linq Nr. 1 Gebe aus seiner Liste von Zahlen nur die Zahlen aus, welche durch 2 Teilbar sind
            //List<int> liste = new List<int>() { 1, 4, 5, 8, 9, 12 };
            //var neueListe = from gerade in liste
            //                where gerade % 2 == 0
            //                select gerade;
            //foreach (var gerade in neueListe)
            //{
            //    Console.WriteLine(gerade);
            //}
            //Console.ReadKey();

            //Arbeitsblatt Aufgaben zu Linq Nr. 2 Gebe aus einer Liste von Zahlen nur die ungeraden Werte aus
            //List<int> liste = new List<int>() { 1, 4, 5, 8, 9, 12 };
            //var neueliste = from ungerade in liste
            //                where ungerade % 2 == 1
            //                select ungerade;
            //foreach (var ungerade in neueliste)
            //{
            //    Console.WriteLine(ungerade);
            //}
            //Console.ReadKey();

            //Arbeitsblatt Aufgaben zu Linq Nr. 3 Gebe für die angegebenen Zahlen , die Zahl sowie die Quadratzahl aus, wobei die Quadratzahl größer als 20 sein soll var arr1 = new[] { 3, 9, 2, 8, 6, 5 };
            //var arr1 = new[] { 3, 9, 2, 8, 6, 5 };
            //foreach (var nummer in arr1)
            //{
            //    Console.WriteLine(nummer);
            //}
            //var newarr1 = from zahl in arr1
            //              where zahl*zahl >= 20
            //              select zahl;
            //foreach (var zahl in newarr1)
            //{
            //    Console.WriteLine(zahl*zahl);
            //}
            //Console.ReadKey();

            //Arbeitsblatt Aufgaben zu Linq Nr. 4 Gehe eine Liste von zahlen durch, und gebe die Zahl sowie die Häufigkeit, wie oft diese in der Liste auftritt int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            //int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            //var arr2 = from zahl in arr1
            //           group zahl by zahl into anzahl
            //           select anzahl;
            //foreach (var arrNo in arr2)
            //{
            //    Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count() + " times");
            //}
            //Console.ReadKey();


            //Arbeitsblatt Aufgaben zu Linq Nr. 5 Gebe die Häufigkeit jeden Buchstabens des angegebenen Strings aus. Lasse den Nutzer ein eigenes Wort eingeben. string str = „w3resource“;
            //string str = "w3resource";
            //var str1 = from x in str
            //           group x by x into buchstabe
            //           select buchstabe;
            //foreach (var x in str1)
            //{
            //    Console.WriteLine("Buchstabe " + x.Key + " anzahl " + x.Count());
            //}
            //Console.ReadKey();

            //Arbeitsblatt Aufgaben zu Linq Nr. 6 Gebe die Zahl, das Auftreten der Zahl im Array, sowie die Multiplikation der Zahl mit der Zahl ihres Auftretens int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            //int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            //var zahlen = from x in nums
            //             group x by x into y
            //             select y;
            //foreach (var z in zahlen)
            //{
            //    Console.WriteLine("zahl " + z.Key + " Summe " + z.Sum() + " auftreten " + z.Count());
            //}
            //Console.ReadKey();

            //Arbeitsblatt Aufgaben zu Linq Nr. 7 Gebe die Städte aus, welche mit einem bestimmten Buchstaben beginnen, sowie mit einem weiteren Buchstaben Enden. Gestalte es variabel.string[] cities = "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"};
            //string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            //string chst, chen;

            //Console.WriteLine("Nach welchem Buchstaben soll ich vorne filtern");
            //chst = Console.ReadLine();
            //chst = chst.ToUpper();
            //Console.WriteLine("Nach welchem Buchstaben soll ich hinten filtern");
            //chen = Console.ReadLine();
            //chen = chen.ToUpper();
            //var _result = from x in cities
            //              where x.StartsWith(chst)
            //              where x.EndsWith(chen)
            //              select x;
            //foreach (var city in _result)
            //{
            //    Console.WriteLine("The City starting with {0} and ending with {1} is : {2} ", chst, chen, city);
            //}
            //Console.ReadLine();

            //Arbeitsblatt Aufgaben zu Linq Nr. 8Lasse den Nutzer eine Zahl eingeben, wie viele Einträge er hinzufügen möchte. Frage anschließend nach den jeweiligen Werten, bis die Anzahl der Listelemente erreicht ist. Frage Anschließend nach einer Zahl und gebe nur die Elemente der Liste aus, welche größer als die Eingabe ist.
            

            int i = 0;
            int menlist, anzahl, maximalzahl;
            List<int> templist = new List<int>();
            Console.WriteLine("Bitte gib mir eine zahl, wie viele Einträge du haben möchtest");
            anzahl = int.Parse(Console.ReadLine());
            for (i = 0; i < anzahl; i++)
            {
                Console.WriteLine("Member {0} ",i);                
                templist.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Ab welcher Zahl sollen die Einträge wieder ausgegeben werden?");
            maximalzahl = int.Parse(Console.ReadLine());
            List<int> FilterList = templist.FindAll(x=>x>=maximalzahl? true: false);
            Console.WriteLine("Die zahlen sind:");
            foreach (var num in FilterList)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();

        }
    }
}
