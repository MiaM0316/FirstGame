using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [SerializeField] GameObject _screen;

    bool _space = false;
    public bool _paused = false;

    public static TimeManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        _space = Input.GetKeyDown(KeyCode.Space);

        if (_space && !_paused)
        {
            PauseGame();
            _screen.SetActive(_paused);
        }
        else if (_space && _paused)
        {
            ResumeGame();
        }
        _screen.SetActive(_paused);
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        _paused = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        _paused = false;
    }
}
