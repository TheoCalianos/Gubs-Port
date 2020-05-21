using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPanel : MonoBehaviour
{
  public void loadnext()
  {
    UIManager.Instance.CreateJoinPannel.gameObject.SetActive(true);
    this.gameObject.SetActive(false);
  }
}
