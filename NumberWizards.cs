using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NumberWizards : MonoBehaviour {
    int max;
    int min;
    int guess;
    int maxGuessesAllowed = 8;


    public Text text;

    // Use this for initialization
    void Start () {
        StartGame();
    }
	void StartGame()
    {
        max = 1000;
        min = 1;
        NextGuess();

      
    }

    public void GuessLower() {
        max = guess;
        NextGuess();
    }

    public void GuessHigher() {
        min = guess;
        NextGuess();

    }

    //random.RAnge ( minimum , maximum) funcja randomowej cyfry z przedzialu
    void NextGuess() {
        //guess = (max + min) / 2;
        guess = Random.Range(min, max+1);
        text.text = guess.ToString();
        maxGuessesAllowed = maxGuessesAllowed - 1;
        if (maxGuessesAllowed <= 0){
            Application.LoadLevel("Win");
        }
    }
}