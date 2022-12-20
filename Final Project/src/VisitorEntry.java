/**
 * This class represents a visitor entry.
 *
 * @author Daniel Simard
 * @date December 18th, 2022
 */

import java.time.Instant;

public class VisitorEntry extends LogEntry {
    private final String name;       //The name of the visitor.
    private Instant signedOut;      //The time when the visitor signed out.

    //CONSTRUCTORS

    /**
     * VisitorEntry, constructor that takes arguments for all fields.
     * @param textTime CharSequence, time of the entry.
     * @param name String, name of the person.
     */
    public VisitorEntry(Instant textTime, String name) {
        super(textTime);
        this.name = name;
        this.signedOut = null;
    }

    /**
     * VisitorEntry, a deep copy constructor.
     * @param toCopy An VisitorEntry object to copy into the current object.
     */
    public VisitorEntry(VisitorEntry toCopy) {
        super(toCopy);
        this.name = toCopy.name;
        if (toCopy.signedOut != null) {
            this.signedOut = toCopy.signedOut;
        } else {
            this.signedOut = null;
        }
    }

    //OTHER METHODS

    /**
     * Checks whether the person has signed out yet.
     * @return True if they haven't and signs them out otherwise false.
     */
    public boolean signOut() {
        if (this.signedOut == null) {
            this.signedOut = Instant.now();
            return true;
        } else return false;
    }

    /**
     * ToString, return a String representing the data of the object.
     * @return String if unfrozen of data otherwise adds "FROZEN" to the list.
     */
    public String toString() {
        if (isFrozen()) {
            return super.toString();
        } else {
            if (this.signedOut != null) {
                return super.toString() + "\n" + name + "\t" + signedOut;
            } else return super.toString() + "\t" + "Signed in";
        }
    }
}

