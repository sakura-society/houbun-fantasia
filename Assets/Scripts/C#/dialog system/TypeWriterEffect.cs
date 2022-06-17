using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TypeWriterEffect : MonoBehaviour
{
  [SerializeField]
  private float TypeWriterSpeed = 50f;
  public void Run(string textToType, TMP_Text textLabel)
  {
    StartCoroutine(TypeText(textToType, textLabel));
  }
  private IEnumerator TypeText(string textToType, TMP_Text textLabel)
  {
    textLabel.text = string.Empty;
    //* 等待两秒后再运行
    yield return new WaitForSeconds(2);

    //* 申明时间与字数
    float t = 0;
    int charIndex = 0;

    //* 循环单字输出
    while (charIndex < textToType.Length)
    {
      t += Time.deltaTime * TypeWriterSpeed;
      charIndex = Mathf.FloorToInt(t);
      charIndex = Mathf.Clamp(charIndex, 0, textToType.Length);
      textLabel.text = textToType.Substring(0, charIndex);
      yield return null;
    }
    textLabel.text = textToType;
  }
}
