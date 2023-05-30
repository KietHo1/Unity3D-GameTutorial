using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
public class SavingTheGame : MonoBehaviour
{
    // .txt not .data
    public string FileName = "savegame.txt";
    //public GameObject Player;
    //public TMP_Text QuestBoxState;
    private void Update()
    {
        ////Name of the Object that will collide to save the game
        //if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.Z))
        //{
        //    //FileName is the String of the name for Filename above
        //    StreamWriter OurFile = File.CreateText(FileName);

        //    OurFile.WriteLine("savingthegame");
        //    float PlayerPosX = Player.transform.position.x;
        //    float PlayerPosY = Player.transform.position.y;
        //    float PlayerPosZ = Player.transform.position.z;
        //    OurFile.WriteLine(PlayerPosX);
        //    OurFile.WriteLine(PlayerPosY);
        //    OurFile.WriteLine(PlayerPosZ);
        //    OurFile.WriteLine(QuestBoxState.text);
        //    //Close the file so that it saves and closes the file afterwards
        //    OurFile.Close();
        //}
    }

    private void OnTriggerEnter(Collider col)
    {
        //Name of the Object that will collide to save the game
        if (col.gameObject.name == "FPSController")
        {
            //FileName is the String of the name for Filename above
            var OurFile = File.CreateText(FileName);

            OurFile.WriteLine("savearea001");
            //OurFile.WriteLine("load10coins");
            //Close the file so that it saves and closes the file afterwards
            OurFile.Close();
        }
    }
}