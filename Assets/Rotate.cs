using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public GameObject globe;

    private void OnMouseDrag()
    {
        globe.transform.Rotate(0, 1, 0);
    }
}
