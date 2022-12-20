public class RecursionLabFunctions
{
    /**
     * Recursive method to display each individual character in a String
     * @param theString -- the String to be displayed
     */
    public static void displayChars(String theString)
    {

        if (theString.length() == 1)
            System.out.println(theString);
        else
        {
            System.out.println(theString.charAt(0));
            displayChars(theString.substring(1,theString.length()));
        }
    }

    /**
     * Recursive method to display each individual character in a string in reverse order
     * @param theString -- the String to be displayed
     */
    public static void displayBackwardChars(String theString)
    {
        if (theString.length()==1)
            System.out.println(theString);
        else
        {
            System.out.println(theString.charAt(theString.length()-1));
            displayBackwardChars(theString.substring(0,theString.length()-1));
        }
    }

    /**
     * Iterative method to compute a factorial
     * @param num -- compute the factorial of num
     * @return -- the factorial of num
     */

    public static int factiter(int num)
    {
        int factorial=1;
        int i;
        for (i=2; i<=num; i++)
            factorial*=i;
        return factorial;
    }

    //Here's the recursive factorial we're to convert:
    private static int factorial(int n)
    {
        if (n == 0)
            return 1;   // Base case
        else
            return n * factorial(n - 1);
    }

    public static int maxElement(int[] array, int start)
    {
        int result;
        if (start==array.length-1)
            return array[start];
        else
        {
            result=maxElement(array,start+1);
            if (array[start]>result)
                return array[start];
            else
                return result;
        }
    }

    public static void main(String[] args)
    {

        //**Demo displayChars:
        String theString="Mimsy were the borogoves";
        System.out.println("Display a string, one char at a time: ");
        //displayChars(theString);

        //**Demo displayBackwardChars:
        System.out.println("Display the same string backward, one char at a time: ");
        //displayBackwardChars(theString);

        //***Demo factorial:
		/*
		System.out.println("The factorial of 8, computed recursively, is "+factorial(8));
		System.out.println("The factorial of 8, computed iteratively, is "+factiter(8));
		System.out.println("The factorial of 1, computed recursively, is "+factorial(1));
		System.out.println("The factorial of 1, computed iteratively, is "+factiter(1));
		System.out.println("The factorial of 0, computed recursively, is "+factorial(0));
		System.out.println("The factorial of 0, computed iteratively, is "+factiter(0));
		System.out.println();
		*/

        long tStart = System.currentTimeMillis();
        factorial(100);
        long tEnd = System.currentTimeMillis();
        long tDelta = tEnd - tStart;
        System.out.println(tStart + " " + tEnd + " " + tDelta);
        double elapsedSeconds = tDelta / 1000.0;
        System.out.println("Elapsed millis: " + tDelta + " Elapsed seconds: " + elapsedSeconds);

        //***Demo maxElement:
        // Create an array to test the method.
        int[] numbers = {5000, 2, 12, 1999, 99, 100, 4, 7, 300,3000 };

        // Display the largest value in the array.
        System.out.println("The largest value in the array is " +
                maxElement(numbers, 0));

    }

}