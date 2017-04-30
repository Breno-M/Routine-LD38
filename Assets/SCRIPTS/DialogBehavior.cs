using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogBehavior : MonoBehaviour {

    public GameObject spy;
    public bool place;

    public GameObject GM;
    public GameObject[] workplaces;
    public GameObject[] places;

    public Sprite visitationDialog;
    public Sprite workplaceDialog;

    private void Update()
    {
        if (GM.GetComponent<TimeController>().GetWeekDay(GM.GetComponent<TimeController>().day) != spy.GetComponent<SpyBehavior>().dayOff1.ToString().ToUpper() &&
                GM.GetComponent<TimeController>().GetWeekDay(GM.GetComponent<TimeController>().day) != spy.GetComponent<SpyBehavior>().dayOff2.ToString().ToUpper())
            transform.parent.transform.transform.parent.transform.FindChild("spy").GetComponent<SpriteRenderer>().sprite = visitationDialog;
        else
            transform.parent.transform.transform.parent.transform.FindChild("spy").GetComponent<SpriteRenderer>().sprite = workplaceDialog;
    }

    private void OnMouseDown()
    {

        if (place)
        {
            if (GM.GetComponent<TimeController>().GetWeekDay(GM.GetComponent<TimeController>().day) != spy.GetComponent<SpyBehavior>().dayOff1.ToString().ToUpper() &&
                GM.GetComponent<TimeController>().GetWeekDay(GM.GetComponent<TimeController>().day) != spy.GetComponent<SpyBehavior>().dayOff2.ToString().ToUpper())
            {
                foreach (GameObject p in places)
                {
                    p.GetComponent<PlaceBehavior>().ignoreDayNight = true;
                    p.GetComponent<PlaceBehavior>().waitingForSelection = true;
                    p.GetComponent<PlaceBehavior>().spy = spy;
                }
                GM.GetComponent<ClickController>().SetUnlock();
                GM.GetComponent<ConsoleController>().ShowMessage("[ SELECT A VISITATION PLACE ]", true);
                GM.GetComponent<ClickController>().workSelection = false;
                GM.GetComponent<ClickController>().spySelecting = spy;
            }
            else
                GM.GetComponent<ConsoleController>().ShowMessage(" [ ! - YOU CANNOT ASSIGN A VISITATION DURING " + spy.GetComponent<SpyBehavior>().spyName + "'S DAY OFF - ! ]", false);
        }
        else
        {
            if (GM.GetComponent<TimeController>().GetWeekDay(GM.GetComponent<TimeController>().day) == spy.GetComponent<SpyBehavior>().dayOff1.ToString().ToUpper() ||
                GM.GetComponent<TimeController>().GetWeekDay(GM.GetComponent<TimeController>().day) == spy.GetComponent<SpyBehavior>().dayOff2.ToString().ToUpper())
            {
                foreach (GameObject w in workplaces)
                {
                    if (!w.GetComponent<WorkplaceBehavior>().occupied)
                    {

                        w.GetComponent<WorkplaceBehavior>().ignoreDayNight = true;
                        w.GetComponent<WorkplaceBehavior>().waitingForSelection = true;
                        w.GetComponent<WorkplaceBehavior>().spy = spy;
                    }
                }
                GM.GetComponent<ClickController>().SetUnlock();
                GM.GetComponent<ConsoleController>().ShowMessage("[ SELECT A WORKPLACE ]", true);
                GM.GetComponent<ClickController>().workSelection = true;
                GM.GetComponent<ClickController>().spySelecting = spy;
            }
            else
                GM.GetComponent<ConsoleController>().ShowMessage("[ ! - YOU CANNOT ASSIGN A WORKPLACE DURING " + spy.GetComponent<SpyBehavior>().spyName + "'S WORKING DAY - ! ]", false);
        }
    }

}
