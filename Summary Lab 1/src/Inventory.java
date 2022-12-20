/**
 * This class is a repository for inventory items and performs inventory operations.
 * Author: Daniel Simard
 * Date: October 1st, 2022
 */
import java.util.ArrayList;
import java.util.stream.*;

public class Inventory
{
    private String name;                            //Inventory Name.
    private ArrayList<InventoryItem> itemsArray;    //Inventory ArrayList.

    /**
     * Constructor that intakes the parameters of inventory.
     * @param name name of the inventory.
     */
    public Inventory(String name)
    {
        this.name = name;
        this.itemsArray = new ArrayList<>();
    }

    /**
     * Retrieves the InventoryItem from the collection of InventoryItems,
     * then increases the quantity by the value of amount.
     * @param itemNumber the value that keeps track of inventory.
     * @param amount the amount being added.
     */
    public void addStock(String itemNumber, int amount)
    {
        //Find the first item that matches the item number in its properties and provide null if it is not found.
        var itemResult = itemsArray.stream().filter(item->item.getItemNumber().equals(itemNumber));
        var array = itemResult.toArray(InventoryItem[]::new);

        if (array.length != 0)
        {
            //Add stock to the inventory item.
            array[0].addStock(amount);
        }
    }

    /**
     * Removes stock from collection of inventory items by the itemNumber.
     * @param itemNumber the value that keeps track of inventory.
     * @param amount the amount being removed.
     * @return true if the operation successfully removes stock from an item.
     * false if the item does not exist or there is no more stock to remove.
     */
    public boolean removeStock(String itemNumber, int amount)
    {
        //Find the first item that matches the item number in its properties and provide null if it is not found.
        var itemResult = itemsArray.stream().filter(item->item.getItemNumber().equals(itemNumber)).findFirst().orElse(null);

        // Attempting to remove a quantity from the stock. If the item does not exist, return false.
        return itemResult != null && itemResult.removeStock(amount);
    }

    /**
     * Instantiates an InventoryItem object from the arguments provided,
     * then adds the new instance to the collection of InventoryItems.
     * @param itemNumber contains the number value.
     * @param itemName contains the name value.
     * @param itemDescription contains the description value.
     * @param itemQuantity contains the quantity value.
     */
    public void addItem(String itemNumber, String itemName, String itemDescription, int itemQuantity)
    {
        var item = new InventoryItem(itemName, itemDescription, itemNumber, itemQuantity);
        itemsArray.add(item);
    }

    /**
     * Instance information.
     * @return instance information.
     */
    public String toString()
    {
        var inventoryLabel = "Inventory";

        var str = new StringBuilder();

        str.append(String.format("%s:%s%s\n", inventoryLabel, new String(new char[19 - inventoryLabel.length()]).replace('\0', ' '), this.name));

        for (var item: itemsArray)
        {
            str.append(item.toString());
        }

        return str.toString();
    }
}
