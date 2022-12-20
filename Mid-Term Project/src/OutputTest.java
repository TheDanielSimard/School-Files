/**
 * This class holds the main method and test all the other classes.
 * @author Daniel Simard
 * @date October 23rd 2022
 */
import java.time.Instant;
public class OutputTest
{
    public static void main(String[] arg)
    {
        Instant current = Instant.now();

        //Create a LogEntry object and annotate it multiple times, printing the object each time.
        LogEntry logEntry = new LogEntry(current.toString());

        System.out.println("*******************************************************");
        System.out.println("Create a LogEntry object and annotate it multiple times, printing the object each time.");
        for (int i = 1; i <4; i++)
        {
            String annotation = "Entry ";
            annotation += i;
            logEntry.annotate(annotation);
            System.out.println(logEntry);
        }

        //Create a second LogEntry object using the copy constructor, with the first object as the argument. Print it.
        LogEntry logEntryCopy = new LogEntry(logEntry);

        System.out.println("*******************************************************");
        System.out.println("Create a second LogEntry object using the copy constructor, with the first object as the argument. Print it.");
        System.out.println(logEntryCopy);

        //Create LogEntry objects before and after creating the LogEntry object and send the
        //isBefore message to the LogEntry object with these objects as parameters, displaying the result.
        LogEntry logEntryCurrent = new LogEntry(current.toString());
        LogEntry logEntryBefore = new LogEntry(current.minusSeconds(300).toString());
        logEntryBefore.annotate(" (true/false): ");

        LogEntry logEntryAfter = new LogEntry(current.plusSeconds(300).toString());
        logEntryAfter.annotate(" (true/false): ");

        System.out.println("*******************************************************");
        System.out.println("Create LogEntry objects before and after creating the LogEntry object and send the");
        System.out.println("isBefore message to the LogEntry object with these objects as parameters, displaying the result.");
        System.out.println(current + " is before " + logEntryBefore + "\r" + logEntryCurrent.isBefore(logEntryBefore));
        System.out.println(current + " is before " + logEntryAfter + "\r" + logEntryCurrent.isBefore(logEntryAfter));
        System.out.println();

        //Check the object with isFrozen and print the result.
        System.out.println("*******************************************************");
        System.out.println("Check the object with isFrozen and print the result.");
        System.out.println("Is the log entry frozen: " + logEntryCurrent.isFrozen());
        System.out.println();

        //Freeze the LogEntry object and attempt to annotate it, printing the object after the attempt.
        //Check the object with isFrozen and print the result.
        logEntryCurrent.freeze("Negative thirty degrees.");
        logEntryCurrent.annotate("Attempting to annotate.");

        System.out.println("*******************************************************");
        System.out.println("Freeze the LogEntry object and attempt to annotate it, printing the object after the attempt.");
        System.out.println("Check the object with isFrozen and print the result.");
        System.out.println(logEntryCurrent);
        System.out.println("Is the log entry frozen: " + logEntryCurrent.isFrozen());
        System.out.println();

        //Attempt to unfreeze the LogEntry object with the wrong freeze code; print the result. Check
        //with isFrozen and print the result.
        logEntryCurrent.unfreeze("Plus thirty degrees.");

        System.out.println("*******************************************************");
        System.out.println("Attempt to unfreeze the LogEntry object with the wrong freeze code; print the result.");
        System.out.println("Check with isFrozen and print the result.");
        System.out.println(logEntryCurrent);
        System.out.println("Is the log entry frozen: " + logEntryCurrent.isFrozen());
        System.out.println();

        //Unfreeze the LogEntry object with the correct freeze code; print the result.
        //Check with isFrozen and print the result. Annotate again and print the object.
        logEntryCurrent.unfreeze("Negative thirty degrees.");

        System.out.println("*******************************************************");
        System.out.println("Unfreeze the LogEntry object with the correct freeze code; print the result.");
        System.out.println("Check with isFrozen and print the result. Annotate again and print the object.");
        System.out.println(logEntryCurrent);
        System.out.println("Is the log entry frozen: " + logEntryCurrent.isFrozen());

        logEntryCurrent.annotate("The object is no longer frozen.");

        System.out.println(logEntryCurrent);

        //Create a VisitorEntry object. Demonstrate that it behaves as a LogEntry object by
        //following the steps above for the LogEntry object, but on the VisitorEntry object. (You will
        //create a second VisitorEntry object for the copy constructor portion.)
        System.out.println("*******************************************************");
        System.out.println("Create a VisitorEntry object. Demonstrate that it behaves as a LogEntry object by");
        System.out.println("following the steps above for the LogEntry object, but on the VisitorEntry object. (You will");
        System.out.println("create a second VisitorEntry object for the copy constructor portion.)");

        String visitor = "Daniel";
        VisitorEntry visitorEntry = new VisitorEntry(current.toString(), visitor);

        System.out.println("*******************************************************");
        System.out.println("Create a VisitorEntry object and annotate it multiple times, printing the object each time.");
        for (int i = 1; i <4; i++)
        {
            String annotation = "Entry ";
            annotation += i;
            visitorEntry.annotate(annotation);
            System.out.println(visitorEntry);
        }
        System.out.println();

        VisitorEntry visitorEntryCopy = new VisitorEntry(visitorEntry);

        System.out.println("*******************************************************");
        System.out.println("Create a second VisitorEntry object using the copy constructor, with the first object as the argument. Print it.");
        System.out.println(visitorEntryCopy);

        VisitorEntry visitorEntryCurrent = new VisitorEntry(current.toString(), visitor);
        VisitorEntry visitorEntryBefore = new VisitorEntry(current.minusSeconds(300).toString(), visitor);
        visitorEntryBefore.annotate(" (true/false): ");

        VisitorEntry visitorEntryAfter = new VisitorEntry(current.plusSeconds(300).toString(), visitor);
        visitorEntryAfter.annotate(" (true/false): ");

        System.out.println("*******************************************************");
        System.out.println("Create VisitorEntry objects before and after creating the VisitorEntry object and send the");
        System.out.println("isBefore message to the VisitorEntry object with these objects as parameters, displaying the result.");
        System.out.println(current + " is before " + visitorEntryBefore + "\r" + visitorEntryCurrent.isBefore(visitorEntryBefore));
        System.out.println(current + " is before " + visitorEntryAfter + "\r" + visitorEntryCurrent.isBefore(visitorEntryAfter));
        System.out.println();

        System.out.println("*******************************************************");
        System.out.println("Check the object with isFrozen and print the result.");
        System.out.println("Is the log entry frozen: " + visitorEntryCurrent.isFrozen());
        System.out.println();

        visitorEntryCurrent.freeze("Negative thirty degrees.");
        visitorEntryCurrent.annotate("Attempting to annotate.");

        System.out.println("*******************************************************");
        System.out.println("Freeze the VisitorEntry object and attempt to annotate it, printing the object after the attempt.");
        System.out.println("Check the object with isFrozen and print the result.");
        System.out.println(visitorEntryCurrent);
        System.out.println("Is the log entry frozen: " + visitorEntryCurrent.isFrozen());
        System.out.println();

        visitorEntryCurrent.unfreeze("Plus thirty degrees.");

        System.out.println("*******************************************************");
        System.out.println("Attempt to unfreeze the VisitorEntry object with the wrong freeze code; print the result.");
        System.out.println("Check with isFrozen and print the result.");
        System.out.println(visitorEntryCurrent);
        System.out.println("Is the log entry frozen: " + visitorEntryCurrent.isFrozen());
        System.out.println();

        visitorEntryCurrent.unfreeze("Negative thirty degrees.");

        System.out.println("*******************************************************");
        System.out.println("Unfreeze the VisitorEntry object with the correct freeze code; print the result.");
        System.out.println("Check with isFrozen and print the result. Annotate again and print the object.");
        System.out.println(visitorEntryCurrent);
        System.out.println("Is the log entry frozen: " + visitorEntryCurrent.isFrozen());

        visitorEntryCurrent.annotate("The object is no longer frozen.");

        System.out.println(visitorEntryCurrent);
        System.out.println();

        //Create another VisitorEntry object. Print it.
        VisitorEntry visitorEntryTest = new VisitorEntry(current.toString(), visitor);

        System.out.println("*******************************************************");
        System.out.println("Create another VisitorEntry object. Print it.");
        System.out.println(visitorEntryTest);
        System.out.println();

        //Send the object the signOut message; print the result and the object.
        visitorEntryTest.signOut();

        System.out.println("*******************************************************");
        System.out.println("Send the object the signOut message; print the result and the object.");
        System.out.println(visitorEntryTest);
        System.out.println();

        //Send the object the signOut message again; print the result and the object.
        visitorEntryTest.signOut();

        System.out.println("*******************************************************");
        System.out.println("Send the object the signOut message again; print the result and the object.");
        System.out.println(visitorEntryTest);
        System.out.println();

        //Create an ErrorEntry object. Demonstrate that it behaves as a LogEntry object by following
        //the steps above for the LogEntry object, but on the ErrorEntry object. (You will create a
        //second ErrorEntry object for the copy constructor portion.)
        System.out.println("*******************************************************");
        System.out.println("Create an ErrorEntry object. Demonstrate that it behaves as a LogEntry object by following");
        System.out.println("the steps above for the LogEntry object, but on the ErrorEntry object. (You will create a");
        System.out.println("second ErrorEntry object for the copy constructor portion.)");

        ErrorClass error = ErrorClass.ALPHA;
        ErrorEntry errorEntry = new ErrorEntry(current.toString(), error);

        System.out.println("*******************************************************");
        System.out.println("Create a ErrorEntry object and annotate it multiple times, printing the object each time.");
        for (int i = 1; i <4; i++)
        {
            String annotation = "Entry ";
            annotation += i;
            errorEntry.annotate(annotation);
            System.out.println(errorEntry);
        }
        System.out.println();

        ErrorEntry errorEntryCopy = new ErrorEntry(errorEntry);

        System.out.println("*******************************************************");
        System.out.println("Create a second ErrorEntry object using the copy constructor, with the first object as the argument. Print it.");
        System.out.println(errorEntryCopy);

        ErrorEntry errorEntryCurrent = new ErrorEntry(current.toString(), error);
        ErrorEntry errorEntryBefore = new ErrorEntry(current.minusSeconds(300).toString(), error);
        errorEntryBefore.annotate(" (true/false): ");

        ErrorEntry errorEntryAfter = new ErrorEntry(current.plusSeconds(300).toString(), error);
        errorEntryAfter.annotate(" (true/false): ");

        System.out.println("*******************************************************");
        System.out.println("Create ErrorEntry objects before and after creating the ErrorEntry object and send the");
        System.out.println("isBefore message to the ErrorEntry object with these objects as parameters, displaying the result.");
        System.out.println(current + " is before " + errorEntryBefore + "\r" + errorEntryCurrent.isBefore(errorEntryBefore));
        System.out.println(current + " is before " + errorEntryAfter + "\r" + errorEntryCurrent.isBefore(errorEntryAfter));
        System.out.println();

        System.out.println("*******************************************************");
        System.out.println("Check the object with isFrozen and print the result.");
        System.out.println("Is the log entry frozen: " + errorEntryCurrent.isFrozen());
        System.out.println();

        errorEntryCurrent.freeze("Negative thirty degrees.");
        errorEntryCurrent.annotate("Attempting to annotate.");

        System.out.println("*******************************************************");
        System.out.println("Freeze the ErrorEntry object and attempt to annotate it, printing the object after the attempt.");
        System.out.println("Check the object with isFrozen and print the result.");
        System.out.println(errorEntryCurrent);
        System.out.println("Is the log entry frozen: " + errorEntryCurrent.isFrozen());
        System.out.println();

        errorEntryCurrent.unfreeze("Plus thirty degrees.");

        System.out.println("*******************************************************");
        System.out.println("Attempt to unfreeze the ErrorEntry object with the wrong freeze code; print the result.");
        System.out.println("Check with isFrozen and print the result.");
        System.out.println(errorEntryCurrent);
        System.out.println("Is the log entry frozen: " + errorEntryCurrent.isFrozen());
        System.out.println();

        errorEntryCurrent.unfreeze("Negative thirty degrees.");

        System.out.println("*******************************************************");
        System.out.println("Unfreeze the ErrorEntry object with the correct freeze code; print the result.");
        System.out.println("Check with isFrozen and print the result. Annotate again and print the object.");
        System.out.println(errorEntryCurrent);
        System.out.println("Is the log entry frozen: " + errorEntryCurrent.isFrozen());

        errorEntryCurrent.annotate("The object is no longer frozen.");

        System.out.println(errorEntryCurrent);
        System.out.println();

        //Create another ErrorEntry object. Print it.
        ErrorEntry errorEntryTest = new ErrorEntry(current.toString(), error);
        String provider = "Wall-E";

        System.out.println("*******************************************************");
        System.out.println("Create another ErrorEntry object. Print it.");
        System.out.println(errorEntryTest);
        System.out.println();

        //Send the object the resolve message; print the result and the object.
        errorEntryTest.resolve(provider);

        System.out.println("*******************************************************");
        System.out.println("Send the object the resolve message; print the result and the object.");
        System.out.println(errorEntryTest);
        System.out.println();

        //Send the object the resolve message again; print the result and the object.
        errorEntryTest.resolve(provider);

        System.out.println("*******************************************************");
        System.out.println("Send the object the resolve message again; print the result and the object.");
        System.out.println(errorEntryTest);
        System.out.println("*******************************************************");
    }
}
