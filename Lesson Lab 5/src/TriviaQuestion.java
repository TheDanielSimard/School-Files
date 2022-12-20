/**
    A Simple Trivia Question class.
	@author Maggie
	5-13-2020
*/

public class TriviaQuestion {
	

	// Fields representing the question and whether it has been posed.
	private String question;
	private String answer1, answer2, answer3, answer4;
	private int correctAnswer, points;
	private boolean posed;
	
	
	// Constructors
	/**
	 * Initialize a TriviaQuestion object with default values.
	 */
	public TriviaQuestion() {
		this.question = "What is the first letter of the alphabet? ";
		this.answer1 = "J";
		this.answer2 = "Z";
		this.answer3 = "M";
		this.answer4 = "A";
		this.correctAnswer = 4;
		this.points = 10;
		this.posed = false;
	}
	
	/**
	 * Initialize a TriviaQuestion object from parameters.
	 * @param question The question.
	 * @param answer1 The first answer option.
	 * @param answer2 The second answer option.
	 * @param answer3 The third answer option.
	 * @param answer4 The fourth answer option.
	 * @param correct The number of the correct answer.
	 * @param points The number of points the question is worth.
	 */
	public TriviaQuestion(String question, String answer1, String answer2, String answer3, String answer4, int correct, int points) {
		this.question = question;
		this.answer1 = answer1;
		this.answer2 = answer2;
		this.answer3 = answer3;
		this.answer4 = answer4;
		this.correctAnswer = correct;
		this.points = points;
		this.posed = false;
	}
	
	// Accessors
	/**
	 * Calculate points based on correctness of answer.
	 * @param ans Answer to compare to correct answer.
	 * @return The number of points received.
	 */
	public double getScore(int ans) {
		double score = 0;
		if (ans == this.correctAnswer && this.posed) {
			score = this.points;
		}
		return score;
	}
	
	/**
	 * Create and return a string to pose the question.
	 * @return The string reprsentation of the question.
	 */
	public String poseQuestion() {
		this.posed = true;
		String answers = "1) " + this.answer1 + "\n2) " + this.answer2 + "\n3) " + this.answer3 + "\n4) " + this.answer4 + "\n";
		return this.question + "\n" + answers;
	}

	
	// Mutators
	/**
	 * Change the question text if the question has not already been posed.
	 * @param question The new question.
	 */
	public void setQuestion(String question) {
		if (!this.posed)
			this.question = question;
	}
	
	/**
	 * Change answer 1 text if the question has not already been posed.
	 * @param answer The new answer1 text.
	 */
	public void setAnswer1(String answer) {
		if (!this.posed)
			this.answer1 = answer;
	}

	/**
	 * Change answer 2 text if the question has not already been posed.
	 * @param answer The new answer2 text.
	 */
	public void setAnswer2(String answer) {
		if (!this.posed)
			this.answer2 = answer;
	}

	/**
	 * Change answer 3 text if the question has not already been posed.
	 * @param answer The new answer3 text.
	 */
	public void setAnswer3(String answer) {
		if (!this.posed)
			this.answer3 = answer;
	}

	/**
	 * Change answer 4 text if the question has not already been posed.
	 * @param answer The new answer4 text.
	 */
	public void setAnswer4(String answer) {
		if (!this.posed)
			this.answer4 = answer;
	}

	/**
	 * Change the number of points if the question has not already been posed.
	 * @param answer The new point value.
	 */
	public void setPoints(int answer) {
		if (!this.posed)
			this.points = answer;
	}
	

	
}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	