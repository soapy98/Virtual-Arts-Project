using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabBase : MonoBehaviour
{
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject obj = Instantiate(gameObject, gameObject.transform.position, Quaternion.identity);
            if (!obj.GetComponent<EditableObject>())
            {
                obj.AddComponent<EditableObject>();
            }
            if (!obj.GetComponent<Rigidbody>())
            {
                obj.AddComponent<Rigidbody>();
            }

            obj.tag = "SpawnObject";
            Destroy(obj.GetComponent<PrefabBase>());
            obj.transform.position -= new Vector3(0, 0, 3);
        }
        
    }
}
