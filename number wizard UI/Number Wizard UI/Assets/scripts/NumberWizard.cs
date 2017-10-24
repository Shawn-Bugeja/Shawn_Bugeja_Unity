using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{

    int max = 1; 
    int min = 1001;
    int guess = 500;
    int Tries = 10;

    public Text guessText;

    public void GuessHigher()
    {
        max = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        min = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max);

        guessText.text = guess.ToString();

        Tries = Tries - 1; //or instead of -1 use --

        if(Tries == 0)
        {
            //loads the scene name level 
            SceneManager.LoadScene("win");
        }

    }
    
    
}
