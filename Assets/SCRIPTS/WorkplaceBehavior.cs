using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkplaceBehavior : MonoBehaviour {

    public int waypoint;
    public string workplaceName;
    public GameObject popup;
    [HideInInspector]
    public bool ignoreDayNight;
    public Color selectionColor;
    public bool waitingForSelection;
    public GameObject spy;
    public GameObject GM;
    public GameObject line;

    private Paths paths;

    public bool occupied;

    private void Start()
    {
        paths = new Paths();
    }

    private void OnMouseDown()
    {
        if (waitingForSelection)
        {
            if (spy.GetComponent<SpyBehavior>().workplace != this.gameObject)
            {
                GetComponent<AudioSource>().Play();
                occupied = true;
                spy.GetComponent<SpyBehavior>().workplace.GetComponent<WorkplaceBehavior>().occupied = false;
                spy.GetComponent<SpyBehavior>().workplace = this.gameObject;
                StartCoroutine(showChanges("[ " + spy.GetComponent<SpyBehavior>().spyName +
                " NOW WORKS AT " + spy.GetComponent<SpyBehavior>().workplace.GetComponent<WorkplaceBehavior>().workplaceName.ToUpper() + " ]"));
            }
            else
            {
                StartCoroutine(showChanges("[ " + spy.GetComponent<SpyBehavior>().spyName +
                " ALREADY WORKS AT " + spy.GetComponent<SpyBehavior>().workplace.GetComponent<WorkplaceBehavior>().workplaceName.ToUpper() + " ]"));
            }
        }
    }

    IEnumerator showChanges(string text)
    {
        yield return new WaitForSeconds(.1f);
        GM.GetComponent<ConsoleController>().ShowMessage(text, false);
    }

    public int GetWayPoint()
    {
        return waypoint;
    }

    void OnMouseEnter()
    {
        popup.SetActive(true);
        if (waitingForSelection)
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
            if(transform.GetChild(0).gameObject.activeInHierarchy == false)
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
