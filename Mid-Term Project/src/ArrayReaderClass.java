import java.io.File;
import java.io.FileNotFoundException;
import java.time.Instant;
import java.util.ArrayList;
import java.util.Collections;
import java.util.NoSuchElementException;
import java.util.Scanner;

public class ArrayReaderClass
{
    private static final ArrayList<LogEntry> entryLogs = new ArrayList<>();

    /**
     * This method reads a file adds its values to an ArrayList then sorts it.
     * @param fileName The file being added to the ArrayList.
     */
    private static void EntryReader(String fileName)
    {
        try
        {
            //Scans for the file to verify it exists.
            File myObj = new File(fileName);
            Scanner myReader = new Scanner(myObj);

            //While data remains in the file it continues to test the data and appends it to the ArrayList.
            while (myReader.hasNextLine())
            {
                String nextLine1 = myReader.nextLine();
                String nextLine2 = myReader.nextLine();
                String entry = "";

                //Checks if the data contains values needed for it to be a date.
                if (nextLine1.startsWith("2") && nextLine1.endsWith("Z")) {entry = nextLine1;}

                //Checks if the data contains values needed for it to be a date. If so, add it to the ArrayList.
                if (nextLine2.startsWith("2") && nextLine2.endsWith("Z")) {entryLogs.}

                //Otherwise, it appends the classification to the previous date.
                else
                {
                    //Enum method valueOf converts the string to your enumerated type if applicable.
                    switch (nextLine2)
                    {
                        case "ALPHA": entry += ErrorClass.valueOf("ALPHA");
                            break;
                        case "BETA":  entry += ErrorClass.valueOf("BETA");
                            break;
                        case "DELTA": entry += ErrorClass.valueOf("DELTA");
                            break;
                        case "GAMMA": entry += ErrorClass.valueOf("GAMMA");
                            break;
                        default:      entry += nextLine2;
                            break;
                    }
                }
                //Adds the data to the ArrayList.
                entryLogs.add(entry);
            }
            //Closes the file and continues the operation.
            myReader.close();
        }
        catch (FileNotFoundException error)
        {
            System.out.println("File not found, please continue testing the program.");
        }
        catch (NoSuchElementException error)
        {
            System.out.println("There was an issue with the file attempting to be loaded.");
        }

        //Sorts the Arraylist from the earliest to most recent date.
        Collections.sort(entryLogs);
    }

    /**
     * Recursively searches for a specified date.
     * @param arrayList The arrayList being passed in.
     * @param date The date being searched for.
     * @return The data associated with the date.
     */
    static LogEntry BinarySearch(ArrayList<LogEntry> arrayList, String date) {
        //Assume ArrayList is a sorted list of entryObject that contain a name and date.
        if (arrayList.size() == 0) {return null;}

        if (arrayList.size() == 1)
        {
            if (arrayList.get(0).time.equals(date))
            {
                return arrayList.get(0);
            }
            else return null;
        }

        int mid = arrayList.size() / 2;

        LogEntry midVal = arrayList.get(mid);

        if (midVal.time.equals(date)) {return midVal;}

        //If none of the previous apply. Then we need figure out what half of the array to work with.
        if (midVal.time.compareTo(Instant.parse(date)) > 0) {return BinarySearch((ArrayList<LogEntry>) arrayList.subList(0, mid), date);}

        else {return BinarySearch((ArrayList<LogEntry>) arrayList.subList(mid + 1, arrayList.size()), date);}
    }

    public static void main(String[] args)
    {
        String continueOperator = "";
        Scanner inputTxt = new Scanner(System.in);

        while (!continueOperator.equals("n"))
        {
            System.out.print("Please enter the name of a following file ErrorLogs, LogEntries, or VisitorEntries: ");
            EntryReader((inputTxt.nextLine() + ".txt"));

            System.out.print("Would you like to add another file(Y/N)?: ");
            continueOperator = inputTxt.nextLine().toLowerCase();
        }

        System.out.print("Please enter the date you are searching for: ");
        String date = inputTxt.nextLine();
        System.out.println("Your result is: " + BinarySearch(entryLogs, date));

        System.out.println(entryLogs);
    }
}
