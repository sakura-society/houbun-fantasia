using UnityEngine;
using TMPro;

public class dailog : MonoBehaviour
{
  // 获取文本框
  [SerializeField] private TMP_Text TextLabel;
  void Start()
  {
    TextLabel.text = "qwq\r\nqwq";
  }
}
