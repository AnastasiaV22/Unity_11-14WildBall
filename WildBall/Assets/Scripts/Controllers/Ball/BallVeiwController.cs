using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallVeiwController : MonoBehaviour
{

    void ChangeRandomColor()
    {
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.HSVToRGB(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
}
