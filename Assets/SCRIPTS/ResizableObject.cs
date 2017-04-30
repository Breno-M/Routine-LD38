using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizableObject : MonoBehaviour {

    public float size;
    public bool popup;
    public bool console;

    void Update () {
        if(popup)
            transform.localScale = new Vector2(Camera.main.orthographicSize / (size/3), Camera.main.orthographicSize / size);
        else if (console)
            transform.localScale = new Vector2(Camera.main.orthographicSize / (size / 10), Camera.main.orthographicSize / size);
        else
            transform.localScale = new Vector2(Camera.main.orthographicSize / size, Camera.main.orthographicSize / size);
	}
}
