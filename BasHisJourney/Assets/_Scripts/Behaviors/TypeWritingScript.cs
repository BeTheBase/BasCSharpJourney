using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWritingScript : MonoBehaviour
{
    public float Delay = 0.1f;
    public string[] FullText;
    public IntroductionManager IntroManager;

    private string fullText;
    private string currentText;

    // Use this for initialization
    void Start()
    {
        FullText = IntroManager.IntroText;

        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i < FullText.Length; i++)
        {
            fullText = FullText[i];
            for (int j = 0; j < fullText.Length; j++)
            {
                currentText = fullText.Substring(0, j);
                this.GetComponent<Text>().text = currentText;
                yield return new WaitForSeconds(Delay);
            }
        }
    }
}
