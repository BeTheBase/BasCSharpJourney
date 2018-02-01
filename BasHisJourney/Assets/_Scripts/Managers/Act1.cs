using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Act1 : MonoBehaviour
{
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
        StartCoroutine(SetActiveOverTime(BasText.gameObject, 4, false));
        StartCoroutine(NextLine(DylanString, DylanText, 0, 4, true));
        StartCoroutine(SetActiveOverTime(DylanText.gameObject, 6, false));
        StartCoroutine(SetActiveOverTime(UnityIcon, 6, true));
        StartCoroutine(NextLine(BasString, BasText, 1, 6, true));
        StartCoroutine(NextLine(BasString, BasText, 2, 8, true));
        StartCoroutine(SetActiveOverTime(BasText.gameObject, 10, false));
        StartCoroutine(NextLine(DylanString, DylanText, 1, 10, true));
        StartCoroutine(NextLine(DylanString, DylanText, 2, 12, true));
        StartCoroutine(SetActiveOverTime(DylanText.gameObject, 14, false));
        StartCoroutine(NextLine(BasString, BasText, 3, 14, true));
        StartCoroutine(NextLine(BasString, BasText, 4, 16, true));
        StartCoroutine(SetActiveOverTime(BasText.gameObject, 18, false));
        StartCoroutine(NextLine(DylanString, DylanText, 3, 18, true));
        StartCoroutine(NextLine(DylanString, DylanText, 4, 20, true));
        StartCoroutine(SetActiveOverTime(DylanText.gameObject, 22, false));
        StartCoroutine(NextLine(BasString, BasText, 5, 22, true));
        StartCoroutine(SetActiveOverTime(BasText.gameObject, 24, false));
        StartCoroutine(NextLine(DylanString, DylanText, 5, 24, true));
        StartCoroutine(SetActiveOverTime(DylanText.gameObject, 26, false));
        StartCoroutine(NextLine(BasString, BasText, 6, 26, true));
        StartCoroutine(SetActiveOverTime(BasText.gameObject, 28, false));
        StartCoroutine(NextLine(DylanString, DylanText, 6, 28, true));
        StartCoroutine(SetActiveOverTime(DylanText.gameObject, 30, false));
        StartCoroutine(NextLine(BasString, BasText, 7, 30, true));
        StartCoroutine(SetActiveOverTime(BasText.gameObject, 32, false));

        StartCoroutine(SetDylanPlay(true, 24));
        StartCoroutine(SetBasPlay(true, 26));
        StartCoroutine(SetActiveOverTime(BasText.gameObject, 30, false));
        StartCoroutine(SetActiveOverTime(DylanText.gameObject, 28, false));
        FadeGameIn.CrossFadeAlpha(0f, 3f, false);
    }

    void Update()
    {
        if(DylanPlay)
            Dylan.transform.Translate(1 * Time.deltaTime * Speed,0,0);

        if(BasPlay)
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
}
