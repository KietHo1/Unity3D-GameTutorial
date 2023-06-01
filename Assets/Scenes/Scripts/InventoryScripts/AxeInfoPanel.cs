using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeInfoPanel : MonoBehaviour
{
    public GameObject InfoPanel;
    public GameObject TheAxe;
    public GameObject ItemEquipped;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ItemEquip()
    {
        TheAxe.SetActive(true);
        InfoPanel.SetActive(false);
        ItemEquipped.SetActive(true);
    }

    public void ItemCancel()
    {
        InfoPanel.SetActive(false);
    }
}
