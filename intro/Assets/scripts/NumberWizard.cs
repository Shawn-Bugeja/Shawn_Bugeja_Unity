using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    //setting a max number
    int max;
    //setting a min number 
    int min;
    //guess is used as 500 so that the user guesses if its greater or smaller than 500, after it is halfed again
    int guess;

    
    void NextGuess()
    {
        print("Is the number bigger or smaller that " + guess + " ?");
        print("Press UP arrow if nember is bigger");
        print("Press DOWN arrow if number is smaller");
        print("Press ENTER if number is guessed");


    }

    void StartGame()
    {
        min = 1;
        max = 1001;
        guess = 500;

        //out putting a message to the user 
        print("Hello and welcome to Number Wizard");
        //Debug.Log is used the same way as print 
        Debug.Log("please choose a number from " + min + " to " + max);
        NextGuess();

    }

    // Use this for initialization
    void Start ()
    {
        StartGame();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("UP arrow pressed");
            min = guess;
            guess = (max + min) / 2;
            NextGuess();
        }

        else

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("DOWN arrow pressed");
            max = guess;
            guess = (max + min) / 2;
            NextGuess();
        }

        else

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("ENTER Pressed");
            Debug.Log("NUMBER GUESSED. gg wp!!!");
            print("(P)lay Again or (Q)uit");

            if (Input.GetKeyDown(KeyCode.Q))
            {
                UnityEditor.EditorApplication.isPlaying = false;
            }
            
            else
                if (Input.GetKeyDown(KeyCode.P))
            {
                StartGame();
            }
        }
    }
}
