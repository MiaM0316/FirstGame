using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] Button _play;
    [SerializeField] Button _quit;
    [SerializeField] Button _options;

    // Start is called before the first frame update
    void Start()
    {
        _play.onClick.AddListener(StartNewGame);
        _quit.onClick.AddListener(QuitGame);

    }

    private void StartNewGame()
    {
        ScenesManager.Instance.LoadNewGame();
    }

    private void QuitGame()
    {
        Debug.Log("geht nich");
        Application.Quit();
    }
}
