/**
 * A subclass of Ship representing a cargo ship.
 * @author Daniel Simard
 * October 6th 2022
 */
public class CargoShip extends Ship
{
    private int cargoTonnage; //Maximum tonnage of the cargo ship.

    /**
     * Initializing former parameters.
     * @param cargoTonnage Maximum tonnage of the cargo ship.
     * @param name Name of the ship.
     * @param year Year the ship was built.
     */
    public CargoShip(int cargoTonnage, String name, String year){
        super(name, year);
        this.cargoTonnage = cargoTonnage;
    }

    /**
     * Gets the maximum tonnage of the ship.
     * @return the maximum tonnage.
     */
    public int getCargoTonnage() {
        return cargoTonnage;
    }

    /**
     * Sets the maximum tonnage to the parameter.
     * @param cargoTonnage the maximum tonnage.
     */
    public void setCargoTonnage(int cargoTonnage){
        this.cargoTonnage = cargoTonnage;
    }

    /**
     * Returns a string of a cargo ships description
     * @return a string of the cargo ship's data.
     */
    public String toString() {
        String str = super.toString() + "\nCargo capacity: " + cargoTonnage;
        return str;
    }

    /**
     * Returns a String of the object's current state.
     * @return Object's state.
     */
    public String getSaveState()
    {
        String str = "Cargo" + super.getSaveState() + "#" + cargoTonnage;
        return str;
    }
}
