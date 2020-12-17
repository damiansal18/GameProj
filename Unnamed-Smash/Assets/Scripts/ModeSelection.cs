using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeScreen : MonoBehaviour
{
    public int buttonWidth;
    public int buttonHeight;
    private int origin_x;
    private int origin_y;
    public GUISkin mySkin;
    // Start is called before the first frame update


        //Invoked when GAMEMODES is selected in the main menu 
        // lists all game modes 
        // can go back to main menu

    void Start()
    {
        buttonWidth = 200;
        buttonHeight = 50;
        origin_x = Screen.width / 2 - buttonWidth / 2;
        origin_y = Screen.height / 2 - buttonHeight * 2;
    }

    // Update is called once per frame
    void Update()
    {
        GUI.skin = mySkin;

        if (GUI.Button(new Rect(40, 40, 200, 100), "Back"))
        {
            Application.LoadLevel(0); // back to main menu
        }

        if (GUI.Button(new Rect(origin_x, origin_y, buttonWidth, buttonHeight), "Skirmish"))
        {
          //  Application.LoadLevel(1);
        }
        if (GUI.Button(new Rect(origin_x, origin_y + buttonHeight + 20, buttonWidth, buttonHeight), "Challenge"))
        {
           // Application.LoadLevel(2);
        }
        if (GUI.Button(new Rect(origin_x, origin_y + buttonHeight * 2 + 40, buttonWidth, buttonHeight), "Story Mode"))
        {
           // Application.LoadLevel(3);
        }
    }
}
