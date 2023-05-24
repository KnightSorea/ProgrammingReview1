using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float moveSpeed;
    public float respawnTime;
    private GameManager gm;
    private SpriteRenderer sr;
    public Sprite normalSprite;
    public Sprite deadSprite;
    private bool isDead;
    public bool isPoweredUp;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (!isDead)
        {
        transform.Translate(Vector2.right * horizontalInput * moveSpeed * Time.deltaTime);
        transform.Translate(Vector2.up * verticalInput * moveSpeed * Time.deltaTime);
        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && !isDead)
        {
            if (isPoweredUp)
            {
                Destroy(collision.gameObject);
                gm.updateScore(50f);
            }
            else
            {
            isDead = true;
            sr.sprite = deadSprite;
            gm.updateLives();
            Invoke(nameof(Respawn), respawnTime);
            }
            
        }
        
    }

   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectable") && !isDead)
        {
            Destroy(collision.gameObject);
            gm.updateScore();
        }
    } */

    void Respawn()
    {
        transform.position = new Vector2(Random.Range(-14, 15), Random.Range(-7, 8));
        sr.sprite = normalSprite;
        isDead = false;
    }

    public void PowerUp()
    {
        isPoweredUp = true;
        StartCoroutine(PowerUpTimer());
    }

    IEnumerator PowerUpTimer()
    {
        yield return new WaitForSeconds(5);
        isPoweredUp = false;
        Debug.Log("no more power up");
    }
}
