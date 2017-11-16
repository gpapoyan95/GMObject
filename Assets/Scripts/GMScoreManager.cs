using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GMScoreManager : GMObject {

	public Text ScoreText;
	private static int _score;
	private static int _highScore;
	
	/*
	 *	Score increasing for one point 
	 */

	public void ScoreIncrease() {
		_score++;
		CheckHighScore(_score);
	} 

	
	/*
	 *	Returns current high score 
	 */

	public int GetCurrentHighScore() {
		var highScore = PlayerPrefs.GetInt("highScore", _highScore);
		log("HighScore: " + highScore);
		return highScore;
	}
	
	/*
	 *	Set current high score
	 */

	public void SetCurrentHighScore(int newHighScore) {
		_highScore = newHighScore;
		log("CurrentScore set to " + _highScore);
		PlayerPrefs.SetInt("highScore", _highScore);
	}

	/*
	 * 	Set current Score
	 */
	
	public void SetCurrentScore(int newScore) {
		_score = newScore;
		log("score: " + _score);
	}
	
	/*
	 * 	This method checking if your score is higher than highscore and changing Player pref of highscore
	 */

	private void CheckHighScore(int currentScore) {
		if (currentScore <= GetCurrentHighScore()) return;
		_highScore = currentScore;
		PlayerPrefs.SetInt("HighScore", _highScore);
	}
	
}
