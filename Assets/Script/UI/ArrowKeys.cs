using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public enum Direction
{
    Up,
    RightUp,
    Right,
    RightDown,
    Down,
    LeftDown,
    Left,
    LeftUp
}

public enum ControlType
{
    Move,
    Scale,
    Rotate,
    LockIn,
    Group
}

public class ArrowKeys : MonoBehaviour
{
    [SerializeField] Button Left;
    [SerializeField] Button Up;
    [SerializeField] Button Right;
    [SerializeField] Button Down;
    [SerializeField] Button LeftDown;
    [SerializeField] Button LeftUp;
    [SerializeField] Button RightDown;
    [SerializeField] Button RightUp;
    public GameObject cap;
    [SerializeField]
    private ControlType _controlType;

    public ControlType ControlType
    {
        get => _controlType;
        set => _controlType = value;
    }

    void RemoveListener()
    {
    }

    private void Start()
    {
        Left.onClick.AddListener(delegate { ControlSet(Direction.Left); });
        Up.onClick.AddListener(delegate { ControlSet(Direction.Up); });
        Right.onClick.AddListener(delegate { ControlSet(Direction.Right); });
        Down.onClick.AddListener(delegate { ControlSet(Direction.Down); });
        LeftDown.onClick.AddListener(delegate { ControlSet(Direction.LeftDown); });
        LeftUp.onClick.AddListener(delegate { ControlSet(Direction.LeftUp); });
        RightDown.onClick.AddListener(delegate { ControlSet(Direction.RightDown); });
        RightUp.onClick.AddListener(delegate { ControlSet(Direction.RightUp); });
    }

    public void ControlSet(Direction dir)
    {
        switch (_controlType)
        {
            case ControlType.Move:
                Move(dir);
                break;
            case ControlType.Scale:
                Scale();
                break;
            case ControlType.Rotate:
                Rotate(dir);
                break;
            case ControlType.LockIn:
                LockInPlace();
                break;
            case ControlType.Group:
                Group();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(_controlType), _controlType, null);
        }
    }

    public void Scale()
    {
    }

    public void Group()
    {
    }

    public void LockInPlace()
    {
    }

    public void Rotate(Direction dir)
    {
        switch (dir)
        {
            case Direction.Up:
                break;
            case Direction.RightUp:
                break;
            case Direction.Right:
                break;
            case Direction.RightDown:
                break;
            case Direction.Down:
                break;
            case Direction.LeftDown:
                break;
            case Direction.Left:
                break;
            case Direction.LeftUp:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(dir), dir, null);
        }
    }

    public void Move(Direction dir)
    {
        var transformPosition = cap.transform.position;
        switch (dir)
        {
            case Direction.Up:
                transformPosition.y += 1;
                cap.transform.position = transformPosition;
                break;
            case Direction.RightUp:
                transformPosition.x += 1;
                transformPosition.y += 1;
                cap.transform.position = transformPosition;
                break;
            case Direction.Right:
                transformPosition.x += 1;
                cap.transform.position = transformPosition;
                break;
            case Direction.RightDown:
                transformPosition.x += 1;

                transformPosition.y -= 1;
                cap.transform.position = transformPosition;
                break;
            case Direction.Down:
                transformPosition.y -= 1;
                cap.transform.position = transformPosition;
                break;
            case Direction.LeftDown:
                transformPosition.x -= 1;

                transformPosition.y -= 1;
                cap.transform.position = transformPosition;
                break;
            case Direction.Left:
                transformPosition.x -= 1;
                cap.transform.position = transformPosition;
                break;
            case Direction.LeftUp:
                transformPosition.x -= 1;
                transformPosition.y += 1;
                cap.transform.position = transformPosition;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(dir), dir, null);
        }
    }
}