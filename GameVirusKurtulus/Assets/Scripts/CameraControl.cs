using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject player;
    public Camera cam;
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        cam.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -12);
    }
}
