using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int enemyhealth = 50;

    private void DeductPoints(int hitpoints)
    {

        enemyhealth -= hitpoints;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyhealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
