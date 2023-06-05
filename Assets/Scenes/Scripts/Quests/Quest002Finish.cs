using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Quest002Finish : MonoBehaviour
{
    public int TextBoxOnCheck = 0;
    public GameObject MessageBox;
    public TMP_Text TextBox;
    public GameObject QuestBox;
    public TMP_Text QuestText;

    public GameObject GoldBar;
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
            TextBox.text = "Servant: Thank you very much.";
            QuestText.text = "Active Quest: Explore";
            GoldBar.SetActive(false);
        }

        else
        {
            //TextBox.GetComponent<Text>().text = "Villager: Get going then!";
            TextBoxOnCheck = 0;
            MessageBox.SetActive(false);
        }
    }
}
