using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SavingTheGame : MonoBehaviour
{
    // .txt not .data
    public string FileName = "savegame.txt";

    private void OnTriggerEnter(Collider col)
    {
        //Name of the Object that will collide to save the game
        if (col.gameObject.name == "FPSController")
        {
            //FileName is the String of the name for Filename above
            StreamWriter OurFile = File.CreateText(FileName);

            OurFile.WriteLine("savingthegame");
            OurFile.WriteLine("load10coins");
            //Close the file so that it saves and closes the file afterwards
            OurFile.Close();

        }
    }
}