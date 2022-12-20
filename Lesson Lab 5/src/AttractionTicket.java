
/**
 * A ticket to an amusement park attraction.
 * Note that this is a simplified version of a class that uses popularity and
 * a ticket time window to determine validity of the ticket, so some fields
 * are not used here and most methods are simplified.
 * @author Maggie
 *
 */
public class AttractionTicket {
		
	private String attractionName;
	private int ticketHolder, popularity;
	private boolean queued;
	
	// Constructor
	/**
	 * Construct an attraction ticket from parameters.
	 * @param name  The name of the attraction.
	 * @param ticketHolder  The ID number of the ticket holder.
	 * @param popularity  The popularity value of the attraction.
	 */
	public AttractionTicket(String name, int ticketHolder, int popularity) {
		this.attractionName = name;
		this.ticketHolder = ticketHolder;
		this.popularity = popularity;
		this.queued = false;
	}
	
	// Accessors
	/**
	 * Returns the name of the attraction.
	 * @return The attraction name.
	 */
	public String getAttractionName() {
		return this.attractionName;
	}
	
	/**
	 * Returns the ID of the ticket holder.
	 * @return  The ticket holder ID.
	 */
	public int getTicketHolder() {
		return this.ticketHolder;
	}
	
	/**
	 * Determine and return the validity of the ticket.
	 * @return true if it's a valid ticket; false otherwise.
	 */
	public boolean isValid() {
		boolean valid = false;
		// Once the holder has queued, the ticket isn't valid.
		if (!this.queued) {
			valid = true;
		}
		return valid;
	}
		
	
	// Mutators
	/**
	 * Transfer the ticket to the new ticket holder if the ticket is valid.
	 * @param newTicketHolder The ID of the ticket holder to transfer the ticket to.
	 * @return true if the ticket was successfully transferred; false otherwise.
	 */
	public boolean transferTicket(int newTicketHolder) {
		boolean valid = false;
		if (isValid()) {
			this.ticketHolder = newTicketHolder;
			valid = true; 
		}
		return valid;
	}
	
	/**
	 * If the ticketHolder passed matches the ticketHolder of the ticket, queue them.
	 * @param ticketHolder The ID of the ticket holder attempting to queue.
	 * @return true if queuing was successful.
	 */
	public boolean queueUp(int ticketHolder) {
		boolean valid = false;
		if (isValid() && ticketHolder == this.ticketHolder) {
			this.queued = true;
			valid = true; 
		}
		return valid;
	}
	
}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	