using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeBehavior : MonoBehaviour {

    public GameObject popup;
    public GameObject dialog;
    public GameObject GM;
    public Texture2D cursorSelected;
    public Texture2D cursorNormal;
    public GameObject line;
    public GameObject spy;
    private Paths paths;

    private bool blockedPopup;

    private void Start()
    {
        paths = new Paths();
    }

    void OnMouseEnter()
    {
        if (!blockedPopup)
        {
            popup.SetActive(true);
            Cursor.SetCursor(cursorSelected, new Vector2(32, 32), CursorMode.Auto);
            GenerateLines();
        }
    }

    void OnMouseExit()
    {
        popup.SetActive(false);
        if(!GM.GetComponent<ClickController>().waitForUnpainting)
            Cursor.SetCursor(cursorNormal, new Vector2(32, 32), CursorMode.Auto);
        DestroyLines();
    }

    public void CloseDialog()
    {
        dialog.SetActive(false);
        blockedPopup = false;
        GM.GetComponent<ClickController>().isShowingDialog = false;
    }

    private void OnMouseDown()
    {
        if (!GM.GetComponent<ClickController>().isShowingDialog)
        {
            GetComponent<AudioSource>().Play();
            Cursor.SetCursor(cursorNormal, new Vector2(32, 32), CursorMode.Auto);
            popup.SetActive(false);
            dialog.SetActive(true);
            blockedPopup = true;
            GM.GetComponent<ClickController>().isShowingDialog = true;
            StartCoroutine(BlocKPopup());
        }
    }

    void DestroyLines()
    {
        GameObject[] lines = GameObject.FindGameObjectsWithTag("Line");
        foreach (GameObject l in lines)
            Destroy(l);
    }

    void GenerateLines()
    {
        int wpB = spy.GetComponent<SpyBehavior>().workplace.GetComponent<WorkplaceBehavior>().GetWayPoint();

        List<int> route = paths.GetPath(spy.GetComponent<SpyBehavior>().homeWaypoint, wpB, true);

        for (int i = 0; i < route.Count; i++)
        {
            GameObject newLine = Instantiate(line, transform.position, Quaternion.identity);
            if(i == 0)
                newLine.SendMessage("SetOrigin", GameObject.Find("Waypoint (" + spy.GetComponent<SpyBehavior>().homeWaypoint + ")"));
            else
                newLine.SendMessage("SetOrigin", GameObject.Find("Waypoint (" + route[i - 1] + ")"));
            newLine.SendMessage("SetTarget", GameObject.Find("Waypoint (" + route[i] + ")"));
            newLine.GetComponent<LineRenderer>().material.color = spy.GetComponent<SpriteRenderer>().color;
        }

        route.Clear();

        wpB = spy.GetComponent<SpyBehavior>().visit.GetComponent<PlaceBehavior>().GetWayPoint();
        route = paths.GetPath(spy.GetComponent<SpyBehavior>().homeWaypoint, wpB, true);

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

    IEnumerator BlocKPopup()
    {
        yield return new WaitForSeconds(.1f);
        GM.GetComponent<ClickController>().preparedToClose = true;
    }

}
