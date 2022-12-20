/**
 * This class represents an error entry.
 * @author Daniel Simard
 * @date October 23rd 2022
 */
import java.time.Instant;
public class ErrorEntry extends LogEntry
{
    private final ErrorClass classification;      //The classification of the error.
    private Instant timeResolved;           //The time the error was resolved.
    private String provider;                //Who resolved the error.

    //CONSTRUCTORS

    /**
     * ErrorEntry, constructor that takes arguments for all fields.
     * @param textTime CharSequence, time of the entry.
     * @param classification String, type of error.
     */
    public ErrorEntry(CharSequence textTime, ErrorClass classification)
    {
        super(textTime);
        this.timeResolved = null;
        this.provider = "";
        this.classification = classification;
    }

    /**
     * ErrorEntry, a deep copy constructor.
     * @param toCopy An ErrorEntry object to copy into the current object.
     */
    public ErrorEntry(ErrorEntry toCopy)
    {
        super(toCopy);
        this.classification = toCopy.classification;
        this.timeResolved = toCopy.timeResolved;
        this.provider = toCopy.provider;
    }

    //OTHER METHODS

    /**
     * Checks if the issue has already been resolved.
     * @param provider Whether the error has been resolved.
     * @return True if it has not been resolved otherwise false.
     */
    public boolean resolve(String provider)
    {
        if (this.timeResolved != null)
        {
            return false;
        }
        else
        {
            timeResolved = Instant.now();
            this.provider = provider;
            return true;
        }
    }

    /**
     * ToString, return a String representing the data of the object.
     * @return String if unfrozen of data otherwise adds "FROZEN" to the list.
     */
    public String toString()
    {
        if (isFrozen())
        {
            return super.toString();
        }
        else
        {
            if (timeResolved != null)
            {
                return super.toString() + classification + "\t" + provider + "\n" + timeResolved;
            }
            else return super.toString() + classification + "\t" + "Unresolved";
        }
    }
}
