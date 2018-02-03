using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalAct : MonoBehaviour
{
    public GameObject Unity;
     
    public bool RunClip;

    public float Speed = 6f;

    public GameObject UnityIcon;
    public GameObject Dylan;
    public GameObject Bas;

    public string[] BasString;
    public string[] DylanString;

    public Image FadeGameIn;

    public Text BasText;
    public Text DylanText;

    public bool DylanPlay, BasPlay;

    void Awake()
    {
        StartCoroutine(NextLine(BasString, BasText, 0, 2, true));
        StartCoroutine(NextLine(DylanString, DylanText, 0, 4, true));
        StartCoroutine(SetActiveOverTime(BasText.gameObject, 4, false));
        StartCoroutine(NextLine(DylanString, DylanText, 1, 6, true));
        StartCoroutine(SetActiveOverTime(DylanText.gameObject, 8, false));
        StartCoroutine(NextLine(BasString, BasText, 1, 8, true));
        StartCoroutine(NextLine(BasString, BasText, 2, 10, true));
        StartCoroutine(SetActiveOverTime(BasText.gameObject, 12, false));
        StartCoroutine(NextLine(DylanString, DylanText, 2, 12, true));
        StartCoroutine(NextLine(DylanString, DylanText, 3, 14, true));
        StartCoroutine(SetActiveOverTime(DylanText.gameObject, 16, false));
        StartCoroutine(NextLine(BasString, BasText, 3, 16, true));
        StartCoroutine(SetActiveOverTime(BasText.gameObject, 18, false));
        StartCoroutine(NextLine(DylanString, DylanText, 4, 18, true));

        StartCoroutine(SetDylanPlay(true, 20));
        StartCoroutine(SetBasPlay(true, 22));
        StartCoroutine(SetActiveOverTime(BasText.gameObject, 18, false));
        StartCoroutine(SetActiveOverTime(DylanText.gameObject, 20, false));
        FadeGameIn.CrossFadeAlpha(0f, 3f, false);
    }

    void Update()
    {
        if (DylanPlay)
            Dylan.transform.Translate(1 * Time.deltaTime * Speed, 0, 0);

        if (BasPlay)
            Bas.transform.Translate(1 * Time.deltaTime * Speed, 0, 0);

        if (Dylan.transform.position.x > 500)
            StartCoroutine(SetActiveOverTime(Dylan, 1, false));
    }

    IEnumerator NextLine(string[] line, Text txt, int index, int time, bool value)
    {
        yield return new WaitForSeconds(time);
        txt.gameObject.SetActive(value);
        txt.text = line[0 + index];
    }

    IEnumerator SetActiveOverTime(GameObject obj, int time, bool active)
    {
        yield return new WaitForSeconds(time);
        obj.SetActive(active);
    }

    IEnumerator SetDylanPlay(bool value, int time)
    {
        yield return new WaitForSeconds(time);
        DylanPlay = value;
    }

    IEnumerator SetBasPlay(bool value, int time)
    {
        yield return new WaitForSeconds(time);
        BasPlay = value;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Unity")
        {
            other.gameObject.transform.SetParent(gameObject.transform);
            RunClip = true;
        }
    }
}
