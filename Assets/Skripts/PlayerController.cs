using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] ObjectBehaviour _objectBehaviour;
    [SerializeField] Text _timer;

    float _playerSpeed = 13f;
    float _inputHorizontal;

    bool _waiting;


    // Start is called before the first frame update
    void Start()
    {
        _waiting = true;
        StartCoroutine(Wait());    
    }

    // Update is called once per frame
    void Update()
    {
        _inputHorizontal = Input.GetAxisRaw("Horizontal");

        if (_inputHorizontal != 0 && !TimeManager.Instance._paused && !_waiting)
        {
            _rb.AddForce(new Vector2(_inputHorizontal * _playerSpeed, 0f));
        }
    }

    private IEnumerator Wait()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _objectBehaviour.firstSpawn();
        Time.timeScale = 0;
        yield return new WaitForSecondsRealtime(1);
        _timer.text = "2";
        yield return new WaitForSecondsRealtime(1);
        _timer.text = "1";
        yield return new WaitForSecondsRealtime(1);
        _timer.text = "0";
        _timer.enabled = false;
        _waiting = false;
        Time.timeScale = 1;
    }
}
