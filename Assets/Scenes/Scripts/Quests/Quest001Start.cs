using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Quest001Start : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    public int TextBoxOnCheck = 0;
    public GameObject MessageBox;
    public TMP_Text TextBox;
    public string TextMessage;
    public GameObject QuestBox;
    public TMP_Text QuestText;
    public string QuestName;

    public GameObject QuestItemToShow;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit") || Input.GetButtonDown("Cancel"))
        {
            if (TextBoxOnCheck == 1)
            {  //This needs to be set so as you need to be in a TextBox to do it
                MessageBox.SetActive(false);
                TextBoxOnCheck = 0;
            }
        }
    }

    private void OnMouseDown()
    {
        if (TextBoxOnCheck == 0)
        {
            QuestItemToShow.SetActive(true);
            TextBoxOnCheck = 1;
            MessageBox.SetActive(true);
            TextMessage = "Villager: Hello, some bandits have stolen my money." +
                "Could you retrieve it from them on the other side of the river?";
            TextBox.text = TextMessage;
            QuestName = "Active Quest: 'Recover The Loot'";
            QuestText.text = QuestName;
            
        }
        else
        {
            TextBoxOnCheck = 0;
            TextMessage = "Villager: Get going then!";
            TextBox.text = TextMessage;
            StartCoroutine(CarryOn());
        }
    }
    IEnumerator CarryOn()
    {
        yield return new WaitForSeconds(6);
        MessageBox.SetActive(false);
    }
}
