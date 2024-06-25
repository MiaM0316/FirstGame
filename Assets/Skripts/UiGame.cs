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

    // Start is called before the first frame update
    void Start()
    {
        _menu.onClick.AddListener(GoToMenu);
        _play.onClick.AddListener(Resume);
    }

    private void GoToMenu()
    {
        StartCoroutine(HelpGoToMenu());
    }

    private IEnumerator HelpGoToMenu()
    {
        ScenesManager.Instance.LoadMainMenu();
        yield return new WaitForEndOfFrame();
        TimeManager.Instance.ResumeGame();
        ScoreManager.resetScore();
    }

    private void Resume()
    {
        TimeManager.Instance.ResumeGame();
    }

}
