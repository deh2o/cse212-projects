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

        // STEPS
        // 1. Understand the problem.
        //  We need to create an array containing a specified number
        //  of multiples of the given number.
        // 2. Create an array of doubles with the specified length.
        // 3. Use a for loop to iterate through the array and assign each element to be the multiple of 'number' based on its index.
        // 4. For each position, calculate the multiple by
        //    multiplying the given number by the index plus 1.
        //    This ensures that the first multiple is the original number.
        // 5. Store each calculated multiple in the array.
        // 6. Return the completed array.

        double[] multiples = new double[length];      //an array containing the number of multiples "length"

        // Loop
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
    }
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    /// 
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        /// STEPS
        /// 1. Understand the problem.
        ///    We need to rotate the elements in the list to the right
        ///    by the specified amount.
        /// 2. Determine the starting position of the elements
        ///    that will move to the beginning of the list. This position is data.Count - amount.
        /// 3. Use GetRange() to create a temporary list containing the last 'amount' elements.
        /// 4. Remove those elements from the original list
        /// using RemoveRange().
        /// 5. Insert the temporary list at the beginning
        /// of the original list using InsertRange().
        /// 6. The original list has now been rotated
        /// to the right by the specified amount.

        int startIndex = data.Count - amount;

        List<int> lastElements = data.GetRange(startIndex, amount);

        data.RemoveRange(startIndex, amount);

        data.InsertRange(0, lastElements);
    }
}
