using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MessageBox.SetActive(false);
        TextMessage = TextBox.GetComponent<Text>().text;
        QuestName = QuestText.GetComponent<Text>().text;
    }
    public int TextBoxOnCheck = 0;
    public GameObject MessageBox;
    public GameObject TextBox;
    public string TextMessage;
    public GameObject QuestBox;
    public GameObject QuestText;
    public string QuestName;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit") || Input.GetButtonDown("Cancel"))
        {
            if (TextBoxOnCheck == 1)
            {  //This needs to be set so as you need to be in a TextBox to do it
                MessageBox.SetActive(false);
                TextBoxOnCheck = 0;
                TextMessage = "Villager: Get going then!";
            }
        }
    }

    private void OnMouseDown()
    {
        if (TextBoxOnCheck == 0)
        {
            TextBoxOnCheck = 1;
            MessageBox.SetActive(true);
            QuestName = "Active Quest: Recover The Loot";
            QuestText.GetComponent<Text>().text = QuestName;
            //TextBox.GetComponent<Text>().text = TextMessage;
            TextBox.GetComponent<Text>().text = TextMessage;
        }
        else
        {
            TextBoxOnCheck = 0;
            TextMessage = "Villager: Get going then!";
            TextBox.GetComponent<Text>().text = TextMessage;
            MessageBox.SetActive(false);
        }
    }
}
