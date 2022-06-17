using UnityEngine;
using TMPro;

public class dialogUI : MonoBehaviour
{
  // 获取文本框
  [SerializeField] private TMP_Text textLabel;
  void Start()
  {
    GetComponent<TypeWriterEffect>().Run("kokosuki\nkokosuki", textLabel);
  }
}
