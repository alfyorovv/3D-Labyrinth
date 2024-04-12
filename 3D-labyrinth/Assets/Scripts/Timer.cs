using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private float timeRemaining = 60; //Time in seconds
    [SerializeField] private GameObject gameOverPanel;
    private Text timeText;

    private void Awake()
    {
        timeText = GetComponent<Text>();
    }

    private void Start()
    {
        gameOverPanel.SetActive(false);
        Time.timeScale = 1;
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            DisplayTime(timeRemaining);
        }
        else
        {
            timeText.text = "Over";
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        //Convert time to minutes and seconds
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}