public class ArrayComparison
{
    /**
     * Takes two parallel arrays as input. Then identifies how many mismatches there are.
     * @param arrayA The first array.
     * @param arrayB The second array.
     * @param index The point where we are checking the array for differences.
     * @return The number of mismatches.
     */
    public static int NumberOfMismatches(String[] arrayA, String[] arrayB, int index)
    {
        var result = 0;

        //Makes sure we do not go out of bounds.
        if(index < arrayA.length)
        {
            //If the arrays aren't equal we add 1 to the mismatch counter.
            if(!arrayA[index].equals(arrayB[index]))
                result++;

            //Recursively goes through the method until all indexes are compared.
            result += NumberOfMismatches(arrayA, arrayB, index + 1);
        }

        return result;
    }
}
