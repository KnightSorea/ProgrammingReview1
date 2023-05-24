using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Activate();
            StartCoroutine(DelayedDestory());
        }       
    }

    public virtual void Activate()
    {

    }

    IEnumerator DelayedDestory()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
