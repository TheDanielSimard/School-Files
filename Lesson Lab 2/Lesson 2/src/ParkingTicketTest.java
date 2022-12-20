import java.util.Scanner;

public class ParkingTicketTest {

    public static void main(String[] arg) {
        Scanner input = new Scanner(System.in);         //Scanner class.

        ParkedCar car;                                  //Car being inspected by officer.
        PoliceOfficer officer;                          //Officer in charge of issuing tickets.
        ParkingMeter meter;                             //Time purchased on the meter.
        ParkingTicket ticket;                           //Ticket that will be given to illegally parked cars.

        int x = 0;                                      //Ability to end the loop.
        String name;									//Officer's name.
        String make;									//Car's make.
        String model;									//Car's model.
        String color;									//Car's color.
        String plate;									//Car's license plate number.
        int badgeNumber;								//Officer's badge number.
        int minutes;									//Minutes car is parked.
        int minutesPurchased;							//Minutes purchased.
        boolean carIsFined;                             //Whether the car is fined or not.

        while (x != -1)
        {
            //Prompt user for information regarding the officer
            System.out.print("Please enter the name of the officer: ");
            name = input.nextLine();

            System.out.print("Please enter the badge number of the officer: ");
            badgeNumber = Integer.parseInt(input.nextLine());

            //Create a PoliceOfficer object
            officer = new PoliceOfficer(name, badgeNumber);

            //Prompt user regarding the car being inspected
            System.out.print("Please select a vehicle make.\n" +
                    "1. Toyota\n" +
                    "2. Honda\n" +
                    "3. Volkswagen\n" +
                    "4. Audi\n" +
                    "Vehicle make: ");
            make = input.nextLine();

            System.out.print("Please enter the model of the vehicle: ");
            model = input.nextLine();

            System.out.print("Please enter the color of the vehicle: ");
            color = input.nextLine();

            System.out.print("Pleas enter the plate number of the vehicle: ");
            plate = input.nextLine();

            System.out.print("Please enter the number of minutes the car was parked: ");
            minutes = Integer.parseInt(input.nextLine());

            System.out.print("Please enter the number of minutes purchased: ");
            minutesPurchased = Integer.parseInt(input.nextLine());

            //Creates the ParkedCar and ParkingMeter objects associated to this police officer
            car = new ParkedCar(make, model, color, plate, minutes);
            car.setParkingMeter(minutesPurchased);

            carIsFined = officer.checkMeter(car);
            if(carIsFined)
            {
                ticket = new ParkingTicket(car, name, badgeNumber);
                System.out.println(ticket.toString());
            }
            else
            {
                int time = car.getParkingMeterTime() - car.getMinutes();
                System.out.print("The car is not in violation. It still has time remaining");
            }
            System.out.print("\nWould you like to inspect another car?\n(Yes/No): ");
            String answer = input.nextLine();
            x = answer.toUpperCase().equals("NO") ? -1 : 0;
        }
    }
}
