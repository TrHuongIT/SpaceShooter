using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI TextMeshProUGUI;
    [SerializeField]private TextMeshProUGUI scoretext;
    private int score;

    [SerializeField] private GameObject image;
    [SerializeField] private GameObject button;

    private void Awake()
    {
        Time.timeScale = 0f;
    }
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisableIntro(string text)
    {
        TextMeshProUGUI.text = text;
    }

    public void UpdateScore() 
    {
        score++;
        scoretext.text = "Score: " + score;  
    }

    public void StartGame()
    {
        image.SetActive(false);
        button.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
