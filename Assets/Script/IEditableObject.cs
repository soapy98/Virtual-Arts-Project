using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Rigidbody))]
public class IEditableObject : MonoBehaviour
{
    private Camera mainCam;
    private float ZDist;
    [SerializeField] private bool Click;
    [SerializeField] private bool Locked;
    [SerializeField] private bool Grouped;

    public virtual bool IsClicked
    {
        get => Click;
        set => Click = value;
    }


    public bool IsGrouped
    {
        get => Grouped;
        set => Grouped = value;
    }


    public bool LockedIn
    {
        get => Locked;
        set => Locked = value;
    }

    private void Start()
    {
        mainCam = Camera.main;
        ZDist = mainCam.WorldToScreenPoint(transform.position).z;
    }

    void Update()
    {
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ClickObj();
        }

        if (Input.GetKeyDown(KeyCode.Delete))
        {
            Destroy(gameObject);
        }

        if (Click)
        {
            MoveObj();
        }
    }

    public virtual void Rotate()
    {
    }

    public virtual void MoveObj()
    {
        Vector3 ScreenPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, ZDist);
        Vector3 NewPos = mainCam.ScreenToWorldPoint(ScreenPos);
        transform.position = NewPos;
    }

    public void OnMouseDrag()
    {
        MoveObj();
    }

    public virtual void ClickObj()
    {
        GetComponent<Renderer>().material.color = Click ? Color.blue : Color.green;
        Click = !Click;
    }
}