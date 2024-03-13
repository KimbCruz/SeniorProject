using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningTimer : MonoBehaviour
{
    //show the Warning sign to the Player after collecting 5 trash
    private CanvasGroup canvasGroup;

    private void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();

    }

    private void OnTriggerEnter(Collider other)
    {
        //Hide score when it reaches maximum trash
        if (RubbishManager.rubbishCount >= 5)
        {
            StartCoroutine(DisplayImageForSeconds(5f));
        }
    }

    private IEnumerator DisplayImageForSeconds(float seconds)
    {
        float elapsedTime = 0f;
        while (elapsedTime < seconds)
        {
            // Gradually increase alpha from 0 to 1
            canvasGroup.alpha = Mathf.Lerp(0f, 1f, elapsedTime / seconds);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Wait for a moment (optional)
        yield return new WaitForSeconds(1f);

        // Gradually decrease alpha back to 0
        while (canvasGroup.alpha > 0f)
        {
            canvasGroup.alpha -= Time.deltaTime;
            yield return null;
        }

        // Ensure alpha is exactly 0
        canvasGroup.alpha = 0f;
    }
}
