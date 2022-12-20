/**
 * This class tests functionality of each method located in the AttractionTicket class.
 *
 * @author Daniel Simard
 * @date 06 November 2022
 */

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import javax.sound.midi.SysexMessage;

public class AttractionTicketTest {
    private AttractionTicket ticketHolder;


    @BeforeEach
    void setUp() throws Exception
    {
        //Runs before each @Test method.
        ticketHolder = new AttractionTicket("Escher Falls", 1, 1);
    }

    @Test
    void AccessorTest()
    {
        //Declaring accessor values.
        String attractionName = ticketHolder.getAttractionName();
        int ticketHolder = this.ticketHolder.getTicketHolder();

        //Testing if the accessors returned the correct values.
        assertEquals("Escher Falls", attractionName);
        assertEquals(1, ticketHolder);

        //Testing with incorrect accessor values.
        assertNotEquals("Niagara Falls", attractionName);
        assertNotEquals(2, ticketHolder);
    }

    @Test
    void isValidTest()
    {
        //Testing the isValid() returns true if the ticket has not been queued.
        assertTrue(ticketHolder.isValid());

        //Testing the isValid() method returns false if the ticket has been queued.
        assertTrue(ticketHolder.queueUp(1));
        assertFalse(ticketHolder.isValid());
    }

    @Test
    void transferTicketTest()
    {
        //Verifies if the ticketHolder is valid before testing.
        assertTrue(ticketHolder.isValid());

        //Checking that the ticketHolder is currently 1.
        assertEquals(1, ticketHolder.getTicketHolder());

        //If the ticket isValid() then the ticketHolder field is changed to 2.
        assertTrue(ticketHolder.transferTicket(2));
        assertEquals(2, ticketHolder.getTicketHolder());

        //Making the ticket invalid for transfer test.
        assertTrue(ticketHolder.queueUp(2));

        //Testing if the ticket holder can be transferred when the ticket is invalid.
        assertFalse(ticketHolder.transferTicket(3));
        assertNotEquals(3, ticketHolder.getTicketHolder());
    }

    @Test
    void queueUpTest()
    {
        //Verifies if the ticketHolder is valid before testing and checks if the ticketHolder is equal to 1.
        assertTrue(ticketHolder.isValid());
        assertEquals(1, ticketHolder.getTicketHolder());

        //Queuing up the wrong ticketHolder should return false.
        assertFalse(ticketHolder.queueUp(2));

        //Queueing up the ticketHolder should return true.
        assertTrue(ticketHolder.queueUp(1));

        //Queueing up the ticketHolder a second time should return false.
        assertFalse(ticketHolder.queueUp(1));
    }
}
