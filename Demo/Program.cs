using System.ComponentModel;

namespace Demo
{
    internal class Program
    {
        //static int SumArrayPassingByValue( int[] arr)
        //{
        //    int sum = 0;
        //    arr = new int[] { 3, 4, 5 };
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}
        //static int SumArrayPassingPassingByRef(ref int[] arr) {
        //    int sum = 0;
        //    arr = new int[] { 3, 4, 5 };
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}

        //static void GetSumAndGetSub(int fNumber, int sNumber, out int sumResult, out int subResult ) {

        //    sumResult = fNumber + sNumber;
        //    subResult = fNumber - sNumber;
        //}


        //static void MinMaxArray(ref int[] arr ,ref int maxResult,ref int minResult ) {

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] > maxResult)
        //            maxResult = arr[i];
        //        if (arr[i] < minResult)
        //            minResult = arr[i];
                
        //    }

        
        static void Main(string[] args)
        {

            #region Q1) Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            ///* Passing by Value:
            //    When passing a reference type by value the address of the object is copied to the parameter.
            //    Inside the function the parameter points to the same object in memory as the original reference. 
            //    Modifications to the object's contents will affect the original object. However if the parameter is assigned a new object, 
            //    this change does not affect the original reference outside the function because the function has its own variable

            //   Passing by Reference:
            //    When passing a reference type by reference using the ref,
            //    the actual reference (memory location) is passed. This means that changes to the parameter itself, 
            //    such as assigning a new object, will affect the original reference outside the function.*/
            //int[]arr = { 1, 2, 3 };
            //Console.WriteLine(arr[0]); //1
            //SumArrayPassingByValue(arr);
            //Console.WriteLine(arr[0]); //1    called function has its own reference that point to the new array object
            //SumArrayPassingPassingByRef(ref arr);
            //Console.WriteLine(arr[0]); //3     called function and main function has one memory variable location that point to the array object in heap

            #endregion

            #region Q2)Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //int fNumber=0,  sNumber=0;
            //bool isParsed = false;
            //int sumResult, subResult;

            //while (!isParsed)
            //{
            //    Console.Write("Enter First Number please : ");
            //    isParsed = int.TryParse(Console.ReadLine(), out fNumber);

            //}
            //isParsed = false;
            //while (!isParsed)
            //{
            //    Console.Write("Enter Second Number please : ");
            //    isParsed = int.TryParse(Console.ReadLine(), out sNumber);

            //}

            //GetSumAndGetSub(fNumber,sNumber,out sumResult,out subResult);
            //Console.WriteLine(sumResult);
            //Console.WriteLine(subResult);
            //// we use out parameter to return more than single value
            #endregion

            #region Q3)Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters


            //int[] arr = {8, 2, 3, 4, -4, 6, 7, 1 };
            //int maxResult = arr[0],minResult = arr[0];
            //MinMaxArray(ref arr,ref maxResult,ref minResult);
            //Console.WriteLine($"Min Number is : {minResult}, Max Number is {maxResult}");
            #endregion
        }
    }
}
