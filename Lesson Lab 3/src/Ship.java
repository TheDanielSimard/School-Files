/**
 * A class representing a ship.
 * @author Daniel Simard
 * October 6th 2022
 */
public class Ship
{
    private String name; //Name of the ship.
    private String year; //Year the ship was built.

    /**
     * Constructor that initializes fields from parameters.
     * @param name Name of the ship.
     * @param year Year the ship was built.
     */
    public Ship(String name, String year)
    {
        this.name = name;
        this.year = year;
    }

    /**
     * Gets the value of the ships name.
     * @return the ships name.
     */
    public String getName()
    {
        return name;
    }

    /**
     * Gets the value of the ships age.
     * @return the ships age.
     */
    public String getYear()
    {
        return year;
    }

    /**
     * Sets the ships name to the parameter.
     * @param name The ships new name value.
     */
    public void setName(String name)
    {
        this.name = name;
    }

    /**
     * Sets the ships age to the parameter.
     * @param year The ships new year value.
     */
    public void setYear(String year)
    {
        this.year = year;
    }

    /**
     * Returns a string of a ships description
     * @return a string of the ship's data.
     */
    public String toString()
    {
        String str = "Ship's name: " + name + "\nYear built: " + year;
        return str;
    }

    /**
     * Returns a String of the object's current state.
     * @return Object's state.
     */
    public String getSaveState()
    {
        String str = "Ship" + "#" + name + "#" + year;
        return str;
    }
}
