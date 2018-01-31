using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public bool RunHappyAnim;
    public bool GoToMenuScene = false;
    private int _scene;

    void Awake()
    {
        RunHappyAnim = false;
        _scene = SceneManager.GetActiveScene().buildIndex + 1;
    }

    void Update()
    {
        if (gameObject.transform.position.y < -400 || gameObject.transform.position.x > 3000 ||
            gameObject.transform.position.x < -2000)
        {
            SceneManager.LoadScene(_scene -1);
        }
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

        StartCoroutine(LoadSceneAfterTime(scene));
    }

    IEnumerator LoadSceneAfterTime(int scene)
    {
        RunHappyAnim = true;
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(scene);
    }
}
