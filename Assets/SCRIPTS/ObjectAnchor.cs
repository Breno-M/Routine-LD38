using UnityEngine;
using System.Collections;

public class ObjectAnchor : MonoBehaviour
{
    public float x;
    public float y;
    public float z;

    void Update()
    {
        transform.position = Camera.main.ViewportToWorldPoint(new Vector3(x, y, z));
    }

}
