using CsharpOOP_Course.Advanced;
using CsharpOOP_Course.Fundamentals;
using CsharpOOP_Course.OOP;
using System;

namespace CsharpOOP_Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fundamentals - 1 

            //Tip : ConvertToInt32 actually rounds the number. Type casting just floors
            //DataTypes.DifferenceInIntConversion();

            //Fundamentals - 2

            //DataTypes.MaxDataTypesNumbers();
            //DataTypes.CheckPrecision();

            //Datetimes.DatetimesInGeneral();
            //Datetimes.FormatString();

            //Console.WriteLine("Give a number");
            //Exercises.EvenOrOdd(int.Parse(Console.ReadLine()));

            //Exercises.FriendlyConversation();

            //Exercises.FindTheDay();

            //Fundamentals - 3

            //Strings.StringManipulation();
            //Strings.AdvancedStringManipulation();

            //Exercises.ShowEvenNumbers();
            //Exercises.ShowTriangleShapeWithZeros();  
            //Exercises.ShowUpsideTriangle();
            //Exercises.RollDiceGame();

            //OOP - 1
            //MethodOverloading.Add(1, 3);
            //MethodOverloading.Add(1, 3, 5);
            //MethodOverloading.Add(1.3, 3, 5.5);
            //MethodOverloading.Add(1.5, 3.3);

            //Exercises_OOP.InheritanceExample();
            //Exercises_OOP.PolymorphismExample();
            //Exercises_OOP.OOP_Big_Example();
            //Exercises_OOP.ExceptionHandling();

            //Advanced 1
            //Exercises_Advanced.FileCreationExercise();

            //Cryptography.TestCrypto();

            //Advanced 2 
            //ArrayListNonGeneric.PlayingWithArrayLists();
            //HashTablesNonGeneric.PlayingWithHashTables();
            //SortedListNonGeneric.PlayingWithSortedLists();
            //StackNonGeneric.PlayingWithStacks();
            //QueueNonGeneric.PlayingWithQueues();
            //BitArrayNonGeneric.PlayingWithBitArrays();

            //Exercises_Advanced.NonGenericCollectionExercise();

            //ListGeneric.PlayingWithLists();
            //DictionaryGeneric.PlayingWithDictionaries();
            //SortedListGeneric.PlayingWithSortedLists();
            //KeyValuePairsGeneric.PlayingWithKeyValuePairs();
            //NameValueCollections.PlayingWithNameValueCollections();

            //Exercises_Advanced.GenericClassesExercise();

            //Tuples.PlayingWithTuples();
            Tuples.PlayingWithNestedTuples();

            Console.ReadLine();
        }
    }
}
