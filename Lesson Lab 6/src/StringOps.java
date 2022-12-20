/**
 * This class contains several ways to manipulate strings.
 *
 * @author Daniel Simard
 * @date November 20th, 2022
 */

import java.util.Arrays;
public class StringOps
{
    /**
     * Returns the number of words in the String.
     * @param str A series of words.
     * @return A count of the number of words in the String.
     */
    public static int wordCount(String str)
    {
        //Convert the String to a StringBuilder in order to remove punctuation and extra spaces.
        StringBuilder inputStr = new StringBuilder(str);

        //Remove the punctuation from the String.
        for (int i = 0; i < inputStr.length(); i++)
        {
            if (!(Character.isLetter(inputStr.charAt(i)) || Character.isSpaceChar(inputStr.charAt(i))))
            {
                inputStr.deleteCharAt(i);
                i--;
            }
        }

        //Remove extra spaces from the String
        boolean spaceChar = false;
        for (int i = 0; i < inputStr.length(); i++)
        {
            if (Character.isSpaceChar(inputStr.charAt(i)))
            {
                if (spaceChar)
                {
                    inputStr.deleteCharAt(i);
                    i--;
                }
                else spaceChar = true;
            }
            else spaceChar = false;
        }

        //Convert back to a String and tokenize into words, return the size of the tokenized array, which is the number of words.
        str = inputStr.toString();
        String[] tokens = str.split(" ");
        return tokens.length;
    }

    /**
     * Converts the passed charArray to a String.
     * @param charArray An array of characters to be converted to a String.
     * @return The parameter, converted to a String.
     */
    public static String arrayToString(char[] charArray)
    {
        //Create an empty StringBuilder for accumulating the characters of the charArray.
        StringBuilder newString = new StringBuilder();

        //Iterate through the charArray and append all characters to the StringBuilder.
        for (char c : charArray)
        {
            newString.append(c);
        }

        //Convert the StringBuilder to a String and return.
        return newString.toString();
    }

    /**
     * Return the alphabetic character that occurs most frequently in the String.
     * @param str A series of words.
     * @return - The alphabetic character that occurs most frequently in the parameter.
     */
    public static char mostFrequent(String str)
    {
        //Get a frequency array of all alphabetic characters in the String.
        int[] frequencyArray = frequency(str);

        //Two most-wanted holders to find the highest frequency.
        int indexLargest = 0;	//the index of the largest frequency.
        int largest = 0;		//the largest frequency.

        //Iterate through the frequency array and find the highest frequency and index of the highest frequency.
        for (int i = 0; i < frequencyArray.length; i++)
        {
            if (frequencyArray[i] > largest)
            {
                largest = frequencyArray[i];
                indexLargest = i;
            }
        }

        //Convert the index (a number from 0 to 25) to a character by adding 'a' and return.
        return (char)(indexLargest + (int)'a');
    }

    /**
     * Returns a 26-element integer array containing frequencies of the characters a/A through z/Z in
     * the parameter.
     * @param str A series of words.
     * @return A 26-element integer array of frequencies of alphabetic characters in the String.
     * 0th element is the frequency of a/A, 1st element frequency of b/B, etc.
     */
    public static int[] frequency(String str){
        //Create the frequency array and convert the String to a charArray for iterating over the characters.
        int[] frequencyArray = new int[26];
        char[] strArray=str.toCharArray();

        //Iterate over the charArray and increment frequencies of uppercase and lowercase characters.
        for (char c : strArray)
        {
            if (Character.isLowerCase(c))
                frequencyArray[c - 'a']++;  //lowercase - subtract 'a' to get index.
            if (Character.isUpperCase(c))
                frequencyArray[c - 'A']++;  //uppercase - subtract 'A' to get index.
        }

        //Return the frequency array.
        return frequencyArray;
    }

    /**
     * Replaces all occurrences of the second parameter with the third parameter within the String
     * passed as the first parameter.
     * @param str A series of words.
     * @param toReplace Substring to be replaced.
     * @param replace Substring to replace toReplace with.
     * @return The String with all occurrences of toReplace replaced with replace.
     */
    public static String replaceSubstring(String str, String toReplace, String replace)
    {
        //Put the first parameter into StringBuilder, so it can be changed.
        StringBuilder newString = new StringBuilder(str);

        //Iterate through the String as long as there are instances of toReplace and replace with replace.
        while (newString.indexOf(toReplace) != -1)
        {
            int begin = newString.indexOf(toReplace);
            int end = begin + toReplace.length();
            newString.replace(begin,end,replace);
        }

        //Convert the StringBuilder back to a String and return.
        return newString.toString();
    }

    private static final char[] messageArray = {'t','h','e',' ','c','a','t',' ','w','a','s',' ','c','u','t','e','.'};
    private static final String message = arrayToString(messageArray);
    private static final String stringA = "the";
    private static final String stringB = "my";

    public static void main(String[] args)
    {
        //Turns an array of characters into a string.
        System.out.println(arrayToString(messageArray));

        //Replace the beginning portion of the string.
        System.out.println(replaceSubstring(message, stringA, stringB));

        //Tallies up the total words in the message.
        System.out.println("Words: " + wordCount(message));

        //Prints out the most frequent character from the message.
        System.out.println("Most Frequent Character: " + mostFrequent(message));

        //Prints out the character frequency from A -> Z.
        System.out.println(Arrays.toString(frequency(message)));
    }
}