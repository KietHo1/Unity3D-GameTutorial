using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveDoorOpen : MonoBehaviour
{
    public GameObject DoorSwing;
    public GameObject TheKey; 
    public AudioSource KeySound;
    public AudioSource CreekSound;
    public GameObject ThisObject;
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
        TheKey.SetActive(false);
        KeySound.Play();
        StartCoroutine(CarryOn1());
        StartCoroutine(CarryOn2());
    }

    IEnumerator CarryOn1()
    {
        yield return new WaitForSeconds(0.5f);
        CreekSound.Play();
        DoorSwing.GetComponent<Animator>().enabled = true;
    }

    IEnumerator CarryOn2()
    {
        yield return new WaitForSeconds(0.99f);
        DoorSwing.GetComponent<Animator>().enabled = false;
    }
}
