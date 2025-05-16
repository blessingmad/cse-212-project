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
        // TODO Problem 1 Start
        
        //create a new array of size '7, 5' to hold the results
        double[] result = new double[length];

        // loop from  0 to length - 1
        for (int i = 0; i < length; i++)
        {
            // after loop, return the populated array 
            result[i] = number * (i + 1);
        }
        

        return result; // replace this return statement with your own
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
        // calculate the number of elements to rotate
        int splitIndex = data.Count - amount;
        //GGet the two parts using the split index
        List<int> firstPart = data.GetRange(0, splitIndex);
        List<int> secondPart = data.GetRange(splitIndex, amount);

        // clear the original list
        data.Clear();
        // add the second part first
        data.AddRange(secondPart);
        // add the first part
        data.AddRange(firstPart);
        // return the modified list
        // no return needed as the list is modified in place


    }
}
