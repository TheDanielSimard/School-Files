/**
 * Item is an abstract base class for all items for sale.
 *
 *@author Maggie
**/


public class Item {
	
	//Fields:
	private String name;			//the name of the item
	private String description;		//the person's address
	
	//Methods:
	//CONSTRUCTORS
	/**
	 * Item, constructor that takes arguments for all fields
	 * @param name -- String, name of the item
	 * @param description -- String, description of the item
	 */
	public Item(String name, String description){
		this.name = name;
		this.description = description;
	}
	
	/**
	 * Item, copy constructor
	 * @param toCopy -- an Item object to copy into the current object
	 */
	public Item(Item toCopy){
		this.name = toCopy.name;
		this.description = toCopy.description;
	}
	
	//ACCESSORS
	
	/**
	 * getName
	 * @return name of the item, String
	 */
	public String getName(){
		return this.name;
	}
	
	/**
	 * getDescription
	 * @return description of the item, String
	 */
	public String getDescription(){
		return this.description;
	}	
	
	/**
	 * toString, return a String representing the data of the object.
	 * @return String with name and description on separate lines.
	 */
	public String toString(){
		return this.name + "\n" + this.description;
	}
}
