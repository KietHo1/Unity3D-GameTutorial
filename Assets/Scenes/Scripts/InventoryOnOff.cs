using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryOnOff : MonoBehaviour
{
    public GameObject OurInventory;
    public int InvStatus;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            if (InvStatus == 0)
            {
                InvStatus = 1;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                OurInventory.SetActive(true);
            }
            else
            {
                InvStatus = 0;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                OurInventory.SetActive(false);
            }
        }
    }
}
