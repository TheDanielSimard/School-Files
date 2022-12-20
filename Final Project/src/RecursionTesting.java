/**
 * This class test the Binary Recursion method in EntryReader.
 *
 * @author Daniel Simard
 * @date December 18th, 2022
 */

import org.junit.jupiter.api.Test;

import java.time.Instant;
import java.util.ArrayList;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class RecursionTesting {
    /**
     * I will create a new ArrayList for testing and add elements of each Entry type.
     * Then I will sort the ArrayList and test for if its sorted properly. Afterwards,
     * I will test the binary search method for each type of Entry.
     */
    @Test
    void recursionTest() {
        var logsTest = new ArrayList<LogEntry>();

        logsTest.add(new LogEntry(Instant.parse("2001-11-08T20:26:52.150209800Z")));
        logsTest.add(new LogEntry(Instant.parse("2005-11-08T20:26:52.490582300Z")));
        logsTest.add(new LogEntry(Instant.parse("2016-11-08T20:26:52.598619200Z")));

        logsTest.add(new VisitorEntry(Instant.parse("2007-11-08T20:26:52.816429600Z"), "C3PO"));
        logsTest.add(new VisitorEntry(Instant.parse("2013-11-08T20:26:52.816429600Z"), "B2EMO"));
        logsTest.add(new VisitorEntry(Instant.parse("2019-11-08T20:26:52.816429600Z"), "ROBOT"));

        logsTest.add(new ErrorEntry(Instant.parse("2002-11-08T20:26:52.816429600Z"), ErrorClass.ALPHA));
        logsTest.add(new ErrorEntry(Instant.parse("2003-11-08T20:26:52.816429600Z"), ErrorClass.GAMMA));
        logsTest.add(new ErrorEntry(Instant.parse("2020-11-08T20:26:52.816429600Z"), ErrorClass.DELTA));

        logsTest.sort(new LogEntryComparator());

        //Testing if the array is properly sorted.
        assertEquals(Instant.parse("2001-11-08T20:26:52.150209800Z"), logsTest.get(0).getTime());
        assertEquals(Instant.parse("2020-11-08T20:26:52.816429600Z"), logsTest.get(logsTest.size() - 1).getTime());

        //Testing when searching for a date that holds a EntryLog.
        var result3 = "2001-11-08T20:26:52.150209800Z";
        assertEquals(result3, EntryReader.binarySearch(logsTest, Instant.parse("2001-11-08T20:26:52.150209800Z"), 0, logsTest.size() - 1).toString());

        //Testing when searching for a date that holds a VisitorLog.
        var result2 = "2013-11-08T20:26:52.816429600Z" + "\t" + "Signed in";
        assertEquals(result2, EntryReader.binarySearch(logsTest, Instant.parse("2013-11-08T20:26:52.816429600Z"), 0, logsTest.size() - 1).toString());

        //Testing when searching for a date that holds a ErrorLog.
        var result = "2002-11-08T20:26:52.816429600Z" + "\t" + ErrorClass.ALPHA + "\t" + "Unresolved";
        assertEquals(result, EntryReader.binarySearch(logsTest, Instant.parse("2002-11-08T20:26:52.816429600Z"), 0, logsTest.size() - 1).toString());
    }
}
