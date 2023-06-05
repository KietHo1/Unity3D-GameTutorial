using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Quest002Start : MonoBehaviour
{
    public int TextBoxOnCheck = 0;
    public GameObject MessageBox;
    public TMP_Text TextBox;
    public GameObject QuestBox;
    public TMP_Text QuestText;

    public GameObject Key001;
    public GameObject CaveDoor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            if (TextBoxOnCheck == 1)
            {
                MessageBox.SetActive(false);
                TextBoxOnCheck = 0;
            }
        }

        if (Input.GetButtonDown("Cancel"))
        {
            if (TextBoxOnCheck == 1)
            {
                MessageBox.SetActive(false);
                TextBoxOnCheck = 0;
            }
        }
    }

    private void OnMouseDown()
    {
        if (TextBoxOnCheck == 0)
        {
            TextBoxOnCheck = 1;
            MessageBox.SetActive(true);
            TextBox.text = "Servant: I want you to retrieve some Gold Bulion from the cave down the path. Here is the key.";
            QuestText.text = "Active Quest: Retrieve the Bullion";
            Key001.SetActive(true);
            CaveDoor.SetActive(true);
        }

        else
        {
            //TextBox.GetComponent<Text>().text = "Villager: Get going then!";
            TextBoxOnCheck = 0;
            MessageBox.SetActive(false);
        }
    }
}
