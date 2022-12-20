/**
 * This class encapsulates properties and operations for items of an inventory context.
 * Author: Daniel Simard
 * Date: October 1st, 2022
 */
public class InventoryItem
{
    private String name;            //Inventory Item Name.
    private String description;     //Inventory Item Description.
    private String itemNumber;      //Inventory Item Number.
    private int quantity;           //Inventory Item Quantity.

    /**
     * Constructor that intakes the parameters of an inventory item.
     * @param name The Inventory Item Name.
     * @param description The Inventory Item Description.
     * @param itemNumber The Inventory Item Number.
     * @param quantity The Inventory Item Quantity.
     */
    public InventoryItem(String name, String description, String itemNumber, int quantity)
    {
        this.name = name;
        this.description = description;
        this.itemNumber = itemNumber;
        this.quantity = quantity;
    }

    /**
     * Increases the quantity by the value of amount.
     * @param amount contains the value being added.
     */
    public void addStock(int amount)
    {
        //Only change the quantity if the amount being added is greater than zero.
        if (amount >= 0)
        {
            this.quantity += amount;
        }
    }

    /**
     * Checks the new quantity before applying the change.
     * @param amount contains the value being removed.
     * @return true if the quantity remains greater than or equal to zero.
     * false if the quantity is less than zero.
     */
    public boolean removeStock(int amount)
    {
        //Declaring the new quantity.
        var quantityUpdate = this.quantity - amount;

        //If the new quantity is less than zero return false.
        if (quantityUpdate >= 0)
        {
            //Updating the quantity value.
            this.quantity = quantityUpdate;
        }

        return this.quantity == quantityUpdate;
    }

    /**
     * Item number getter.
     * @return the item number.
     */
    public String getItemNumber()
    {
        return this.itemNumber;
    }

    /**
     * Instance information.
     * @return instance information.
     */
    public String toString()
    {
        var nameLabel = "Name";
        var descriptionLabel = "Description";
        var itemNumberLabel = "Item#";
        var quantityLabel = "Quantity";

        var str = new StringBuilder();

        str.append(String.format("%s:%s%s\n", nameLabel, new String(new char[19 - nameLabel.length()]).replace('\0', ' '), this.name));
        str.append(String.format("%s:%s%s\n", descriptionLabel, new String(new char[19 - descriptionLabel.length()]).replace('\0', ' '), this.description));
        str.append(String.format("%s:%s%s\n", itemNumberLabel, new String(new char[19 - itemNumberLabel.length()]).replace('\0', ' '), this.itemNumber));
        str.append(String.format("%s:%s%s\n", quantityLabel, new String(new char[19 - quantityLabel.length()]).replace('\0', ' '), this.quantity));

        return str.toString();
    }
}
