using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickController : MonoBehaviour {

    public LayerMask applicableLayers;
    public GameObject[] dialogs;
    [HideInInspector]
    public bool waitForUnpainting;
    public GameObject[] workplaces;
    public GameObject[] places;
    public Texture2D cursorSelected;
    public Texture2D cursorNormal;
    [HideInInspector]
    public bool isShowingDialog;

    [HideInInspector]
    public bool preparedToClose;
    [HideInInspector]
    public bool workSelection;
    [HideInInspector]
    public GameObject spySelecting;

    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit vHit = new RaycastHit();
            Ray vRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(vRay, out vHit, 1000) && (applicableLayers == (applicableLayers | (1 << vHit.transform.gameObject.layer))))
            {
                vHit.collider.gameObject.SendMessage("Touch");
            }
        }

        if (preparedToClose)
        {
            if (Input.GetMouseButtonDown(0))
            {
                foreach (GameObject d in dialogs)
                    if(d.activeInHierarchy)
                        d.GetComponent<HomeBehavior>().CloseDialog();
                preparedToClose = false;
            }
        }

        if (waitForUnpainting)
        {
            if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
            {
                ClearSelection();
            }
        }

    }

    public void ClearSelection()
    {
        foreach (GameObject w in workplaces)
        {
            w.GetComponent<WorkplaceBehavior>().ignoreDayNight = false;
            w.GetComponent<WorkplaceBehavior>().waitingForSelection = false;
        }
        foreach (GameObject p in places)
        {
            p.GetComponent<PlaceBehavior>().ignoreDayNight = false;
            p.GetComponent<PlaceBehavior>().waitingForSelection = false;
        }
        waitForUnpainting = false;
        Cursor.SetCursor(cursorNormal, new Vector2(32, 32), CursorMode.Auto);
        GetComponent<ConsoleController>().CloseConsole();
    }

    public void SetUnlock()
    {
        transform.GetChild(0).GetComponent<AudioSource>().Play();
        Cursor.SetCursor(cursorSelected, new Vector2(32, 32), CursorMode.Auto);
        StartCoroutine(UnblockDayNight());
    }

    public IEnumerator UnblockDayNight()
    {
        yield return new WaitForSeconds(.1f);
        waitForUnpainting = true;
    }

}
