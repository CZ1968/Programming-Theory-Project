using UnityEngine;

//Inheritance
// The WonderladCube class inherits from the WonderladObject class, allowing it to reuse and extend the functionality defined in the base class while providing its own specific implementation for magic activation and rotation behavior.
// By inheriting from WonderladObject, WonderladCube can be treated as a WonderladObject in the WonderladManager, enabling polymorphic behavior while maintaining a clear and organized class hierarchy in the Wonderland project.
public class WonderladCube : WonderladObject
{
    [SerializeField]
    private float rotationSpeed = 30f;

    public override void ActivateMagic()
    {
        Debug.Log($"{name} emits cubic Wonderlad vibrations!");
    }

    public override void Rotate()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}