/**
 * A testing class for a secure bank account that will check for balance requests and amount withdrawn.
 *
 * @author Daniel Simard
 * @date November 10th, 2022
 */
import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

public class SecureBankAccountTesting
{
    /** Value for testing a thousand.*/
    private final double THOUSAND_AMOUNT = 1000;
    /** Value for testing a hundred.*/
    private final double HUNDRED_AMOUNT = 100;
    /** Value for testing a negative hundred.*/
    private final double NEGATIVE_HUNDRED_AMOUNT = -100;
    /** Value for testing negative one or failure.*/
    private final double FAILURE = -1;
    /** Testing variable starting with a balance of a thousand.*/
    SecureBankAccount positiveAccount;
    /** Testing variable starting with a balance of negative one hundred.*/
    SecureBankAccount negativeAccount;

    /**
     * Runs before each @Test method takes place.
     * @throws Exception
     */
    @BeforeEach
    void setUp() throws Exception
    {
        positiveAccount = new SecureBankAccount(THOUSAND_AMOUNT);
        negativeAccount = new SecureBankAccount(NEGATIVE_HUNDRED_AMOUNT);
    }

    /**
     * When the getBalance message is sent, the object checks to see if it is locked. If it is locked, it returns -1. If
     * it is not locked, it returns the balance. It increments the number of balance requests if it is not locked. If
     * the number of balance requests is 2, locked is set to true
     */
    @Test
    void getBalanceTest()
    {
        //Obtains the balance of the account since account should be unlocked after 1 attempt.
        assertEquals(positiveAccount.getBalance(), THOUSAND_AMOUNT);

        //Obtains the balance of the account since account should be unlocked after 2 attempts.
        assertEquals(positiveAccount.getBalance(), THOUSAND_AMOUNT);

        //Should not be able to obtain the balance of the account since it should lock after 3 attempts.
        assertEquals(positiveAccount.getBalance(), FAILURE);
    }

    /**
     * When the with draw message is sent, the object checks to see if it is locked. It checks to see if the balance is
     * high enough to cover the withdrawal. If both conditions are met, the amount to withdraw is subtracted
     * from the balance, added to the amountWithdrawn, and returned from the method. If the conditions are
     * not met, -1 is returned from the method and no changes are made to the state of the object. If money was
     * successfully withdrawn, then the value of amountWithdrawn is checked against 500. If it meets or exceeds
     * 500, locked is set to true.
     */
    @Test
    void withdrawTest()
    {
        //Checks if the amount withdrawn is removed from the balance.
        assertEquals(positiveAccount.withdraw(HUNDRED_AMOUNT), THOUSAND_AMOUNT - HUNDRED_AMOUNT);

        //Checks if a negative balance is zero when a negative number is the balance.
        assertEquals(negativeAccount.withdraw(0), 0);

        //Checks if withdrawing a balance greater than what is in the account results in failure.
        assertEquals(negativeAccount.withdraw(HUNDRED_AMOUNT), FAILURE);

        //Checks if withdrawn amount is greater than the withdrawal threshold.
        //If greater, the account is locked and is not accessible, resulting in failure.
        positiveAccount.withdraw(HUNDRED_AMOUNT * 5);
        assertEquals(positiveAccount.withdraw(HUNDRED_AMOUNT), FAILURE);
    }

    /**
     * With the deposit message is sent, the object checks to see if it is locked. If it is not, the amount passed is
     * added to the balance and is returned from the method. If it is locked, then -1 is returned from the method
     * and no changes are made to the balance.
     */
    @Test
    void depositTest()
    {
        //Checks if the amount deposited is added to the balance.
        assertEquals(positiveAccount.deposit(HUNDRED_AMOUNT), THOUSAND_AMOUNT + HUNDRED_AMOUNT);

        //Checks if a negative balance is zero when a negative number is the balance.
        //Depositing one hundred into a balance of zero should result in one hundred.
        assertEquals(negativeAccount.deposit(HUNDRED_AMOUNT), HUNDRED_AMOUNT);

        //Locking the account. Setting account value to one hundred.
        positiveAccount.withdraw(THOUSAND_AMOUNT);

        //Checks if locked account deposit results in failure.
        assertEquals(positiveAccount.deposit(HUNDRED_AMOUNT), FAILURE);
    }

    /**
     * When the reset message is sent, the object checks to see if it is locked. If it is, it is unlocked (locked set to
     * false), and numbalanceRequests and amountWithdrawn are each reset to zero. It returns true. If it is not
     * locked, no changes are made to the state of the object, and it returns false.
     */
    @Test
    void resetTest()
    {
        //Should return false if account is not locked.
        assertFalse(positiveAccount.reset());

        //Locking the account.
        positiveAccount.withdraw(THOUSAND_AMOUNT);

        //Checks if the reset method unlocks the account. If unlocked a deposit can be made.
        assertTrue(positiveAccount.reset());

        //Testing if account is unlocked for a deposit to be made.
        assertEquals(positiveAccount.deposit(HUNDRED_AMOUNT), HUNDRED_AMOUNT);
    }
}
