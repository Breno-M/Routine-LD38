using UnityEngine;
using System.Collections;
using System;

public class LineDrawer : MonoBehaviour
{

    private LineRenderer line;
    public Material mat;
    [HideInInspector]
    public GameObject origin;
    [HideInInspector]
    public GameObject target;
    private bool activatedO;
    private bool activatedT;
    [HideInInspector]
    public bool finished;

    public void SetOrigin(GameObject origin)
    {
        line = this.GetComponent<LineRenderer>();
        line.startWidth = .1f;
        line.endWidth = .1f;
        line.material = mat;
        this.origin = origin;
        activatedO = true;
    }
    public void SetTarget(GameObject target)
    {
        this.target = target;
        activatedT = true;
    }

    void Update()
    {

        GetComponent<LineRenderer>().startWidth = Camera.main.orthographicSize / 75;
        GetComponent<LineRenderer>().endWidth = Camera.main.orthographicSize / 75;

        if (activatedO && activatedT && !finished)
        {
            line.SetPosition(0, new Vector3(origin.transform.position.x, origin.transform.position.y, origin.transform.position.z - .5f));
            line.SetPosition(1, new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z - .5f));
        }
    }
}
