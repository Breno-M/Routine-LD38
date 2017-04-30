using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceBehavior : MonoBehaviour {

    public GameObject popup;
    public int waypoint;
    public string placeName;
    [HideInInspector]
    public bool ignoreDayNight;
    public Color selectionColor;
    //[HideInInspector]
    public bool waitingForSelection;
    [HideInInspector]
    public GameObject spy;
    public GameObject GM;
    public GameObject line;

    private Paths paths;


    private void Start()
    {
        paths = new Paths();
    }

    public int GetWayPoint()
    {
        return waypoint;
    }

    private void OnMouseDown()
    {
        if (waitingForSelection)
        {
            if (spy.GetComponent<SpyBehavior>().visit != this.gameObject)
            {
                GetComponent<AudioSource>().Play();
                spy.GetComponent<SpyBehavior>().visit = this.gameObject;
                StartCoroutine(showChanges("[ " + spy.GetComponent<SpyBehavior>().spyName +
                    " NOW VISITS " + spy.GetComponent<SpyBehavior>().visit.GetComponent<PlaceBehavior>().placeName.ToUpper() + " ON THE DAYS OFF ]"));

            }
            else
            {
                StartCoroutine(showChanges("[ " + spy.GetComponent<SpyBehavior>().spyName +
                    " ALREADY VISITS " + spy.GetComponent<SpyBehavior>().visit.GetComponent<PlaceBehavior>().placeName.ToUpper() + " ON THE DAYS OFF ]"));
            }
        }
    }

    IEnumerator showChanges(string text)
    {
        yield return new WaitForSeconds(.1f);
        GM.GetComponent<ConsoleController>().ShowMessage(text, false);
    }

    void OnMouseEnter()
    {
        popup.SetActive(true);
        if(waitingForSelection)
            GenerateLines();
    }
    void OnMouseExit()
    {
        popup.SetActive(false);
        DestroyLines();
    }

    private void LateUpdate()
    {
        if (ignoreDayNight)
        {
            GetComponent<SpriteRenderer>().color = selectionColor;
            if (transform.GetChild(0).gameObject.activeInHierarchy == false)
                transform.FindChild("circle").gameObject.SetActive(true);
        }
        else if (transform.GetChild(0).gameObject.activeInHierarchy == true)
            transform.FindChild("circle").gameObject.SetActive(false);
    }

    void DestroyLines()
    {
        GameObject[] lines = GameObject.FindGameObjectsWithTag("Line");
        foreach (GameObject l in lines)
            Destroy(l);
    }

    void GenerateLines()
    {
        int wpB = GM.GetComponent<ClickController>().spySelecting.GetComponent<SpyBehavior>().homeWaypoint;

        List<int> route = paths.GetPath(waypoint, wpB, true);

        for (int i = 0; i < route.Count; i++)
        {
            GameObject newLine = Instantiate(line, transform.position, Quaternion.identity);
            if (i == 0)
                newLine.SendMessage("SetOrigin", GameObject.Find("Waypoint (" + spy.GetComponent<SpyBehavior>().homeWaypoint + ")"));
            else
                newLine.SendMessage("SetOrigin", GameObject.Find("Waypoint (" + route[i - 1] + ")"));
            newLine.SendMessage("SetTarget", GameObject.Find("Waypoint (" + route[i] + ")"));
            newLine.GetComponent<LineRenderer>().material.color = spy.GetComponent<SpriteRenderer>().color;
        }

    }

}
