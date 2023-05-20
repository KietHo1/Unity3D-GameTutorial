using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaStart_000 : MonoBehaviour
{
    public GameObject BlackScreen;
    public GameObject FadeScreen;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CarryOn1());
        StartCoroutine(CarryOn2());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CarryOn1()
    {
        yield return new WaitForSeconds(1);
        FadeScreen.GetComponent<Animator>().enabled = true;
        BlackScreen.SetActive(false);
    }
    IEnumerator CarryOn2()
    {
        yield return new WaitForSeconds(0.99f);
        FadeScreen.GetComponent<Animator>().enabled = false;
        FadeScreen.SetActive(false);
    }

    //Advanced Code

    //void Start()
    //{
    //    StartCoroutine(BlackScreenDown(1));
    //    StartCoroutine(FadeScreenDown(1.99F));

    //}
    //IEnumerator BlackScreenDown(float time)
    //{
    //    yield return new WaitForSeconds(time);
    //    FadeScreen.GetComponent<Animator>().enabled = true;
    //    BlackScreen.SetActive(false);

    //}
    //IEnumerator FadeScreenDown(float time)
    //{
    //    yield return new WaitForSeconds(time);
    //    FadeScreen.GetComponent<Animator>().enabled = false;
    //    FadeScreen.SetActive(false);
    //}
}
