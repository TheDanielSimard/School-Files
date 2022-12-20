/**
 * Represents a police officer and generate ticket details.
 * @author Daniel Simard
 */
public class PoliceOfficer
{
    private ParkedCar illegalCar;
    private String name;
    private int badge;

    /**
     * PoliceOfficer class constructor.
     * @param name	The officer's name.
     * @param badge	The officer's badge number.
     */
    public PoliceOfficer(String name, int badge)
    {
        this.name = name;
        this.badge = badge;
    }

    /**
     * PoliceOfficer class constructor.
     * @param _name	    The officer's name.
     * @param _badge	The officer's badge number.
     * @param car 		The car being inspected.
     */
    public PoliceOfficer(String _name, int _badge, ParkedCar car)
    {
        name = _name;
        badge = _badge;
        illegalCar = car;
    }

    /**
     * Compares the time purchased on the meter to how long the car has been parked for.
     * If the car has been parked longer then it paid for a fine is generated.
     * @param car The car that is being inspected by the officer.
     */
    public boolean checkMeter(ParkedCar car)
    {
        if(car.getMinutes() > car.getParkingMeterTime())
        {
            return true;
        }
        else
            return false;
    }

    /**
     * Sets the value of illegalCar to the object car.
     * @param car The car being inspected.
     */
    public void setCar(ParkedCar car) { illegalCar = car; }

    /**
     * Sets the value of field name to _name.
     * @param _name The officer's name.
     */
    public void setName(String _name) {	name = _name; }

    /**
     * Sets the value of field badge to _badge.
     * @param _badge The officer's badge number.
     */
    public void setBadge(int _badge) { badge = _badge; }

    /**
     * Returns the object illegalCar.
     * @return The car being inspected.
     */
    public ParkedCar getCar() { return illegalCar; }

    /**
     * Returns the value of field name.
     * @return The officer's name.
     */
    public String getName() { return name; }

    /**
     * Returns the value of field badge.
     * @return The officer's badge number.
     */
    public int getBadge() { return badge; }

    /**
     * Returns a formatted string of the officer's name and badge number.
     * @return Formatted string.
     */
    public String toString()
    {
        return String.format("Name: %s\nBadge: %d", name, badge);
    }
}
