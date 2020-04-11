using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashPagePanel : MonoBehaviour
{
    [SerializeField] float Duration = 1f;
    [SerializeField] float holdtime = 2f;
    [SerializeField] bool isFaded = false;
    // Start is called before the first frame update
    void OnEnable()
    {
      Fade();
    }
    public void Fade()
      {
          var canvGroup = GetComponent<CanvasGroup>();

          //Toggle the end value depending on the faded state ( from 1 to 0)
          StartCoroutine(DoFade(canvGroup, canvGroup.alpha, isFaded ? 0 : 1));

      }
      public IEnumerator DoFade(CanvasGroup canvGroup, float start, float end)//Runto complition beforex
      {
          float counter = 0f;

          while(counter < Duration)
          {
              counter += Time.deltaTime;
              canvGroup.alpha = Mathf.Lerp(start, end, counter / Duration);

              yield return null; //Because we don't need a return value.
          }
            StartCoroutine(holdtimeLogo());
      }

      IEnumerator holdtimeLogo()
      {
          yield return new WaitForSeconds(holdtime);
          loadnext();
      }
      public void loadnext()
      {
        UIManager.Instance.StartPanel.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
      }

}
