using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest002Gold : MonoBehaviour
{
    public GameObject TheGold;
    public GameObject GoldPic;
    public GameObject ThisObject;
    public GameObject QuestEnd;
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
        ThisObject.GetComponent<BoxCollider>().enabled = false;
        GoldPic.SetActive(true);
        TheGold.SetActive(false);
        QuestEnd.SetActive(true);
        ThisObject.SetActive(false);
    }
}
