using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextTyper : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public string text1;
    public string text2;
    public string text3;
    public string text4;
    public string text5;
    public string text6;
    public string text7;
    public string text8;
    public float typingSpeed;
    public bool isRunning = false;

    private void Start()
    {
        RunText(0);
    }

    IEnumerator TypeText(string textString)
    {
        if (isRunning == false)
        {
            isRunning = true;
            foreach (char c in textString)
            {
                if (isRunning == false) { textMeshPro.text = textString; break; }
                textMeshPro.text += c;
                yield return new WaitForSeconds(typingSpeed);
            }
            isRunning = false;
        }
    }

    public void RunText(int num)
    {
        textMeshPro.text = "";
        if (num == 0) { StartCoroutine(TypeText(text1)); }
        else if (num == 1) { StartCoroutine(TypeText(text2)); }
        else if (num == 2) { StartCoroutine(TypeText(text3)); }
        else if (num == 3) { StartCoroutine(TypeText(text4)); }
        else if (num == 4) { StartCoroutine(TypeText(text5)); }
        else if (num == 5) { StartCoroutine(TypeText(text6)); }
        else if (num == 6) { StartCoroutine(TypeText(text7)); }
        else if (num == 7) { StartCoroutine(TypeText(text8)); }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.F) && isRunning) { isRunning = false; }
    }
}