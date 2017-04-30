using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpyBehavior : MonoBehaviour {

    public enum wd { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday};

    public string spyName;
    public GameObject GM;
    public GameObject workplace;
    public GameObject visit;
    public float speed;
    public int homeWaypoint;
    public wd dayOff1;
    public wd dayOff2;
    public GameObject popup;
    public GameObject info;

    private bool planedRoute;
    public List<Transform> waypoints;
    public int currentWayPoint = 0;
    public Transform targetWayPoint;
    private Paths paths;
    public List<int> route;

    private void Start()
    {
        waypoints = new List<Transform>();
        route = new List<int>();
        paths = new Paths();
        //SetPath(homeWaypoint, workplace.GetComponent<WorkplaceBehavior>().GetWayPoint(), false);
    }

    void SetPath(int wpA, int wpB, bool positiveWay)
    {
        waypoints.Clear();
        route.Clear();
        currentWayPoint = 0;

        route = paths.GetPath(wpA, wpB, positiveWay);

        for(int i = 0; i < route.Count; i++)
        {
            waypoints.Add(GameObject.Find("Waypoint (" + route[i] + ")").transform);
        }

        targetWayPoint = waypoints[0];

    }

    void Update () {

        if (waypoints.Count > 0)
            Drive();

        if (GM.GetComponent<TimeController>().hour == 9 || GM.GetComponent<TimeController>().hour == 21)
            planedRoute = false;


        if (!planedRoute)
        {
            CheckDay();
        }

        UpdateInfo();

    }

    void Drive()
    {

        if(transform.position == targetWayPoint.position)
        {
            currentWayPoint++;
            if (currentWayPoint > waypoints.Count - 1)
            {
                waypoints.Clear();
                return;
            }
            targetWayPoint = waypoints[currentWayPoint];
        }

        transform.position = Vector3.MoveTowards(transform.position, targetWayPoint.position, speed * Time.deltaTime);

    }

    void CheckDay()
    {
        if (GM.GetComponent<TimeController>().GetWeekDay(GM.GetComponent<TimeController>().day) != dayOff1.ToString().ToUpper()
            && GM.GetComponent<TimeController>().GetWeekDay(GM.GetComponent<TimeController>().day) != dayOff2.ToString().ToUpper())
        {
            if (GM.GetComponent<TimeController>().hour == 7)
            {
                if(GM.GetComponent<ClickController>().workSelection == true && GM.GetComponent<ClickController>().spySelecting == this.gameObject)
                    GM.GetComponent<ClickController>().ClearSelection();
                planedRoute = true;
                SetPath(homeWaypoint, workplace.GetComponent<WorkplaceBehavior>().GetWayPoint(), true);
            }
            else if (GM.GetComponent<TimeController>().hour == 19)
            {
                planedRoute = true;
                SetPath(homeWaypoint, workplace.GetComponent<WorkplaceBehavior>().GetWayPoint(), false);
            }
            
        }
        else
        {
            if (GM.GetComponent<TimeController>().hour == 7)
            {
                if(GM.GetComponent<ClickController>().workSelection == false && GM.GetComponent<ClickController>().spySelecting == this.gameObject)
                    GM.GetComponent<ClickController>().ClearSelection();
                planedRoute = true;
                SetPath(homeWaypoint, visit.GetComponent<PlaceBehavior>().GetWayPoint(), true);
            }
            else if (GM.GetComponent<TimeController>().hour == 19)
            {
                planedRoute = true;
                SetPath(homeWaypoint, visit.GetComponent<PlaceBehavior>().GetWayPoint(), false);
            }
        }
    }

    void UpdateInfo()
    {

        info.GetComponent<TextMesh>().text = spyName + "'S INFO\n\n- WORKS AT:\n" + workplace.GetComponent<WorkplaceBehavior>().workplaceName +
            "\n\n- VISITS:\n" + visit.GetComponent<PlaceBehavior>().placeName + "\n\n- DAYS OFF:\n " + dayOff1.ToString() + " and " + dayOff2.ToString();

    }

    void OnMouseEnter()
    {
        popup.SetActive(true);
    }
    void OnMouseExit()
    {
        popup.SetActive(false);
    }

}
