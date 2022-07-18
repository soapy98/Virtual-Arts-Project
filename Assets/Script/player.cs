using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject[] Prefabs;

    // Start is called before the first frame update
    void Start()
    {

        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed");
        }
        //if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        //{
        //    var a = gameObject.transform.position;
        //    a.x -= 3;
        //    gameObject.transform.position = a;
        //}
        //if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        //{
        //    var a = gameObject.transform.position;
        //    a.x += 3;
        //    gameObject.transform.position = a;
        //}
        //if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        //{
        //    var a = gameObject.transform.position;
        //    a.z += 3;
        //    gameObject.transform.position = a;
        //}
        //if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        //{
        //    var a = gameObject.transform.position;
        //    a.z -= 3;
        //    gameObject.transform.position = a;
        //}
    }
}
