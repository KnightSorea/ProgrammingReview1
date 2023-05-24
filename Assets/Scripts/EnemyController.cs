using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Transform Player;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.right = Player.position - transform.position;
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }
}
