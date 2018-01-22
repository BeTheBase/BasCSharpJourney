using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public bool GoToMenuScene = false;
    private int _scene;
    TimeCounter timeCounter = new TimeCounter();

    void Awake()
    {
        _scene = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Door")
        {
            GotoNextScene(_scene);
        }
    }

    public void GotoNextScene(int scene)
    {
        if (GoToMenuScene)
            scene = 0;

        SceneManager.LoadScene(scene);
    }
}
