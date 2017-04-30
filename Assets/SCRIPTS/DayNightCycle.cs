using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour {

    public GameObject cameraObject;
    public GameObject streets;
    public GameObject[] genericBackground;
    public GameObject[] genericForeground;

    public float cycleTime;

    public Color dayColor;
    public Color nightColor;

    private float i;
    private bool night;
    private float hour;
    private bool turnBlock;
    private Color dayColorBlock;
    private Color nightColorBlock;

    private void Start()
    {

        dayColorBlock = dayColor;
        nightColorBlock = nightColor;
        i = 0;

    }

    void Update() {

        ChangeTurn();
        ChangeColor();

    }

    void ChangeColor()
    {

        if (!night)
        {
            cameraObject.GetComponent<Camera>().backgroundColor = Color.Lerp(dayColorBlock, nightColor, i);
            streets.GetComponent<SpriteRenderer>().color = Color.Lerp(nightColorBlock, dayColor, i);
            foreach (GameObject e in genericBackground)
                e.GetComponent<SpriteRenderer>().color = Color.Lerp(dayColorBlock, nightColor, i);
            foreach (GameObject e in genericForeground)
                e.GetComponent<SpriteRenderer>().color = Color.Lerp(nightColor, dayColorBlock, i);
        }
        else
        {
            cameraObject.GetComponent<Camera>().backgroundColor = Color.Lerp(nightColorBlock, dayColor, i);
            streets.GetComponent<SpriteRenderer>().color = Color.Lerp(dayColorBlock, nightColor, i);
            foreach (GameObject e in genericBackground)
                e.GetComponent<SpriteRenderer>().color = Color.Lerp(nightColorBlock, dayColor, i);
            foreach (GameObject e in genericForeground)
                e.GetComponent<SpriteRenderer>().color = Color.Lerp(dayColor, nightColorBlock, i);
        }

        if (i < 1)
        {
            if(i > .43f && i < .58f)
                i += (Time.deltaTime / cycleTime) * 5;
            else
                i += Time.deltaTime / cycleTime;

        }

    }

    void ChangeTurn()
    {
        hour = GetComponent<TimeController>().hour;

        if ((hour == 3 || hour == 15) && !turnBlock)
        {
            night = !night;
            StartCoroutine(BlockTurn());
            i = 0;
        }
        
    }

    IEnumerator BlockTurn()
    {
        if (!night)
        {
            dayColorBlock = cameraObject.GetComponent<Camera>().backgroundColor;
            nightColorBlock = streets.GetComponent<SpriteRenderer>().color;
        }
        else
        {
            dayColorBlock = streets.GetComponent<SpriteRenderer>().color;
            nightColorBlock = cameraObject.GetComponent<Camera>().backgroundColor;
        }
        turnBlock = true;
        yield return new WaitForSeconds(3);
        turnBlock = false;
    }

}
