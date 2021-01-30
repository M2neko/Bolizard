using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputerUI : MonoBehaviour
{
    public Text message;
    public Image frame;
    public int countDownTime;

    private void Start()
    {
        message.gameObject.SetActive(false);
        frame.gameObject.SetActive(false);
    }

    IEnumerator countDownStart()
    {
        message.gameObject.SetActive(true);
        frame.gameObject.SetActive(true);
        while (countDownTime > 0)
        {
            message.text = "Task ready in " + countDownTime.ToString() + " sec.";
            yield return new WaitForSeconds(1.0f);
            countDownTime--;
        }
        message.text = "Task Complete";
        yield return new WaitForSeconds(1.0f);
        message.gameObject.SetActive(false);
        frame.gameObject.SetActive(false);
    }

    public bool countDown()
    {
        StartCoroutine(countDownStart());
        return true;
    }
}
