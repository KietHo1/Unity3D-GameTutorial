using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
public class LoadAndNew : MonoBehaviour
{
    public string fileName = "savegame.txt";
    public string LoadCode;
    public static string GlobalLoad;
    // Start is called before the first frame update
    void Start()
    {
        StreamReader ourFile = new StreamReader(fileName);

        string line = ourFile.ReadLine();
        while (line != null)
        {
            LoadCode = line;
            line = ourFile.ReadLine();
        }

        ourFile.Close();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGame()
    {
        GlobalLoad = LoadCode;
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }
}
