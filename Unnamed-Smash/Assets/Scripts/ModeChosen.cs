using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeChosen : MonoBehaviour
{

    public int buttonWidth;
    public int buttonHeight;
    private int origin_x;
    private int origin_y;
    public GUISkin mySkin;
    // Start is called before the first frame update

        //Called when game mode is selected !
        // Invokes this screen where user selects character and begins the game.
        // If no character is selected , default character selected.


    void Start()
    {
        buttonWidth = 200;
        buttonHeight = 50;
        origin_x = Screen.width / 2 - buttonWidth / 2;
        origin_y = Screen.height / 2 - buttonHeight * 2;
    }

    // Update is called once per frame
    void OnGUI()
    {
        GUI.skin = mySkin;

        if (GUI.Button(new Rect(40, 40, 200, 100), "Back"))
        {
            Application.LoadLevel(4); // back to game mode
        }

        if (GUI.Button(new Rect(origin_x, origin_y, buttonWidth, buttonHeight), "Character Selection"))
        {
            //  Application.LoadLevel(1); go to character selection screen
        }
        if (GUI.Button(new Rect(origin_x, origin_y + buttonHeight + 20, buttonWidth, buttonHeight), "Start"))
        {
            Application.LoadLevel(1); //begin respective game mode
        }
    }
}
