using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsPickUp : PickUp
{
    public override void Activate()
    {
        GameManager gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        gm.updateScore(10f);
    }
}
