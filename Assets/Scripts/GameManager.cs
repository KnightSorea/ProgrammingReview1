using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public int PlayerLives;
    public TextMeshProUGUI livesUI;
    public float PlayerScore;
    public TextMeshProUGUI scoreUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateScore(float pointsToAdd)
    {
        PlayerScore += pointsToAdd;
        scoreUI.text = $"Score:{PlayerScore}";
    }

    public void updateLives()
    {
        PlayerLives -= 1;
        livesUI.text = $"Lives:{PlayerLives}";
    }
}
