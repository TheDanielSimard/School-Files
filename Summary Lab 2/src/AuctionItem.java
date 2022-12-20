/**
 * AuctionItem inherits Item object and enhances it.
 * @author Daniel Simard
 * @date October 16th 2020
 **/
import java.time.Instant;
public class AuctionItem extends Item
{
    public static final String NONE = "";   //CONSTANT declaring a blank string.
    private String accountName;             //The account name of the highest bidder.
    private double highestBid;              //The largest bid amount.
    private Instant endingTime;             //The ending time of the auction.

    //CONSTRUCTORS

    /**
     * Constructor that takes values as parameters for all fields of the object.
     * @param name Name of the item.
     * @param description Description of the item.
     * @param duration How long the auction will last.
     */
    public AuctionItem(String name, String description, int duration)
    {
        super(name, description);
        this.highestBid = 0;
        this.accountName = NONE;
        this.endingTime = Instant.now().plusSeconds(duration * 3600L);
    }

    /**
     * Copy constructor that takes a AuctionItem object as a parameter and copies the fields to this.
     * @param auctionItem AuctionItem object to be copied to this.
     */
    public AuctionItem(AuctionItem auctionItem)
    {
        super(auctionItem.getName(), auctionItem.getDescription());
        this.accountName = auctionItem.getHighBidder();
        this.highestBid = auctionItem.highestBid;
        this.endingTime = auctionItem.endingTime;
    }

    //ACCESSORS

    /**
     * Gets the remaining time left.
     * @return Remaining time left.
     */
    public long getTimeLeft()
    {
        return endingTime.getEpochSecond() - Instant.now().getEpochSecond();
    }

    /**
     * Gets the highest bid.
     * @return The highest bid.
     */
    public String getHighBidder()
    {
        return this.accountName;
    }

    //OTHER METHODS

    /**
     * Intakes a new bid object and checks if the bid is higher if so overwrite the current bidder information.
     * @param amount The amount being bid.
     * @param bidder The account that is bidding.
     * @return Whether the bid goes through and the information of the bid.
     */
    public boolean bid(double amount, String bidder)
    {
        if (isActive() && amount > highestBid)
        {
            this.accountName = bidder;
            this.highestBid = amount;
            return true;
        }
        return false;
    }

    /**
     * Gets whether the auction is still active.
     * @return Whether the auction is active.
     */
    public boolean isActive()
    {
        Instant currentTime = Instant.now();
        return !currentTime.isAfter(endingTime);
    }

    /**
     * Returns a String representing the data of the object.
     * @return String with name, description, price and shipping on separate lines.
     */
    public String toString()
    {
        return  super.toString()
                + "\nHigh bid:\t$" + this.highestBid
                + "\nHigh bidder:\t" + this.accountName
                + "\nTime Left:\t" + getTimeLeft()/3600 + " hours, " + getTimeLeft()%3600 + " minutes"
                + "\nEnds at:\t" + endingTime;
    }
}
