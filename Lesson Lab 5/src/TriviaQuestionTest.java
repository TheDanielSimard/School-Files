/**
 * This class tests functionality of each method located in the TriviaQuestion class.
 *
 * @author Daniel Simard
 * @date 06 November 2022
 */

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

class TriviaQuestionTest
{
    private TriviaQuestion question;

    @BeforeEach
    void setUp() throws Exception
    {
        //Runs before each @Test method.
        question = new TriviaQuestion("Q", "A1", "A2", "A3", "A4", 4, 10);
    }

    @Test
    void MethodsTest()
    {
        //Question not instantiated, default values.
        String questionText;
        question.setPoints(100);
        question.setQuestion("Test Question");
        question.setAnswer1("Test Answer 1");
        question.setAnswer2("Test Answer 2");
        question.setAnswer3("Test Answer 3");
        question.setAnswer4("Test Answer 4");

        //Question not instantiated, right and wrong answer results in zero points.
        assertEquals(question.getScore(4), 0);
        assertEquals(question.getScore(1), 0);

        //Confirm fields were all changed.
        questionText = question.poseQuestion();
        assertEquals(questionText, "Test Question\n1) Test Answer 1\n2) Test Answer 2\n3) Test Answer 3\n4) Test Answer 4\n");
        assertEquals(question.getScore(4), 100);
        assertEquals(question.getScore(5), 0);

        //Question instantiated, fields cannot be changed.
        question.setPoints(200);
        question.setQuestion("Test2 Question");
        question.setAnswer1("Test2 Answer 1");
        question.setAnswer2("Test2 Answer 2");
        question.setAnswer3("Test2 Answer 3");
        question.setAnswer4("Test2 Answer 4");
        questionText = question.poseQuestion();
        assertEquals(questionText, "Test Question\n1) Test Answer 1\n2) Test Answer 2\n3) Test Answer 3\n4) Test Answer 4\n");
        assertEquals(question.getScore(4), 100);
    }

    @Test
    void ConstructorTest()
    {
        //Confirm question has original values assigned by constructor.
        String questionText;
        questionText = question.poseQuestion();
        assertEquals(questionText, "Q\n1) A1\n2) A2\n3) A3\n4) A4\n");
        assertEquals(question.getScore(4), 10);
    }
}