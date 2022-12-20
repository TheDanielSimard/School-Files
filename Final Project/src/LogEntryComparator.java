import java.util.Comparator;

public class LogEntryComparator implements Comparator<LogEntry> {
    // override the compare() method
    public int compare(LogEntry s1, LogEntry s2) {
        return s1.getTime().compareTo(s2.getTime());
    }
}
