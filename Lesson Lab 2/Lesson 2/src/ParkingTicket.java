/**
 * Represents a parking ticket.
 * @author Daniel Simard
 */
public class ParkingTicket
{
    private static int numTickets = 0;
    private ParkedCar car;
    private double fine;
    private String officerName;
    private int badgeNumber;
    private int baseDiff;

    /**
     * ParkingTicket class constructor.
     * @param car 		        The car that is being fined.
     * @param officerName 		The officer's name.
     * @param badgeNumber 	    The officer's badge number.
     */
    public ParkingTicket(ParkedCar car, String officerName, int badgeNumber)
    {
        this.car = car;
        this.officerName = officerName;
        this.badgeNumber = badgeNumber;
        fine = 25.0;
    }

    /**
     * Calculates the fine amount based on how long the car has been parked for.
     */
    public void calculateFine()
    {
        int difference = car.getMinutes() - car.getParkingMeterTime();
        baseDiff = difference;

        while(difference - 60 > 0)
        {
            fine += 10.0;
            difference -= 60;
        }

    }

    /**
     * Sets the value of field car to the object car.
     * @param car The parked car.
     */
    public void setParkedCar(ParkedCar car){ this.car = car; }

    /**
     * Sets the value of field officerName to name.
     * @param name The officer's name.
     */
    public void setOfficerName(String name) { officerName = name; }

    /**
     * Sets the value of the field badgeNumber to badge.
     * @param badge
     */
    public void setBadgeNumber(int badge) { badgeNumber = badge; }

    /**
     * Returns a formatted String
     * @return Formatted string of the ticket written
     */
    public String toString()
    {
        calculateFine();
        numTickets++;

        return String.format("\t   Ticket #%d\n" +
                        "Officer Name: %s\n" +
                        "Officer Badge: %s\n" +
                        "--------------------------\n" +
                        "\t    Car\n" +
                        "Make: %s\nModel: %s\n" +
                        "Color: %s\nPlate Number: %s\n\n" +
                        "Time Purchased: %d:%02d\n" +
                        "Overtime: %d:%02d\n" +
                        "--------------------------\n" +
                        "Fine Amount: $%,.2f", numTickets, officerName, badgeNumber, car.getMake(),
                car.getModel(), car.getColor(), car.getPlateNumber(),
                car.getParkingMeterTime() / 60, (car.getParkingMeterTime() - ((car.getParkingMeterTime() / 60) * 60)),
                baseDiff / 60, (baseDiff - ((baseDiff / 60) * 60)), fine);
    }
}