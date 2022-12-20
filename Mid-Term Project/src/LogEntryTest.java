import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Test;

import java.time.Instant;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertNotEquals;

class LogEntryTest {
	
	// Two log entries to test that the class behaves
	// appropriately given its state.
	private final String FREEZE_CODE = "brrr";
	private final String NOT_FREEZE_CODE = "shiver";
	private final String ANNOTATION = "annotation";
	private LogEntry logEntry, logEntryFrozen, entryBefore, entryAfter;
	

	@BeforeEach
	void setUp() throws Exception {
		 entryBefore = new LogEntry(Instant.now().toString());
		 // Let a little time pass
		 Thread.sleep(100);
		 logEntry =  new LogEntry(Instant.now().toString());
		 logEntryFrozen =  new LogEntry(Instant.now().toString());
		// Let a little more time pass
		 Thread.sleep(100);
		 entryAfter = new LogEntry(Instant.now().toString());
		 logEntryFrozen.freeze(FREEZE_CODE);
	}

	@Test
	@DisplayName("Test unfrozen log entry behavior."
		     + "Log entry should allow annotation."
		     + "Log entry should not unfreeze with correct or incorrect code."
		     + "Log entry should freeze.")
	void testUnfrozenLogEntry() {
		// We can annotate
		assertEquals(true, logEntry.annotate(ANNOTATION));
		int index = logEntry.toString().indexOf(ANNOTATION);
		assertNotEquals(-1, index);
		// We cannot unfreeze
		assertEquals(false, logEntry.unfreeze(FREEZE_CODE));
		assertEquals(false, logEntry.unfreeze(NOT_FREEZE_CODE));
		// We can freeze and unfreeze
		logEntry.freeze(FREEZE_CODE);
		assertEquals(true, logEntry.unfreeze(FREEZE_CODE));
	}

	@Test
	@DisplayName("Test frozen log entry behavior."
		     + "Log entry should not allow annotation."
		     + "Log entry should not allow freeze."
		     + "Log entry should only return time and string 'FROZEN'."
		     + "Log entry should unfreeze with correct code.")
	void testFrozenLogEntry() {
		// We cannot annotate
		assertEquals(false, logEntryFrozen.annotate(ANNOTATION));
		int index = logEntryFrozen.toString().indexOf(ANNOTATION);
		assertEquals(-1, index);
		// We cannot freeze with a different freezecode
		logEntryFrozen.freeze(NOT_FREEZE_CODE);
		assertEquals(false, logEntryFrozen.unfreeze(NOT_FREEZE_CODE));
		// toString just informs us it's frozen
		index = logEntryFrozen.toString().indexOf("FROZEN");
		assertNotEquals(-1, index);
		// We can unfreeze with the correct freezecode
		assertEquals(true, logEntryFrozen.unfreeze(FREEZE_CODE));
	}
	
	@Test
	@DisplayName("Test unfrozen log entry annotation behavior."
		     + "Ensure that multiple annotations are added correctly.")
	void testAnnotation() {
		// We can annotate multiple times.
		int index = 0;
		for (int i=0; i < 5; i++) {
			assertEquals(true, logEntry.annotate(ANNOTATION));
			index = logEntry.toString().indexOf(ANNOTATION, index);
			assertNotEquals(-1, index);
		}
	}
	
	@Test
	@DisplayName("Test unfrozen log entry isBefore behavior.")
	void testIsBefore() {
		assertEquals(true, logEntry.isBefore(entryAfter));
		assertEquals(false, logEntry.isBefore(entryBefore));
	}
	
	@Test
	@DisplayName("Test copy constructor.")
	void testCopy() {
		// Copy, check that they're equal
		LogEntry copyLogEntry = new LogEntry(logEntry);
		assertEquals(logEntry.toString(), copyLogEntry.toString());
		// Check that the log is a deep copy and not a reference
		logEntry.annotate(ANNOTATION);
		assertNotEquals(logEntry.toString(), copyLogEntry.toString());
	}
}
