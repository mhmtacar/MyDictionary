// See https://aka.ms/new-console-template for more information
using MyDictionary;

MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();

myDictionary.Add(1, "Mehmet");
myDictionary.Add(2, "Ali");

int[] keys = myDictionary.Keys;
string[] values = myDictionary.Values;

for (int i = 0; i < keys.Length; i++)
{
    Console.WriteLine("Key: {0} Value: {1}", keys[i], values[i]);
}
