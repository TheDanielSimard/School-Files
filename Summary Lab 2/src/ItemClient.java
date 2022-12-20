/**
 * Create some SaleItem and AuctionItem objects, send messages, compare results.
 * @author Maggie
 *
 */
public class ItemClient {
	
	private static String NAME = "Lovely shirt";
	private static String DESCRIPTION = "Blue shirt that is lovely.";
	private static double PRICE = 9.99;
	private static double SHIPPING = 4.95;
	private static int NUM_IN_STOCK	= 50;
	
	private static String AUCTION_ITEM_NAME = "Disney pin";
	private static String AUCTION_ITEM_DESCRIPTION = "Cute stylized Disney pin.";
	private static double DEFAULT_HIGH_BID = 0.0;
	private static String DEFAULT_HIGH_BIDDER = AuctionItem.NONE;
	private static String BIDDER = "Princess4Evar";
	private static String BIDDER2 = "StoleYourAuction";
	private static double BID = 1.0;
	private static double SECOND_BID = 1.5;
	
	/**
	 * Display what the SaleItem output should look like for constant values.
	 */
	public static void printExpectedSaleItem() {
		String str = NAME + "\n" + DESCRIPTION;
		str += "\nPrice:\t" + PRICE + "\nShipping:\t" + SHIPPING;	
		System.out.println(str);
	}

	/**
	 * Display what the AuctionItem output should look like for constant values.
	 */
	public static void printExpectedAuctionItem() {
		String str = AUCTION_ITEM_NAME + "\n" + AUCTION_ITEM_DESCRIPTION + "\nHigh bid:\t" + DEFAULT_HIGH_BID
				+ "\nHigh bidder:\t" + DEFAULT_HIGH_BIDDER + "\nTime Left:\t1 hours, 0 minutes\nEnds at:\t(current time + 1 hour) \n";
		System.out.println(str);
	}
	
	/**
	 * Display what the AuctionItem output should look like after one bid.
	 */
	public static void printExpectedAuctionItemOneBid() {
		String str = AUCTION_ITEM_NAME + "\n" + AUCTION_ITEM_DESCRIPTION + "\nHigh bid:\t" + BID
				+ "\nHigh bidder:\t" + BIDDER + "\nTime Left:\t0 hours, 59 minutes\nEnds at:\t(current time + 1 hour) \n";
		System.out.println(str);
	}
	
	/**
	 * Display what the AuctionItem output should look like after second successful bid.
	 */
	public static void printExpectedAuctionItemSecondBid() {
		String str = AUCTION_ITEM_NAME + "\n" + AUCTION_ITEM_DESCRIPTION + "\nHigh bid:\t" + SECOND_BID
				+ "\nHigh bidder:\t" + BIDDER2 + "\nTime Left:\t0 hours, 59 minutes\nEnds at:\t(current time + 1 hour) \n";
		System.out.println(str);
	}
	
	/**
	 * Display what the AuctionItem output should look like for constant values and zero days.
	 */
	public static void printExpectedAuctionItemExpired() {
		String str = AUCTION_ITEM_NAME + "\n" + AUCTION_ITEM_DESCRIPTION + "\nHigh bid:\t" + DEFAULT_HIGH_BID
				+ "\nHigh bidder:\t" + DEFAULT_HIGH_BIDDER + "\nTime Left:\t0 hours, 0 minutes\nEnds at:\t(current time) \n";
		System.out.println(str);
	}


	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// Create a sale item and send it messages
		System.out.println("**********************************************************************");
		System.out.println("SaleItem Tests");
		System.out.println("**********************************************************************\n");

		System.out.println("**********************************************************************");
		System.out.println("Test 1:  Create a sale item and test output.");
		System.out.println("Expected output:");
		printExpectedSaleItem();
		System.out.println("Actual output:");
		SaleItem shirt = new SaleItem(NAME, DESCRIPTION, PRICE, SHIPPING, NUM_IN_STOCK);
		System.out.println(shirt);
		System.out.println("**********************************************************************\n");
		
		System.out.println("**********************************************************************");
		System.out.println("Test 2:  Attempt to purchase more of the item than available.");
		System.out.println("Expected output: false / Failure");
		System.out.print("Actual output: ");
		if (shirt.purchase(NUM_IN_STOCK+1)) System.out.println("Success");
		else System.out.println("Failure");
		System.out.println("**********************************************************************\n");
		
		System.out.println("**********************************************************************");
		System.out.println("Test 3:  Attempt to purchase exact amount of the item available.");
		System.out.println("Expected output: true / Success");
		System.out.print("Actual output: ");		
		if (shirt.purchase(NUM_IN_STOCK)) System.out.println("Success");
		else System.out.println("Failure");
		System.out.println("**********************************************************************\n");
		
