using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text highscore;
    public float scoreAmount;
    public float pointIncrease;

    // Start is called before the first frame update
    void Start()
    {
        scoreAmount =0f;
        pointIncrease =1f;
        highscore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    { 
        
        scoreText.text = scoreAmount.ToString();
        scoreAmount +=pointIncrease * Time.deltaTime;
    }

    public void Counter()
    {
        if (scoreAmount < PlayerPrefs.GetFloat("Highscore", 0))
        {
          PlayerPrefs.SetFloat("HighScore", scoreAmount);
          highscore.text = scoreAmount.ToString();
        }
        
    }
    public void Reset() {
        PlayerPrefs.DeleteKey("Highscore");
    }
}
