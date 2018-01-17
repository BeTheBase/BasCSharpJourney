using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public FeedBackManager FbManager;
    public ButtonManagerHandler BmHandler;
    public MouseManager MManager;

    private Text _codersText;
    private Animator _anim;
    private AnimationClip _clip;
    private GameObject _obj;
    private float _moveSpeed, _rotationAngle;
    private string _codeMessage;

    void Awake()
    { 
        _codersText = FbManager.CodersFeedback.GetComponent<Text>();
        _anim = FbManager.CodersFeedback.GetComponent<Animator>();
        _anim.enabled = false;
        _clip = FbManager.Clip;
        _moveSpeed = BmHandler.MoveSpeed;
        _rotationAngle = BmHandler.RotationAngle;
    }

    public void RotationHandler()
    {
        FbManager.CodersFeedback.SetActive(true);

        _anim.enabled = true;
        _codeMessage = "Transform.Rotate";
        _codersText.text = _codeMessage;
        MManager.SelectObject().transform.Rotate(Vector3.forward, _rotationAngle);
        MManager.prefab.transform.localEulerAngles += new Vector3(0,0,-45);
        StartCoroutine(PutFalse());
    }

    public void MoveLeft()
    {
        FbManager.CodersFeedback.SetActive(true);

        _anim.enabled = true;
        _codeMessage = "Vector3.left";
        _codersText.text = _codeMessage;
        MManager.SelectObject().transform.position += Vector3.left * _moveSpeed;
        StartCoroutine(PutFalse());
    }

    public void MoveRight()
    {
        FbManager.CodersFeedback.SetActive(true);

        _anim.enabled = true;
        _codeMessage = "Vector3.right";
        _codersText.text = _codeMessage;
        MManager.SelectObject().transform.position += Vector3.right * _moveSpeed;
        StartCoroutine(PutFalse());
    }

    public void MoveUp()
    {
        FbManager.CodersFeedback.SetActive(true);

        _anim.enabled = true;
        _codeMessage = "Vector3.up";
        _codersText.text = _codeMessage;
        MManager.SelectObject().transform.position += Vector3.up * _moveSpeed;
        StartCoroutine(PutFalse());
    }

    public void MoveDown()
    {
        FbManager.CodersFeedback.SetActive(true);

        _anim.enabled = true;
        _codeMessage = "Vector3.down";
        _codersText.text = _codeMessage;
        MManager.SelectObject().transform.position += Vector3.down * _moveSpeed;
        StartCoroutine(PutFalse());
    }

    IEnumerator PutFalse()
    {
        yield return new WaitForSeconds(1f);
        //buttonPush = false;
        _anim.enabled = false;
        FbManager.CodersFeedback.SetActive(false);
    }
}
