using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    public Button B0;
    public Button B1;
    public Button B2;
    public Button B3;
    public Button B4;
    public Button B5;
    public Button B6;
    public Button B7;
    public Button B8;
    public Button B9;
    public Button BE;
    public Button BC;
    public Text message;
    public Text num;
    public GameObject keypad;

    public string passcode;
    string currentCode;
    bool codeCorrect = false;
    bool quit = false;

    // Start is called before the first frame update
    private void Start()
    {
        keypad.SetActive(false);
        B0.onClick.AddListener(() => currentCode = currentCode + "0");
        B1.onClick.AddListener(() => currentCode = currentCode + "1");
        B2.onClick.AddListener(() => currentCode = currentCode + "2");
        B3.onClick.AddListener(() => currentCode = currentCode + "3");
        B4.onClick.AddListener(() => currentCode = currentCode + "4");
        B5.onClick.AddListener(() => currentCode = currentCode + "5");
        B6.onClick.AddListener(() => currentCode = currentCode + "6");
        B7.onClick.AddListener(() => currentCode = currentCode + "7");
        B8.onClick.AddListener(() => currentCode = currentCode + "8");
        B9.onClick.AddListener(() => currentCode = currentCode + "9");
        BE.onClick.AddListener(check);
        BC.onClick.AddListener(() => currentCode = "");
    }
    private void Update()
    {
        if(currentCode.Length > 3)
        {
            currentCode = currentCode.Remove(currentCode.Length - 1);
        }
        num.text = currentCode;
        if (quit == true || codeCorrect == true)
        {
            keypad.SetActive(false);
        }
    }

    public void activate()
    {
        if (codeCorrect == false)
        {
            keypad.SetActive(true);
            message.text = "Enter Passcode to proceed on task";
            message.gameObject.SetActive(true);
        }
        else
            StartCoroutine(showMessageCorrect());
    }

    IEnumerator showMessageCorrect()
    {
        message.text = "You have entered the code";
        message.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        message.gameObject.SetActive(false);

    }
    IEnumerator showMessageWrong()
    {
        message.text = "Incorrect Code Entered";
        message.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        message.text = "Enter Passcode to proceed on task";
    }
    void check()
    {
        if (passcode == currentCode)
        {
            codeCorrect = true;
            keypad.SetActive(false);
            StartCoroutine(showMessageCorrect());
        }
        else
        {
            codeCorrect = false;
            currentCode = "";
            StartCoroutine(showMessageWrong());
        }
    }
}
