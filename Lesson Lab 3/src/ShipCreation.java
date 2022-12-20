import javax.swing.*;
import java.util.Random;

public class ShipCreation
{
    public static Ship createShip()
    {
        Ship ship;
        String name = JOptionPane.showInputDialog("Please enter the name of the ship?");
        String year = JOptionPane.showInputDialog("Please enter the year the ship was built?");
        ship = new Ship(name,year);
        return ship;
    }

    public static Ship createCruiseShip()
    {
        CruiseShip ship;
        String name = JOptionPane.showInputDialog("Please enter the name of the cruise ship?");
        String year = JOptionPane.showInputDialog("Please enter the year the cruise ship was built?");
        int maxCapacity = Integer.parseInt(JOptionPane.showInputDialog("Please enter the maximum capacity of the cruise ship?"));
        ship = new CruiseShip(maxCapacity,name,year);
        return ship;
    }

    public static Ship createCargoShip()
    {
        CargoShip ship;
        String name = JOptionPane.showInputDialog("Please enter the name of the cargo ship?");
        String year = JOptionPane.showInputDialog("Please enter the year the cargo ship was built?");
        int maxTonnage = Integer.parseInt(JOptionPane.showInputDialog("Please enter the maximum tonnage of the cargo ship?"));
        ship = new CargoShip(maxTonnage,name,year);
        return ship;
    }

    public static Ship createNavalShip()
    {
        NavalShip ship;
        String name = JOptionPane.showInputDialog("Please enter the name of the naval ship?");
        String year = JOptionPane.showInputDialog("Please enter the year the naval ship was built?");
        int Complement = Integer.parseInt(JOptionPane.showInputDialog("Please enter the complement total for the naval ship?"));
        ship = new NavalShip(Complement,name,year);
        return ship;
    }

    public static void main(String[] args)
    {
        Ship[] ships = new Ship[5];
        Random randNumbs = new Random();

        // Create five ships of random classes.
        for (int i=0; i<ships.length; i++){
            int num = randNumbs.nextInt(4);
            switch (num) {
                case 0:
                {ships[i]=createShip();
                    break;
                }
                case 1:
                {ships[i]=createCruiseShip();
                    break;
                }
                case 2:
                {ships[i]=createCargoShip();
                    break;
                }
                case 3:
                {ships[i]=createNavalShip();
                    break;
                }
            }
        }

        //Prints the ships.
        for (int i=0; i<ships.length; i++)
        {
            System.out.println(ships[i].toString());
        }

        //Prints the Saveable data for ships.
        for (int i=0; i<ships.length; i++)
        {
            System.out.println(ships[i].getSaveState());
        }
    }
}
