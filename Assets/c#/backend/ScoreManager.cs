using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] Text HighscoreText;
    [SerializeField] Text ScoreText;

    public static float score;
    int highscore;

    void Start()
    {
        score = 0;
    }

    void Update()
    {
        highscore = (int)score;
        ScoreText.text = "" + highscore.ToString();

        if (PlayerPrefs.GetInt("HighScore") <= highscore)
        {
            PlayerPrefs.SetInt("HighScore", highscore);
        }

        HighscoreText.text = "" + PlayerPrefs.GetInt("HighScore").ToString();
    }
}