		System.out.println("**********************************************************************");
		System.out.println("Test 4:  Create a new sale item with same parameters, ");
		System.out.println("         and attempt to purchase less than amount available.");
		System.out.println("Expected output: true / Success");
		System.out.print("Actual output: ");		
		shirt = new SaleItem(NAME, DESCRIPTION, PRICE, SHIPPING, NUM_IN_STOCK);
		if (shirt.purchase(NUM_IN_STOCK-1)) System.out.println("Success");
		else System.out.println("Failure");
		System.out.println("**********************************************************************\n");
		
		System.out.println("**********************************************************************");
		System.out.println("Test 5:  Create a new sale item with same parameters, ");
		System.out.println("         and attempt to add to the stock, then attempt to");
		System.out.println("         remove full stock.");
		System.out.println("Expected output: true / Success");
		System.out.print("Actual output: ");		
		shirt = new SaleItem(NAME, DESCRIPTION, PRICE, SHIPPING, NUM_IN_STOCK);
		shirt.restock(NUM_IN_STOCK);
		if (shirt.purchase(NUM_IN_STOCK * 2)) System.out.println("Success");
		else System.out.println("Failure");
		System.out.println("**********************************************************************\n");
		
		
		System.out.println("**********************************************************************");
		System.out.println("Test 5:  Create a new sale item with same parameters, ");
		System.out.println("         and attempt to add to the stock, then attempt to");
		System.out.println("         remove full stock.");
		System.out.println("Expected output: true / Success");
		System.out.print("Actual output: ");		
		shirt = new SaleItem(NAME, DESCRIPTION, PRICE, SHIPPING, NUM_IN_STOCK);
		shirt.restock(NUM_IN_STOCK);
		if (shirt.purchase(NUM_IN_STOCK * 2)) System.out.println("Success");
		else System.out.println("Failure");
		System.out.println("**********************************************************************\n");

		
		System.out.println("**********************************************************************");
		System.out.println("AuctionItem Tests");
		System.out.println("**********************************************************************\n");
		System.out.println("(Note: durations might be off by nanoseconds, showing 1 hours 0 minutes");
		System.out.println("       instead of 0 hours, 59 minutes.)");

		
		System.out.println("**********************************************************************");
		System.out.println("Test 1:  Create an auction item active for 1 hour and view");
		System.out.println("Expected output: ");
		printExpectedAuctionItem();
		System.out.println("Actual output: ");		
		AuctionItem disneyPin = new AuctionItem(AUCTION_ITEM_NAME, AUCTION_ITEM_DESCRIPTION, 1);
		System.out.println(disneyPin);
		System.out.println("**********************************************************************\n");

		System.out.println("**********************************************************************");
		System.out.println("Test 2:  Bid on auction and view");
		System.out.println("Expected output: Success");
		printExpectedAuctionItemOneBid();
		System.out.print("Actual output: ");		
		if (disneyPin.bid(BID, BIDDER)) System.out.println("Success");
		else System.out.println("Failure");
		System.out.println(disneyPin);
		System.out.println("**********************************************************************\n");
		
		System.out.println("**********************************************************************");
		System.out.println("Test 3:  A bid at the current high bid");
		System.out.println("Expected output: Failure");
		printExpectedAuctionItemOneBid();
		System.out.print("Actual output: ");		
		if (disneyPin.bid(BID, BIDDER2)) System.out.println("Success");
		else System.out.println("Failure");
		System.out.println(disneyPin);
		System.out.println("**********************************************************************\n");
		
		System.out.println("**********************************************************************");
		System.out.println("Test 4:  A bid below the current high bid");
		System.out.println("Expected output: Failure");
		printExpectedAuctionItemOneBid();
		System.out.print("Actual output: ");		
		if (disneyPin.bid(BID-.5, BIDDER2)) System.out.println("Success");
		else System.out.println("Failure");
		System.out.println(disneyPin);
		System.out.println("**********************************************************************\n");
		
		System.out.println("**********************************************************************");
		System.out.println("Test 5:  A bid above the current high bid");
		System.out.println("Expected output: Success");
		printExpectedAuctionItemSecondBid();
		System.out.print("Actual output: ");		
		if (disneyPin.bid(SECOND_BID, BIDDER2)) System.out.println("Success");
		else System.out.println("Failure");
		System.out.println(disneyPin);
		System.out.println("**********************************************************************\n");
		
		System.out.println("**********************************************************************");
		System.out.println("Test 6:  Create an auction item active for 0 days and view");
		System.out.println("Expected output: ");
		printExpectedAuctionItemExpired();
		System.out.println("Actual output: ");		
		disneyPin = new AuctionItem(AUCTION_ITEM_NAME, AUCTION_ITEM_DESCRIPTION, 0);
		System.out.println(disneyPin);
		System.out.println("**********************************************************************\n");
		
		System.out.println("**********************************************************************");
		System.out.println("Test 7:  Attempt to bid on an inactive auction");
		System.out.println("Expected output: Failure");
		printExpectedAuctionItemExpired();
		System.out.print("Actual output: ");	
		if (disneyPin.bid(BID, BIDDER)) System.out.println("Success");
		else System.out.println("Failure");
		System.out.println(disneyPin);
		System.out.println("**********************************************************************\n");
	}

}
