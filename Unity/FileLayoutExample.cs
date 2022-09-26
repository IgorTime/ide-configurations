using System;
using UnityEngine;

public class FileLayoutExample : MonoBehaviour
{
    public class PublicClass
    {
    }

    private class PrivateClass
    {
    }

    public struct PublicStruct
    {
    }

    private struct PrivateStruct
    {
    }

    public delegate void PublicDelegate();

    private delegate void PrivateDelegate();

    public enum PublicEnum
    {
    }

    private enum PrivateEnum
    {
    }

    public const int PUBLIC_CONST = 1;
    private const int PRIVATE_CONST = 1;

    public static readonly int publicStaticReadonlyField = 1;
    private static readonly int privateStaticReadonlyField = 1;

    public static int publicStaticField = 1;
    private static int privateStaticField = 1;

    public static event Action somePublicStaticEvent;
    private static event Action somePrivateStaticEvent;

    public event Action somePublicEvent;
    private event Action somePrivateEvent;

    [SerializeField] private float someSerializedField;

    public readonly int[] publicReadonlyField;
    private readonly int[] privateReadonlyField;

    public float somePublicField;
    private float somePrivateField;

    public int this[int i] => privateReadonlyField[i]; // Public indexer
    private int this[string c] => 5; // Private indexer

    public static int PublicStaticProperty { get; set; }
    public static int PrivateStaticProperty { get; set; }
    public int PublicProperty { get; set; }
    private int PrivateProperty { get; set; }

    private void Awake()
    {
    }

    private void Start()
    {
        somePrivateField = 1;
        someSerializedField = 1;
        publicStaticField = 1;
        privateStaticField = 1;
        somePublicField = 1;
    }

    private void OnDestroy()
    {
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
    }

    private void OnTriggerStay(Collider other)
    {
    }

    private void OnTriggerExit(Collider other)
    {
    }

    private void OnCollisionEnter(Collision collison)
    {
    }

    private void OnCollisionStay(Collision collison)
    {
    }

    private void OnCollisionExit(Collision collison)
    {
    }


    private void FixedUpdate()
    {
    }

    private void Update()
    {
    }

    private void LateUpdate()
    {
    }

    public static void SomePublicStaticMethod()
    {
    }

    private static void SomePrivateStaticMethod()
    {
    }

    public void SomePublicMethod()
    {
    }

    private void SomePrivateMethod()
    {
    }
}