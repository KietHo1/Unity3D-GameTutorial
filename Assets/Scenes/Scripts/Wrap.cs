using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrap : MonoBehaviour
{
    public Transform warptarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "warp001")
        {
            //disable FPSController temporarily to allow warp
            this.gameObject.SetActive(false);
            //change FPSController position
            this.transform.position = warptarget.position;
            //enable FPSController again
            this.gameObject.SetActive(true);
        }
    }
}
