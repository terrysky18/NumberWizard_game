using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	// Use this for initialisation
	int max;
	int min;
	int guess;
	
	// maximum guesses granted
	int maxGuessesAllowed;
	
	public Text textGuess;
	public Text textTrial;

	void Start () {
		StartGame();
	}
	
	void StartGame() {
		max = 1000;
		min = 1;
		guess = 500;
		maxGuessesAllowed = 10;

		// Unity round down, max needs 1 increment for upper edge case
		max++;
	}

	// Update is called once per frame

	public void GuessHigher() {
		// public function can be accessed by the game
		min = guess;
		NewGuess();
	}
	
	public void GuessLower() {
		max = guess;
		NewGuess();
	}

	// Computes guess at each user response
	void NewGuess() {
		guess = (max + min) / 2;
		textGuess.text = guess.ToString();
		// reduce the number of allowed guesses
		maxGuessesAllowed--;
		textTrial.text = maxGuessesAllowed.ToString();
		
		// allowed guesses is out
		if (maxGuessesAllowed <= 0) {
			// player has won
			Application.LoadLevel("Win");
		}
	}
}
