using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TouchBack : MonoBehaviour
{
    public TextMeshProUGUI phaseDisplayText;
    public Touch theTouch;
    private float timeTouchEnded;
    private float displayTime = .5f;

    private void Start()
    {
        
    }
    private void Update()
    {
        if(Input.touchCount > 0)
        {
            theTouch = Input.GetTouch(0);
            phaseDisplayText.SetText(theTouch.phase.ToString());
            if (theTouch.phase == TouchPhase.Ended)
            {
                timeTouchEnded = Time.time;
            }
        }

        else if (Time.time - timeTouchEnded > displayTime)
        {
            phaseDisplayText.SetText("");
        }
    }
}
