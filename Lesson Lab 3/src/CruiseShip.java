/**
 * A subclass of Ship representing a cruise ship.
 * @author Daniel Simard
 * October 6th 2022
 */
public class CruiseShip extends Ship
{
    private int maxPassengers; //Maximum amount of passengers on the ship.

    /**
     * Initializing former parameters.
     * @param maxPassengers Maximum amount of passengers on the ship.
     * @param name Name of the ship.
     * @param year Year the ship was built.
     */
    public CruiseShip(int maxPassengers, String name, String year)
    {
        super(name, year);
        this.maxPassengers = maxPassengers;
    }

    /**
     * Gets the maximum number of passengers.
     * @return the maximum number of passengers.
     */
    public int getMaxPassengers()
    {
        return maxPassengers;
    }

    /**
     * Sets the maximum number of passengers to the parameter.
     * @param maxPassengers the maximum number of passengers.
     */
    public void setMaxPassengers(int maxPassengers)
    {
        this.maxPassengers = maxPassengers;
    }

    /**
     * Returns a string of a cruise ships description
     * @return a string of the cruise ship's data.
     */
    public String toString()
    {
        String str = super.toString() + "\nMax passengers: " + maxPassengers;
        return str;
    }

    /**
     * Returns a String of the object's current state.
     * @return Object's state.
     */
    public String getSaveState()
    {
        String str = "Cruise" + super.getSaveState() + "#" + maxPassengers;
        return str;
    }
}
