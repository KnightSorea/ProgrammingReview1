using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezePickUp : PickUp
{ 
    public override void Activate()
    {
        GameObject[] snakes = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject snake in snakes)
        {
            snake.GetComponent<EnemyController>().enabled = false;
        }
        StartCoroutine(FreezeTimer());
    }

    IEnumerator FreezeTimer()
    {
        yield return new WaitForSeconds(3);
        GameObject[] snakes = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject snake in snakes)
        {
            snake.GetComponent<EnemyController>().enabled = true;
        }
    }
}
