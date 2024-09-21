using System.Diagnostics;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // return an array of multiples of a number
        //starting number and number of multiples are provided as inputs (int)
        //ex. MultiplesOf (3,5) should return an array starting at 3 and multiplying by 3 five times {3, 6, 9, 12, 15}

        //first make an array to contain the numbers, since its a fixed array, set number to the length:

        var numberArray = new double [length];

        //second have a for loop to iterate over the length and return the multiples within the array:
        double numberTest = 0;

        for (int i = 0; i < length; i++)
        {
            numberTest += number;
            Debug.WriteLine(numberTest);
            numberArray[i] = numberTest;
        }

        return numberArray; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // user will input a number, that number will look at the list.  The list should start at the end of the list, subtract the
        //inputed number take that value and put all the numbers after that value to the start of the list
        //ex. {1, 2, 3, 4, 5, 6, 7, 8, 9} user picks 3 and the new list will be {7, 8, 9, 1, 2, 3, 4, 5, 6}
        
        //create a new list to capture the values that will be removed (then re-inserted to new array)
        var dataList = new List<int>();
        var lastNumbers = new List <int>();
        

        //remove the set number of values from the list and save it to temp list lastNumbers
        //trying to understand what this does, from what I can tell this is getting the first numbers within the range, 
        //then subtracting those numbers to leave the leftovers, which is what we want to use.
        lastNumbers = data.GetRange(data.Count - amount, amount);

        //add the last numbers to new array:
        dataList.AddRange(lastNumbers);

        //add the remaining numbers from the origional data array:

        lastNumbers = data.GetRange(0, data.Count - amount);

        dataList.AddRange(lastNumbers);

        data.RemoveRange(0, data.Count);

        data.InsertRange(0, dataList);

        //since function is static, no need to return a value.
        
    }

}
