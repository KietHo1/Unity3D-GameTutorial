using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using UnityEngine.SceneManagement;
using System.Text;
public class Area001Loader : MonoBehaviour
{
    //public GameObject ThePlayer;
    //private Transform player;
    public GameObject StartScript;
    public GameObject VillageBox;
    //public float PlayerX = -31.62044f; //input player co-ordinates
    //public float PlayerY = 9.848793f; //input player co-ordinates
    //public float PlayerZ = 134.1003f; //input player co-ordinates
    //public GameObject PlayerLoad;

    public string LoadedCode;

    public TMP_Text QuestStatus;
    //public GameObject ThePlayer;
    //public GameObject StartScript;
    //public GameObject VillageBox;
    //public TMP_Text QuestBox;
    //public float PlayerPosX; //input player co-ordinates
    //public float PlayerPosY; //input player co-ordinates
    //public float PlayerPosZ; //input player co-ordinates
    //public string QuestBoxState;
    //public TMP_Text QuestStatus;
    // Start is called before the first frame update
    void Start()
    {
        LoadedCode = LoadAndNew.GlobalLoad;
        if (LoadedCode == "savearea001")
        {
            //player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            //ThePlayer.transform.position = PlayerLoad.transform.position; /*new Vector3(PlayerX, PlayerY, PlayerZ);*/
            StartCoroutine(CarryOn());
            QuestStatus.text = "Active Quest: Reach The Village";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void LoadGame()
    //{
    //    SceneManager.LoadScene(1);
    //    ThePlayer = GameObject.FindGameObjectWithTag("player");
    //    string[] lines = File.ReadAllLines("savegame.txt");
    //    if (lines[0] == "savingthegame")
    //    {

    //        PlayerPosX = float.Parse(lines[1]);
    //        PlayerPosY = float.Parse(lines[2]);
    //        PlayerPosZ = float.Parse(lines[3]);
    //        QuestBoxState = lines[7];
    //    }
    //    else
    //    {
    //        NewGame();
    //    }

    //    ThePlayer.transform.position = new Vector3(PlayerPosX, PlayerPosY, PlayerPosZ);
    //    Vector3 playerPosition = ThePlayer.transform.position;
    //    Instantiate(ThePlayer, playerPosition, Quaternion.identity);
    //    QuestBox.text = QuestBoxState;
    //    StartCoroutine(CarryOn());
    //}
    //public void QuitGame()
    //{
    //    Application.Quit();
    //}
    //public void NewGame()
    //{
    //    SceneManager.LoadScene(1);
    //}

    IEnumerator CarryOn()
    {
        yield return new WaitForSeconds(1);
        StartScript.SetActive(false);
        VillageBox.SetActive(false);
    }
}
