/**
 * This class represents a log entry.
 *
 * @author Daniel Simard
 * @date December 18th, 2022
 */

import java.time.Instant;
import java.util.ArrayList;

public class LogEntry {
    private final String NOT_FROZEN = "XXX";    //A constant that is used to declare if a value is frozen or not.
    private final Instant time;                 //Holds the value of the time.
    private final ArrayList<String> notes;      //Holds all the annotated strings.
    private String freezeCode;                  //A string value that is used to decide if something is frozen or not.

    //CONSTRUCTORS

    /**
     * LogEntry, constructor that takes arguments for all fields.
     * @param time Time of the entry.
     */
    public LogEntry(Instant time) {
        this.time = time;
        this.notes = new ArrayList<>();
        this.freezeCode = NOT_FROZEN;
    }

    /**
     * LogEntry, a deep copy constructor.
     * @param toCopy An LogEntry object to copy into the current object.
     */
    public LogEntry(LogEntry toCopy) {
        this.time = toCopy.time;
        this.notes = (ArrayList<String>) (toCopy.notes.clone());
        this.freezeCode = toCopy.freezeCode;
    }

    public Instant getTime() {
        return this.time;
    }

    //FREEZE METHODS

    /**
     * Checking if the entry is chronologically after the log entry's time.
     * @param thisEntry LogEntry, current entry being checked.
     * @return True if the LogEntry object passed has a time field that is
     * chronologically after the log entry’s time field otherwise false.
     */
    public boolean isBefore(LogEntry thisEntry) {
        return time.compareTo(thisEntry.time) <= 0;
    }

    /**
     * Checks if the object is frozen or not, if it is not frozen
     * then freeze it and store the freezeCode otherwise do nothing.
     * @param freezeCode String, object being stored.
     */
    public void freeze(String freezeCode) {
        if (!isFrozen()) {
            this.freezeCode = freezeCode;
        }
    }

    /**
     * Checks if the object is frozen then it matches the freezeCode
     * parameter and object then stores them otherwise does nothing and returns false.
     * @param freezeCode String, object being stored.
     * @return True if the freezeCode parameter and object match otherwise false.
     */
    public boolean unfreeze(String freezeCode) {
        if (freezeCode.equals(this.freezeCode)) {
            this.freezeCode = NOT_FROZEN;
            return true;
        } else return false;
    }

    /**
     * If the object is frozen it returns true otherwise false.
     * @return True if the object is frozen otherwise false.
     */
    public boolean isFrozen() {
        return !freezeCode.equals(NOT_FROZEN);
    }

    //STRING CONCATENATION METHODS

    /**
     * If the object is frozen nothing happens otherwise it constructs
     * a string with the current time and the annotation parameter then returns true.
     * @param annotation String, modified element.
     * @return True if unfrozen and false if frozen.
     */
    public boolean annotate(String annotation) {
        if (isFrozen()) {
            return false;
        } else {
            String resultString = "";
            resultString += this.time.toString();
            resultString += "\t " + annotation;
            this.notes.add(resultString);
            return true;
        }
    }

    /**
     * ToString, return a String representing the data of the object.
     * @return String if unfrozen of data otherwise adds "FROZEN" to the list.
     */
    public String toString() {
        StringBuilder resultString = new StringBuilder();
        resultString.append(this.time.toString());
        if (isFrozen()) {
            resultString.append("FROZEN");
        } else {
            for (String note : this.notes) {
                resultString.append(note).append("\n");
            }
        }
        return resultString.toString();
    }
}
