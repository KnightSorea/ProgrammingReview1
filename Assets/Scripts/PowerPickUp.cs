using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPickUp : PickUp
{
    public override void Activate()
    {
        PlayerController pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        pc.PowerUp();
        Debug.Log("Powered up");
    }
}
