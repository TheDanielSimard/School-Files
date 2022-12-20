/**
 * This class converts a string of characters into morse code.
 *
 * @author Daniel Simard
 * @date November 20th, 2022
 */

import java.util.Scanner;
public class MorseCodeConverter
{
    public static void main(String[] args)
    {
        char[] characters = {   'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
                                'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
                                'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
                                ',', '.', '?'};

        String[] morseCode = {  ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..",
                                ".---", "-.-", ".-..", "--", "-.", "---", ".---.", "--.-", ".-.",
                                "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", ".----",
                                "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.",
                                "-----", "--..--", ".-.-.-", "..--.."};

        Scanner input = new Scanner(System.in);

        //Converting characters to lowercase for easier translation.
        System.out.print("Please enter what you want converted to morse code: ");
        String stringInput = input.nextLine().toLowerCase();

        //Converts the string to a character array.
        char[] charactersInput = stringInput.toCharArray();
        StringBuilder output = new StringBuilder();

        //Converting characters to morse code.
        for (char c : charactersInput)
        {
            for (int j = 0; j < characters.length; j++)
            {
                if (characters[j] == c)
                {
                    output.append(morseCode[j]).append(" ");
                }
            }
        }

        System.out.println(output);
    }
}

