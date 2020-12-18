using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settings : MonoBehaviour
{

    public int buttonWidth = 200;
    public int buttonHeight = 50;
    private int origin_x;
    private int origin_y;
    public GUISkin mySkin;
   // public float hSliderValue;

    // Start is called before the first frame update


    //In game settings menu.

    void Start()
    {
        buttonWidth = 200;
        buttonHeight = 50;
       // hSliderValue = 0.0F;
        origin_x = Screen.width / 2 - buttonWidth / 2;
        origin_y = Screen.height / 2 - buttonHeight * 2;
    }

    // Update is called once per frame
    void OnGUI()
    {
        GUI.skin = mySkin;

        if (GUI.Button(new Rect(40, 40, 200, 100), "Back"))
        {
           Application.LoadLevel(1); //back to last active game screen.
        }

       //hSliderValue = GUI.HorizontalSlider(new Rect(origin_x, origin_y, buttonWidth, buttonHeight), hSliderValue, 0.0F, 10.0F);

        if (GUI.Button(new Rect(origin_x, origin_y, buttonWidth, buttonHeight), "Save"))
        {
            //  Game progressed is saved
        }
        if (GUI.Button(new Rect(origin_x, origin_y + buttonHeight + 20, buttonWidth, buttonHeight), "Quit"))
        {
            Application.LoadLevel(0); //Exit the game
        }
    }
}
