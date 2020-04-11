using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    [SerializeField]
    private float fadeInTime;

    private Image image;

    private void Start()
    {
        image = transform.Find("Panel").GetComponent<Image>();
        fadeInTime = 1f * fadeInTime / 10f;
        StartCoroutine("FadeInFunc");
    }

    IEnumerator FadeInFunc()
    {
        for(var i = 1f; i >= 0f; i -= 0.1f)
        {
            image.color = new Color(0f, 0f, 0f, i);
            yield return new WaitForSeconds(fadeInTime);
        }
    }
}
