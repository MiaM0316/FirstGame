using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] Button _restart;
    [SerializeField] Button _menu;
    [SerializeField] Text _shownscore;

    // Start is called before the first frame update
    void Start()
    {
        _restart.onClick.AddListener(StartNewGame);
        _menu.onClick.AddListener(GoToMenu);
        ScoreDisplay();

    }

    private void StartNewGame()
    {
        ScenesManager.Instance.LoadNewGame();
        StartCoroutine(delayReset());
    }

    private void GoToMenu()
    {
        ScenesManager.Instance.LoadMainMenu();
        StartCoroutine(delayReset());
    }

    private IEnumerator delayReset()
    {
        yield return new WaitForEndOfFrame();
        ScoreManager.resetScore();
    }

    private void ScoreDisplay()
    {
        _shownscore.text = "BURGIES " + ScoreManager._finalScore;
    }
}
