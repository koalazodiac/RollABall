using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    private Vector3 playerBeginPoint;

    // Start is called before the first frame update
    void Start()
    {
        playerBeginPoint = new Vector3(0.0f, 0.5f, -3.0f);
        transform.position = transform.position + playerBeginPoint;
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
