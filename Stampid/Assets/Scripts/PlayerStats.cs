using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class PlayerStats : MonoBehaviour
{
    public TextMeshProUGUI Health;
    public TextMeshProUGUI Score;
    public int health = 3;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        showStats();
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void showStats()
    {
        Health.text = "Health = " + health;
        Score.text = "Score= " + score;
    }
}
