/**
 * A secure bank account that will check for balance requests and amount withdrawn.
 *
 * @author Daniel Simard
 * @date November 10th, 2022
 */
public class SecureBankAccount
{
    /** Whether the account is accessible. Locked accounts are true. Unlocked accounts are false.*/
    private boolean locked;
    /** The current amount of money in the account.*/
    private double balance;
    /** Number of balance requests made.*/
    private int numBalanceRequests;
    /** Total amount of money withdrawn from the balance.*/
    private double amountWithdrawn;
    /** Maximum number of balance requests.*/
    private final int MAXIMUM_BALANCE_REQUESTS = 2;
    /** Maximum amount that can be withdrawn.*/
    private final double WITHDRAWAL_THRESHOLD = 500;

    //CONSTRUCTOR

    /**
     * Some args constructor initializing variables.
     * @param startingBalance The current amount of money that is in the account.
     */
    public SecureBankAccount(double startingBalance)
    {
        this.balance = startingBalance;
        this.locked = false;
        this.numBalanceRequests = 0;
        this.amountWithdrawn = 0;
    }

    //ACCESSOR

    /**
     * If the account no further action can be taken.
     * Obtains the balance of the account and increase balance requests by one if it is not locked.
     * If balance requests becomes 2 the account becomes locked.
     * @return -1 if the account is locked otherwise it returns the balance.
     */
    public double getBalance()
    {
        if (locked) return -1;
        else
        {
            numBalanceRequests += 1;

            if (numBalanceRequests == MAXIMUM_BALANCE_REQUESTS)
            {
                locked = true;
            }

            return this.balance;
        }
    }

    //OTHER METHODS

    /**
     * If balance passed in is negative then balance is set to zero.
     * Checks if the account is locked or if the amount attempting to be withdrawn exceeds 500.
     * If so reduces balance by amount and adds amount to amountWithdrawn.
     * If amountWithdrawn is greater or equal to 500, account becomes locked.
     * @param amount The amount being withdrawn.
     * @return if not locked returns balance otherwise -1.
     */
    public double withdraw(double amount)
    {
        if (balance < 0) balance = 0;

        if (!locked && amount <= balance)
        {
            balance -= amount;
            amountWithdrawn += amount;

            if (amountWithdrawn >= WITHDRAWAL_THRESHOLD)
            {
                locked = true;
            }

            return balance;
        }
        else return -1;
    }

    /**
     * If balance passed in is negative then balance is set to zero.
     * Checks if the account is locked.
     * If not then the amount is added to the balance.
     * @param amount The amount being deposited.
     * @return if not locked returns balance otherwise -1
     */
    public double deposit(double amount)
    {
        if (balance < 0) balance = 0;

        if (!locked)
        {
            balance += amount;
            return balance;
        }
        else return -1;
    }

    /**
     * Resets an accounts locked state, balance requests and amount withdrawn.
     * @return true if account was locked otherwise false.
     */
    public boolean reset()
    {
        if (locked)
        {
            locked = false;
            numBalanceRequests = 0;
            amountWithdrawn = 0;
            return true;
        }
        else return false;
    }
}
