using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    private void OnTriggerEnter(Collider info)
    {
        Destroy(gameObject);
        CoinSystem.coinscollect += 1;
    }
}
