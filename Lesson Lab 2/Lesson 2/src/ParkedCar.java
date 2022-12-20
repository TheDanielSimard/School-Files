/**
 * Represents a parked car.
 * @author Daniel Simard
 */
public class ParkedCar
{
    private ParkingMeter meter;
    private enum Make { Toyota, Honda, Volkswagen, Audi, Unknown }
    private Make make = Make.Toyota;
    private String model;
    private String color;
    private String plateNumber;
    private int minutes;

    /**
     * ParkedCar class constructor.
     * @param _make	        The make of the car.
     * @param model		    The model of the car.
     * @param color		    The color of the car.
     * @param plateNumber	The car's license plate number.
     * @param minutes		Time car has been parked for.
     */
    public ParkedCar(String _make, String model, String color, String plateNumber, int minutes)
    {
        setMake(_make);
        this.model = model;
        this.color = color;
        this.plateNumber = plateNumber;
        this.minutes = minutes;
    }

    /**
     * Creates a parking meter object for a parked car.
     * @param minutes Amount of time bought in minutes.
     */
    public void setParkingMeter(int minutes) { meter = new ParkingMeter(minutes); }

    /**
     * Allows an officer to retrieve the purchased time on a meter.
     * @return Purchased time on the meter.
     */
    public int getParkingMeterTime() { return meter.getMinutes(); }

    /**
     * Sets the value of field _make.
     * @param _make The make of the care.
     */
    public void setMake(String _make)
    {
        switch (_make.toUpperCase())
        {
            case "TOYOTA":
                make = Make.Toyota;
                break;
            case "HONDA":
                make = Make.Honda;
                break;
            case "VOLKSWAGEN":
                make = Make.Volkswagen;
                break;
            case "AUDI":
                make = Make.Audi;
                break;
            default:
                make = Make.Unknown;
                break;
        }
    }

    /**
     * Sets value of field model to mod.
     * @param mod The model of the car.
     */
    public void setModel(String mod) { model = mod; }

    /**
     * Sets value of field color to col.
     * @param col The color of the car.
     */
    public void setColor(String col) { color = col; }

    /**
     * Sets the value of field plateNumber to plate.
     * @param plate Car's license plate number.
     */
    public void setPlateNumber(String plate) { plateNumber = plate; }

    /**
     * Sets the value of field minutes to min.
     * @param min Amount of minutes purchased.
     */
    public void setMinutes(int min) { minutes = min; }

    /**
     * getMake() returns the value of field make.
     * @return The make of the car.
     */
    public String getMake()
    {
        switch (make)
        {
            case Toyota:
                return "Toyota";
            case Honda:
                return "Honda";
            case Volkswagen:
                return "Volkswagen";
            case Audi:
                return "Audi";
            default:
                return "Unknown";
        }
    }
    /**
     * Returns the value of field model.
     * @return The model of the car.
     */
    public String getModel() { return model; }

    /**
     * Returns the value of field color.
     * @return The color of the car.
     */
    public String getColor() { return color; }

    /**
     * Returns the value of field license.
     * @return The car's license number.
     */
    public String getPlateNumber() { return plateNumber; }

    /**
     * Returns the value of field minutes
     * @return The amount of minutes purchased.
     */
    public int getMinutes() { return minutes; }

    /**
     * Returns a formatted string.
     * @return Formatted string.
     */
    public String toString()
    {
        return String.format("*** Car ***\nMake: %s\nModel: %s\nColor: %d\nPlate Number: %s\nMinutes Parked: %d",
                make, model, color, plateNumber, minutes);
    }
}
