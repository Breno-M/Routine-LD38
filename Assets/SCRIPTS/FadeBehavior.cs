using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeBehavior : MonoBehaviour {

    public Color firstColor;
    public Color lastColor;

    public float duration;

    private float t;

	void Update () {
        Fade();
    }
	
	void Fade() {

        GetComponent<SpriteRenderer>().color = Color.Lerp(firstColor, lastColor, t);

        if (t < 1)
        {
            t += Time.deltaTime / duration;
        }

    }

    public void ChangeFade(float duration, Color firstFadeColor, Color lastFadeColor)
    {
        GetComponent<FadeBehavior>().duration = duration;
        GetComponent<FadeBehavior>().firstColor = firstFadeColor;
        GetComponent<FadeBehavior>().lastColor = lastFadeColor;
    }

}
