using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupBehavior : MonoBehaviour {

    public Transform target;
    public bool home_popup;
	
	void Update () {
        if(home_popup)
            transform.position = new Vector3(target.position.x, target.position.y - (.25f * Camera.main.orthographicSize), transform.position.z);
        else
            transform.position = new Vector3(target.position.x, target.position.y - (.1f * Camera.main.orthographicSize), transform.position.z);

	}
}
