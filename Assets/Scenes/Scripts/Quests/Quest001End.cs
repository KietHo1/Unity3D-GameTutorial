using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Quest001End : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    public int TextBoxOnCheck = 0;
    public GameObject MessageBox;
    public TMP_Text TextBox;
    public GameObject QuestBox;
    public TMP_Text QuestText;
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
            TextBoxOnCheck = 1;
            MessageBox.SetActive(true);
            TextBox.text = "Villager: Thank you very much!";
            QuestText.text = "Active Quest: (None)";
            StartCoroutine(CarryOn());//Run another command below
        }

        else
        {
            MessageBox.SetActive(false);
            TextBoxOnCheck = 0;

        }
    }

    IEnumerator CarryOn()
    {
        yield return new WaitForSeconds(6);
        MessageBox.SetActive(false); //Turn off the message box
        StartCoroutine(TheEnd()); //End Mission
    }
    IEnumerator TheEnd()
    {
        yield return new WaitForSeconds(6);
        gameObject.SetActive(false); //turn this object off
        QuestBox.SetActive(false);
    }
}
