/**
 * A subclass of Ship representing a naval ship.
 * @author Daniel Simard
 * October 6th 2022
 */
public class NavalShip extends Ship
{
    private int complement; //Amount of crew members aboard the ship.

    /**
     * Initializing former parameters.
     * @param complement Amount of crew members aboard the ship.
     * @param name Name of the ship.
     * @param year Year the ship was built.
     */
    public NavalShip(int complement, String name, String year){
        super(name, year);
        this.complement = complement;
    }

    /**
     * Gets the number of crew members.
     * @return the amount of crew.
     */
    public int getComplement()
    {
        return complement;
    }

    /**
     * Sets the number of crew to the parameter.
     * @param complement the amount of crew.
     */
    public void setComplement(int complement)
    {
        this.complement = complement;
    }

    /**
     * Returns a string of a naval ships description
     * @return a string of the naval ship's data.
     */
    public String toString() {
        String str = super.toString() + "\nShips Complement: " + complement;
        return str;
    }

    /**
     * Returns a String of the object's current state.
     * @return Object's state.
     */
    public String getSaveState()
    {
        String str = "Naval" + super.getSaveState() + "#" + complement;
        return str;
    }
}
