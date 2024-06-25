using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] Text _scoreText;
    public static int _scoreCount = 0;
    public static int _finalScore = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _scoreText.text = "BURGIES: " + Mathf.Round(_scoreCount); 
    }

    public static void resetScore()
    {
        _scoreCount = 0;
    }
}
