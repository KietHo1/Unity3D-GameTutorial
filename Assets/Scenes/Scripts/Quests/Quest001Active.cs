using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Quest001Active : MonoBehaviour
{
    public int TextBoxOnCheck = 0; // Checks if TextBox is on the screen
    public GameObject MessageBox; // Defines the message box as an object
    public TMP_Text TextBox; // Defines the text box as an object

    public GameObject QuestItemToClose;
    public GameObject QuestItemToShow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (TextBoxOnCheck == 0)
        {
            TextBoxOnCheck = 1;
            MessageBox.SetActive(true);
            TextBox.text = "You found the loot.";
            StartCoroutine(CarryOn());
        }
    }
    IEnumerator CarryOn()
    {
        yield return new WaitForSeconds(3);
        gameObject.SetActive(false);
        MessageBox.SetActive(false);
        QuestItemToClose.SetActive(false);
        QuestItemToShow.SetActive(true);
    }
}
