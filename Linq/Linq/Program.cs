using System;
using System.Collections.Generic;
using System.Linq;
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
            string str = "w3resource";
            var str1 = from x in str
                       group x by x into buchstabe
                       select buchstabe;
            foreach (var x in str1)
            {
                Console.WriteLine("Buchstabe " + x.Key + " anzahl " + x.Count());
            }
            Console.ReadKey();

        }
    }
}
