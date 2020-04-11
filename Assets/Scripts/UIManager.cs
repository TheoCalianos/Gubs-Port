using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;
    public static UIManager Instance
    {
      get
      {
        if(_instance == null)
        {
          Debug.LogError("The UI Manager is NULL");
        }

        return _instance;
      }
    }
    public SplashPagePanel SplashPagePanel;
    public StartPanel StartPanel;
    List<GameObject> Panels = new List<GameObject>();
    public int couter = 0;
    private void Awake()
    {
      _instance = this;
    }


}
