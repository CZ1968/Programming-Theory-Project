using UnityEngine;

// Encapsulation
// The WonderladSphere class encapsulates the properties and behaviors of a spherical object in the Wonderland, allowing for controlled access to its rotation speed and magic activation while hiding the internal implementation details from other classes.
// By using properties to manage the rotation speed, the class ensures that the value remains within a valid range, demonstrating encapsulation by protecting the internal state of the object while providing a clear interface for interaction.
//
public class WonderladSphere : WonderladObject
{
    [SerializeField]
    private float rotationSpeed = 50f;

    public float RotationSpeed
    {
        get => rotationSpeed;
        set => rotationSpeed = Mathf.Clamp(value, 0, 200);
    }

    public override void ActivateMagic()
    {
        Debug.Log($"{name} releases spherical Wonderlad energy!");
    }

    public override void Rotate()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}