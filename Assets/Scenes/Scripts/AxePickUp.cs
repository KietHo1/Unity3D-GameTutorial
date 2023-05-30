using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class AxePickUp : MonoBehaviour
{
    float TheDistance = PlayerCasting.DistanceFromTarget;
    public TMP_Text TextDisplay;
    public GameObject FakeAxe;
    public GameObject RealAxe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    private void OnMouseOver()
    {
        if (TheDistance <= 5)
        {
            TextDisplay.text = "Take Axe";
        }
    }

    private void OnMouseExit()
    {
        TextDisplay.text = "";
    }

    private void OnMouseDown()
    {
        if (TheDistance <= 5)
        {
            transform.position = new Vector3(0, -1000, 0);
            RealAxe.SetActive(true);
            FakeAxe.SetActive(false);
        }
    }
}
