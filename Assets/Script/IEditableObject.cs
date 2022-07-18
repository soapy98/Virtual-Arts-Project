using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IEditableObject : MonoBehaviour
{
    private bool Click;
    public bool IsClicked
    {
        get => Click;
        set => Click = value;
    }
    private bool Grouped;
    public bool IsGrouped
    {
        get => Grouped;
        set => Grouped = value;
    }
    private bool Locked;
    public bool LockedIn
    {
        get => Locked;
        set => Locked = value;
    }
    void Update()
    {
        
    }
    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Delete))
        {
            Destroy(gameObject);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            var a = transform.position;
            a.z += 3;
            transform.position = a;
        }
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;

            if (Physics.Raycast(ray, out raycastHit, Mathf.Infinity))
            {

                float step = 2 * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, transform.position, step);

            }
        }
    }
    public virtual void MouseMove()
    {

    }
    public virtual void Rotate()
    {


    }

}
