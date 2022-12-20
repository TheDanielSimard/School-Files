/**
 * SaleItem inherits Item object and enhances it.
 * @author Daniel Simard
 * @date October 16th 2020
 **/
public class SaleItem extends Item
{
    private double price;           //Price of the item.
    private double shippingCost;    //Cost of shipping the item.
    private int numItemStock;       //Number of the item in stock.

    //CONSTRUCTORS

    /**
     * Constructor that takes values as parameters for all fields of the object.
     * @param name Name of the item.
     * @param description Description of the item.
     * @param price Price of the item.
     * @param shippingCost Cost of shipping the item.
     * @param numItemStock Number of the item in stock.
     */
    public SaleItem(String name, String description, double price, double shippingCost, int numItemStock)
    {
        super(name, description);
        this.price = price;
        this.shippingCost = shippingCost;
        this.numItemStock = numItemStock;
    }

    /**
     * Copy constructor that takes a SaleItem object as a parameter and copies the fields to this.
     * @param saleItem SaleItem object to be copied to this.
     */
    public SaleItem(SaleItem saleItem)
    {
        super(saleItem.getName(), saleItem.getDescription());
        this.price = saleItem.getPrice();
        this.shippingCost = saleItem.getShippingCost();
        this.numItemStock = saleItem.numItemStock;
    }

    //ACCESSORS

    /**
     * Returns the value stored in the price field.
     * @return the price of the item.
     */
    public double getPrice()
    {
        return this.price;
    }

    /**
     * Returns the value stored in the shipping cost field.
     * @return the cost of shipping the item.
     */
    public double getShippingCost()
    {
        return this.shippingCost;
    }

    //OTHER METHODS

    /**
     * Deducts items from stock if possible.
     * @param quantity being added or reduced.
     * @return whether the method is possible.
     */
    public boolean purchase(int quantity)
    {
        if (numItemStock >= quantity)
        {
            numItemStock -= quantity;
            return true;
        }
        else
        {
            return false;
        }
    }

    /**
     * Adding items to stock.
     * @param quantity being added or reduced.
     */
    public void restock(int quantity)
    {
        numItemStock += quantity;
    }

    /**
     * Returns a String representing the data of the object.
     * @return String with name, description, price and shipping on separate lines.
     */
    public String toString()
    {
        return  super.toString()
                + "\nPrice:\t$" + this.price
                + "\nShipping:\t$" + this.shippingCost;
    }
}
