using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrashScore : MonoBehaviour
{
    public Text rubbishText;
    //UI Canvas telling the player to escape
    
    public float displayTime = 5f;
    public CanvasGroup canvasGroup;
    private bool alreadyDisplayedImage = false;
    
    // Start is called before the first frame update
    public void Start()
    {
        rubbishText = GetComponent<Text>();
        rubbishText.enabled = true;
    }

    // Update is called once per frame
    public void Update()
    {
        //Display score
        rubbishText.text = "Trash: " + RubbishManager.rubbishCount.ToString() + " / 5";
        
        //Hide score when it reaches maximum trash
        if (RubbishManager.rubbishCount >= 5 && !alreadyDisplayedImage)
        {
            rubbishText.enabled = false;
            //Start warning pop up timer
            StartCoroutine(DisplayImageForSeconds());
            alreadyDisplayedImage = true;
        }
        
    }

    private IEnumerator DisplayImageForSeconds()
    {
        //Reveal warning the canvasGroup
        canvasGroup.alpha = 1;

        // Wait for the specified duration
        yield return new WaitForSeconds(displayTime);

        //Hide warning
        canvasGroup.alpha = 0;
        
    }
}
