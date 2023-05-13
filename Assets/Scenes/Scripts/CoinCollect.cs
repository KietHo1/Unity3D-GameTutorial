using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    private void OnTriggerEnter(Collider info)
    {
        AudioSource coinaudio = GetComponent<AudioSource>();
        coinaudio.Play();
        CoinSystem.coinscollect += 1;
        transform.position = new Vector3(0, -1000, 0);
        StartCoroutine(CarryOn());//Run another command below
    }

    IEnumerator CarryOn()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }
}
