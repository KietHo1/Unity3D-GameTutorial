using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using UnityEngine.SceneManagement;

public class LoadAndNew : MonoBehaviour
{
    //Name of the save file
    public string fileName = "savegame.txt";
    public string LoadCode;
    public static string GlobalLoad;

    public GameObject NoSave;


    void Start()
    {
        //Run a scan of the file and its contents
        System.IO.StreamReader OurFile = new StreamReader(fileName);
        string line = OurFile.ReadLine();
        //while there are no empty lines runt he code
        while (line != null)
        {
            LoadCode = line;
            line = OurFile.ReadLine();
        }
        OurFile.Close();
    }

    public void LoadGame()
    {
        GlobalLoad = LoadCode;
        //I added an additional check for savearea001 for those that have used the "savearea001" instead of "savingthegame"
        if (GlobalLoad == "savingthegame" || GlobalLoad == "savearea001")
        {
            //Application.LoadLevel(1);
            SceneManager.LoadScene(2);
        }
        else
        {
            NoSave.SetActive(true);
        }

    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void NewGame()
    {
        //Ignore the load code file and set it to empty
        GlobalLoad = "";
        //Application.LoadLevel(1);
        SceneManager.LoadScene(1);
    }

    //private void OnEnable()
    //{
    //    SceneManager.sceneLoaded += SceneLoaded;
    //}

    //private void OnDisable()
    //{
    //    SceneManager.sceneLoaded -= SceneLoaded;
    //}

    //private void SceneLoaded(Scene scene, LoadSceneMode mode)
    //{
    //    if (scene == ) //use your desired check here to compare your scene
    //        player.position = targetPosition;
    //}
}