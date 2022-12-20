/**
 * This class reads from the text files and use the data to instantiate objects, add to an arraylist, sort it, and search.
 * @author Daniel Simard
 * @date December 18th, 2022
 */
import java.io.File;
import java.io.FileNotFoundException;
import java.time.Instant;
import java.util.ArrayList;
import java.util.NoSuchElementException;
import java.util.Objects;
import java.util.Scanner;

public class EntryReader
{
    private static final ArrayList<LogEntry> logs = new ArrayList<>();

    /**
     * This method reads a file onto an arrayList.
     * @param fileName The file being read.
     */
    private static void readLogEntryFile(String fileName)
    {
        try
        {
            File myObj = new File(fileName);
            Scanner myReader = new Scanner(myObj);

            //While data remains in the file it continues to test the data and appends it to the ArrayList.
            while (myReader.hasNextLine())
            {
                var time = Instant.parse(myReader.nextLine());

                var entry = new LogEntry(time);

                logs.add(entry);
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
    }

    /**
     * This method reads a file onto an arrayList.
     * @param fileName The file being read.
     */
    private static void readVisitorEntryFile(String fileName) {
        try {
            File myObj = new File(fileName);
            Scanner myReader = new Scanner(myObj);

            //While data remains in the file it continues to test the data and adds it to the ArrayList.
            while (myReader.hasNextLine()) {
                //Assumes that the file has an even number of lines.
                //Doesn't handle empty lines.
                var time = Instant.parse(myReader.nextLine());
                var name = myReader.nextLine();

                var entry = new VisitorEntry(time, name);

                logs.add(entry);
            }
            //Closes the file and continues the operation.
            myReader.close();
        }
        catch (FileNotFoundException error) {
            System.out.println("File not found, please continue testing the program.");
        }
        catch (NoSuchElementException error) {
            System.out.println("There was an issue with the file attempting to be loaded.");
        }
    }

    /**
     * This method reads a file onto an arrayList.
     * @param fileName The file being read.
     */
    private static void readErrorEntryFile(String fileName) {
        try {
            File myObj = new File(fileName);
            Scanner myReader = new Scanner(myObj);

            //While data remains in the file it continues to test the data and appends it to the ArrayList.
            while (myReader.hasNextLine()) {
                //Assumes that the file has an even number of lines.
                //Doesn't handle empty lines.
                var time = Instant.parse(myReader.nextLine());
                var classification = ErrorClass.valueOf(myReader.nextLine());

                var entry = new ErrorEntry(time, classification);

                logs.add(entry);
            }
            //Closes the file and continues the operation.
            myReader.close();
        }
        catch (FileNotFoundException error) {
            System.out.println("File not found, please continue testing the program.");
        }
        catch (NoSuchElementException error) {
            System.out.println("There was an issue with the file attempting to be loaded.");
        }
    }

    /**
     * Searches for data on a specific date using binary recursion.
     * @param arrayList The arrayList being passed in.
     * @param date The date being searched for.
     * @param start The starting index of the array.
     * @param end The ending index of the array.
     * @return Data associated with the date entered.
     */
    public static LogEntry binarySearch(ArrayList<LogEntry> arrayList, Instant date, int start, int end) {
        if (arrayList.size() == 0) {
            return null;
        }

        if (end == start) {
            var entry = arrayList.get(start);

            if (entry.getTime().equals(date)) {
                return entry;
            }
            else {
                return null;
            }
        }

        var mid = start + (end - start) / 2;
        var midValue = arrayList.get(mid);
        var compare = date.compareTo(midValue.getTime());

        if (compare == 0) {
            return midValue;
        }
        else if (compare < 0) {
            return binarySearch(arrayList, date, start, mid - 1);
        }
        else {
            return binarySearch(arrayList, date, mid + 1, end);
        }
    }

    public static void main(String[] args) {
        String continueOperator = "";
        Scanner inputTxt = new Scanner(System.in);

        while (!continueOperator.equals("n")) {
            System.out.println("Please enter what kind of file you would like read");
            System.out.println("1 for EntryLogs,");
            System.out.println("2 for VisitorEntry &");
            System.out.println("3 for ErrorEntry: ");
            String filetype = inputTxt.nextLine();

            System.out.println("What is the name of the file: ");
            String fileName = inputTxt.nextLine() + ".txt";
            switch (filetype) {
                case "1": readLogEntryFile(fileName);
                    break;
                case "2": readVisitorEntryFile(fileName);
                    break;
                case "3": readErrorEntryFile(fileName);
                    break;
            }
            logs.sort(new LogEntryComparator());

            System.out.println("Would you like to add another file(Y/N)?: ");
            continueOperator = inputTxt.nextLine().toLowerCase();
        }

        System.out.println("Please enter the date you are searching for: ");
        Instant date = Instant.parse(inputTxt.nextLine());

        System.out.println("Your result is: " + Objects.requireNonNull(binarySearch(logs, date, 0, logs.size() - 1)));

        //Print the ArrayList object one object at a time, to the console.
        for (var item : logs) {
            System.out.println(item);
        }
    }
}
