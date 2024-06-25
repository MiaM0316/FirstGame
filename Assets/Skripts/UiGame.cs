using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiGame : MonoBehaviour
{
    [SerializeField] Button _options;
    [SerializeField] Button _menu;
    [SerializeField] Button _play;
    [SerializeField] Button _restart;

    [SerializeField] ObjectBehaviour _objectBehaviour;


    // Start is called before the first frame update
    void Start()
    {
        _menu.onClick.AddListener(GoToMenu);
        _play.onClick.AddListener(Resume);
        _restart.onClick.AddListener(Restart);
    }

    private void Restart()
    {
        StartCoroutine(HelpRestart());
    }

    private void GoToMenu()
    {
        StartCoroutine(HelpGoToMenu());
    }

    private void Resume()
    {
        TimeManager.Instance.ResumeGame();
    }

    private IEnumerator HelpRestart()
    {
        ScenesManager.Instance.LoadNewGame();
        yield return new WaitForEndOfFrame();
        TimeManager.Instance.ResumeGame();
        ScoreManager.resetScore();
    }
    private IEnumerator HelpGoToMenu()
    {
        ScenesManager.Instance.LoadMainMenu();
        yield return new WaitForEndOfFrame();
        TimeManager.Instance.ResumeGame();
        ScoreManager.resetScore();
    }
}
