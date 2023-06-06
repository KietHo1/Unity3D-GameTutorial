using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowMonitor : MonoBehaviour
{
    public static int OnSnow;
    public int InternalSnow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InternalSnow = OnSnow;
    }
}
