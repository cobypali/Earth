using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeColor : MonoBehaviour {

    public Material mat;
    public Material red;
    public GameObject pin;
    public int scene;

    private void OnMouseOver()
    {
        pin.GetComponent<Renderer>().material = mat;

        if (Input.GetMouseButtonUp(0))
        {
            SceneManager.LoadScene(scene);
        }
    }

    private void OnMouseExit()
    {
        pin.GetComponent<Renderer>().material = red;

    }
}
