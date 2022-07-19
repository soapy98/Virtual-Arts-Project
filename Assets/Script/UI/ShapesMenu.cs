using System;
using UnityEngine;
using UnityEngine.UI;

enum ShapeType
{
    Sphere,
    Cylinder,
    Cube,
    Capsule
}

struct Shape
{
    private string name;
    private GameObject ShapeObj;
    private ShapeType _shapeType;
}

public class ShapesMenu : Menu
{
   [SerializeField] private Button Sphere;
   [SerializeField]  private GameObject SphereObj;
   
   [SerializeField]  private Button Cube;
   [SerializeField]   private GameObject CubeObj;

   [SerializeField]   private Button Cylinder;
   [SerializeField]  private GameObject CylObj;

   [SerializeField]  private Button Capsule;
   [SerializeField]  private GameObject CapsuleObj;

    public void Start()
    {
        Sphere.onClick.AddListener(delegate { SpawnObject(ShapeType.Sphere); });
        Cube.onClick.AddListener(delegate { SpawnObject(ShapeType.Cube); });
        Cylinder.onClick.AddListener(delegate { SpawnObject(ShapeType.Cylinder); });
        Capsule.onClick.AddListener(delegate { SpawnObject(ShapeType.Capsule); });
    }

    void SpawnObject(ShapeType shapeType)
    {
        var position = new Vector3(0, 0, 0);
        var obj = shapeType switch
        {
            ShapeType.Sphere => Instantiate(SphereObj, position, Quaternion.identity),
            ShapeType.Cylinder => Instantiate(CylObj, position, Quaternion.identity),
            ShapeType.Cube => Instantiate(CubeObj, position, Quaternion.identity),
            ShapeType.Capsule => Instantiate(CapsuleObj, position, Quaternion.identity),
            _ => throw new ArgumentOutOfRangeException(nameof(shapeType), shapeType, null)
        };
        if (!obj.GetComponent<EditableObject>())
        {
            obj.AddComponent<EditableObject>();
        }

        if (!obj.GetComponent<Rigidbody>())
        {
            obj.AddComponent<Rigidbody>();
        }
    }
}