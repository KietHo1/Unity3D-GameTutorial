using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class QuestBegin_001 : MonoBehaviour
{
    public TMP_Text QuestUpdate;
    public TMP_Text PlayerText;
    public GameObject TextDisplay;
    private int TimerCounter = 0;

    public AudioSource Line001;
    public AudioSource Line002;
    // Start is called before the first frame update
    void Start()
    {
        QuestBegin001();
    }

    void QuestBegin001() {
        this.transform.position = new Vector3(0, -1000, 0);
        QuestUpdate.text = "Active Quest: Exit The Woods";

        if (TimerCounter == 0)
        {
            StartCoroutine(Timer(1f));
        }
        if (TimerCounter == 1)
        {
            TextDisplay.SetActive(true);
            Line001.Play();
            PlayerText.text = ("Where am I?");
            StartCoroutine(Timer(2f));

        }
        if (TimerCounter == 2)
        {
            Line002.Play();
            PlayerText.text = ("I need to find a way out of this wood.");
            StartCoroutine(Timer(2f));
        }
        if (TimerCounter == 3)
        {
            PlayerText.text = ("");
            TextDisplay.SetActive(false);
            StartCoroutine(Timer(1f));
            gameObject.SetActive(false);
        }
    }

    IEnumerator Timer(float time)
    {
        yield return new WaitForSeconds(time);
        TimerCounter += 1;
        QuestBegin001();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
