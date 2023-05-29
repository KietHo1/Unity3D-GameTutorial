using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using UnityEngine.SceneManagement;
public class Area001Loader : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject StartScript;
    public GameObject VillageBox;
    public TMP_Text QuestBox;
    public float PlayerPosX; //input player co-ordinates
    public float PlayerPosY; //input player co-ordinates
    public float PlayerPosZ; //input player co-ordinates
    public string QuestBoxState;
    //public TMP_Text QuestStatus;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
        ThePlayer = GameObject.FindGameObjectWithTag("player");
        string[] lines = File.ReadAllLines("savegame.txt");
        if (lines[0] == "savingthegame")
        {
            
            PlayerPosX = float.Parse(lines[1]);
            PlayerPosY = float.Parse(lines[2]);
            PlayerPosZ = float.Parse(lines[3]);
            QuestBoxState = lines[7];
        }
        else
        {
            NewGame();
        }
        
        ThePlayer.transform.position = new Vector3(PlayerPosX, PlayerPosY, PlayerPosZ);
        Vector3 playerPosition = ThePlayer.transform.position;
        Instantiate(ThePlayer, playerPosition, Quaternion.identity);
        QuestBox.text = QuestBoxState;
        StartCoroutine(CarryOn());
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    IEnumerator CarryOn()
    {
        yield return new WaitForSeconds(1);
        StartScript.SetActive(false);
        VillageBox.SetActive(false);
    }
}
