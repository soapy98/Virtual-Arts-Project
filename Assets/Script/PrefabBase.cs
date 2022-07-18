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
            Destroy(obj.GetComponent<PrefabBase>());
            obj.transform.position -= new Vector3(0, 0, 3);
        }
        
    }
}
