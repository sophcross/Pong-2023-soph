using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    public static Scoreboard Instance;

    int P1Score;
    int P2Score;
    public int maxScore;
    public string winMessageP1;
    public string winMessageP2;

    public TextMeshProUGUI p1ScoreText;
    public TextMeshProUGUI p2ScoreText;
    public TextMeshProUGUI p1winMessageText;
    public TextMeshProUGUI p2winMessageText;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckWin()
    {
        if (P1Score >= maxScore)
        {
            p1winMessageText.text = winMessageP1;
        }
        else if (P2Score >= maxScore)
        {
            p2winMessageText.text = winMessageP2;
        }
        else if (P1Score < maxScore || P2Score < maxScore)
        {
            BallSpawner.Instance.SpawnBall();
        }
    }

    public void GivePointToP1()
    {
        P1Score++;
        p1ScoreText.SetText(P1Score.ToString());
        CheckWin();
    } 

    public void GivePointToP2()
    {
        P2Score++;
        p2ScoreText.SetText(P2Score.ToString());
        CheckWin();
    }
}
