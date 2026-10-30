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
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Step1: Create a double array with length slots
        //Step2: start the loop with index at 0; loop while index is less than the length and add 1 to index for each loop while true
        //Step3: On each loop, we multiply number by index + 1 and store it in the slot at the current index
        //Step4: Then we return the array
        double[] results = new double[length];
        for (int i = 0; i < length; i++)
        {
            results[i] = number * (i + 1);
        }

        return results; // replace this return statement with your own
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
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Step1:Make a for loop that will repeat the amount times. Start by making index 0; loop while index is less than amount; then adding 1 to the index after each loop
        //Step2:Create a variable where we will store the last item of the list which will be data[data.Count - 1]
        //Step3:Remove the last item from the list
        //Step4:Insert the item at the first index

        for (int i = 0; i < amount; i++)
        {
            int last = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            data.Insert(0, last);
        }
    }
}
