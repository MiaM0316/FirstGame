using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ObjectBehaviour : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    GameObject test;
    public bool _gameOver = false;

    public void SpawnObject()
    {
        Instantiate(prefab, new Vector3(Random.Range(-8f, 8f), 6f, 0f), Quaternion.identity);
    }

    public void firstSpawn()
    {
        Instantiate(prefab, new Vector3(0f, 6f, 0f), Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !_gameOver)
        {
            SpawnObject();
            Destroy(gameObject);
            ScoreManager._scoreCount += 1;
        }
        else if (collision.gameObject.tag == "Ground")
        {
            _gameOver = true;
            ScenesManager.Instance.LoadGameOver();
            SetScore();
        }

    }

    public void SetScore()
    {
        ScoreManager._finalScore = ScoreManager._scoreCount;
    }
}
