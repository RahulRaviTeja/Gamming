using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBG : MonoBehaviour
{
    public float speed;
    public Renderer BgRenderer;

    // Update is called once per frame
    void Update()
    {
        BgRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
