/**
 * Determines whether a string input is a palindrome.
 *
 * @author Daniel Simard
 * @date December 4th, 2022
 */
import java.util.Scanner;
public class PalindromeDetector
{
    public static void main(String[] args)
    {
        Scanner input = new Scanner(System.in);

        System.out.println("Please enter non-numeric and non-special characters only.");
        System.out.println("Please enter the string to test for palindromes: ");
        String inputString = input.nextLine();

        System.out.println("True if palindrome, else false:" + isPalindrome(inputString));
    }

    /**
     * Obtains the length of the string being tested.
     * @param inputString The string being tested.
     * @return The length of the string.
     */
    public static int getLength(String inputString)
    {
        return inputString.length();
    }

    /**
     * Fills the string with characters in reverse from the original inputString.
     * @param inputString The string being tested.
     * @param stringLength The length of the string.
     * @return The string in reversed order.
     */
    public static String reverseString(String inputString,int stringLength)
    {
        StringBuilder reversed = new StringBuilder();

        for(int i = stringLength - 1; i >= 0; i--)
        {
            reversed.append(inputString.charAt(i));
        }

        return reversed.toString();
    }

    /**
     * Determines whether a string input is a palindrome.
     * @param inputString The string being tested.
     * @return Whether the string is a palindrome.
     */
    public static boolean isPalindrome(String inputString)
    {
        if (reverseString(inputString, getLength(inputString)).equalsIgnoreCase(inputString))
        {
            return true;
        }
        else if (!reverseString(inputString, getLength(inputString)).equals(inputString))
        {
            return false;
        }

        return isPalindrome(inputString);
    }
}
