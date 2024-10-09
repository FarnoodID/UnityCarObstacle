using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    float a;
    float b;
    float sin, cos;
    public GameObject player;
    private Vector3 offset ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        a = player.transform.rotation.eulerAngles.y;
        b = a * Mathf.PI / 180;
        sin = Mathf.Sin(b);
        cos = Mathf.Cos(b);
        offset = new Vector3(-7 * sin, 5.0f, -7 * cos);
        transform.position = player.transform.position + offset;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, player.transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
    }
}
