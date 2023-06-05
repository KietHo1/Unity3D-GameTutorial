using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ExitWood_002 : MonoBehaviour
{
    public GameObject TheTextBox;
    public TMP_Text PlayerText;
    public TMP_Text QuestStatus;

    public AudioSource Line003;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "FPSController")
        {
            TheTextBox.SetActive(true);
            Line003.Play();
            PlayerText.text = ("Looks like a village over that bridge");
            StartCoroutine(ExitWoodQuest());
        }
    }

    IEnumerator ExitWoodQuest()
    {
        yield return new WaitForSeconds(3);
        PlayerText.text = "";
        TheTextBox.SetActive(false);
        yield return new WaitForSeconds(1);
        TheTextBox.SetActive(true);
        PlayerText.text = "I had better get across the bridge";
        yield return new WaitForSeconds(3);
        PlayerText.text = "";
        TheTextBox.SetActive(false);
        QuestStatus.text = "Active Quest: Reach The Village";
        //You can change the below to:
        //this.transform.position = new Vector3(0, -1000, 0);
        //instead if you wish
        gameObject.SetActive(false);
    }
}
