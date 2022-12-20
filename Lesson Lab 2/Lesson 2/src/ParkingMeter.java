/**
 * Represents a parking meter.
 * @author Daniel Simard
 */
public class ParkingMeter
{
    private int minutesPurchased;

    /**
     * ParkingMeter class constructor.
     * @param minutes The amount of minutes purchased.
     */
    public ParkingMeter(int minutes)
    {
        minutesPurchased = minutes;
    }

    /**
     * Sets the value of field minutesPurchased to minutes.
     * @param minutes Amount of time purchased.
     */
    public void setMinutes(int minutes) { minutesPurchased = minutes; }

    /**
     * Returns the amount of time purchased in minutes.
     * @return Minutes purchased.
     */
    public int getMinutes() { return minutesPurchased; }

    /**
     * Returns a formatted string.
     * @return Formatted string.
     */
    public String toString()
    {
        return String.format("Minutes purchase: %d", minutesPurchased);
    }
}
