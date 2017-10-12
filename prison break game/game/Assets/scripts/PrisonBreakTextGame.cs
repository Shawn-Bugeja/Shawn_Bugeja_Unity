using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrisonBreakTextGame : MonoBehaviour {
    public Text myText;

    private enum States
    {
        cell, sheets_0, mirror, lock_0, cell_mirror, sheets_1, lock_1, freedom 
    };

    private States myState;

	void Start () {
        myState = States.cell;
		
	}

    void Cell()
    {
        print("You are in a prison cell, and you want to escape. " +
                "There are " + "some dirty sheets on the bed, a mirror on the wall, " +
                "and the door " + "is locked from the outside.\n\n" + "Press S to view Sheets, " +
                "M to view Mirror and L to view Lock");
    }

    void Update() {
        print(myState);

        if (myState == States.cell)
        {
            Cell();

            if (Input.GetKeyDown(KeyCode.S))
            {
                myState = States.sheets_0;
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                myState = States.mirror;
            }
        }
    }
        
}
