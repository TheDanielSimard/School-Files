import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;

public class JUnitTesting
{
    private final String[] arrayA = { "FD", "HS", "FD", "ET", "DF", "LH", "RT", "TT", "FT" };
    private final String[] arrayB = { "fD", "HS", "FD", "Et", "FD", "LH", "TT", "RT", "FT" };
    private final String[] arrayC = { "FD", "aS", "Fd", "TE", "DD", "LH", "TT", "RT", "aT" };
    private final String[] arrayD = { "FD", "HS" };
    private final String[] arrayE = { "fD", "Hs" };

    @Test
    void Functionality()
    {
        int index = 0;

        //Confirming that none of the arrays are equal.
        assertNotEquals(arrayA, arrayB);
        assertNotEquals(arrayB, arrayC);
        assertNotEquals(arrayA, arrayC);

        //Assuming case sensitivity is important arrays are not equal.
        assertNotEquals(arrayD, arrayE);
        assertEquals(2, ArrayComparison.NumberOfMismatches(arrayD, arrayE, index));

        //Catching the number of mismatching elements between the arrays.
        assertEquals(5, ArrayComparison.NumberOfMismatches(arrayA, arrayB, index));
        assertEquals(6, ArrayComparison.NumberOfMismatches(arrayB, arrayC, index));
        assertEquals(7, ArrayComparison.NumberOfMismatches(arrayA, arrayC, index));
    }
}
