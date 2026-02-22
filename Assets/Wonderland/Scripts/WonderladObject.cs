using UnityEngine;

// Abstraction
// The WonderladObject class defines a common interface for all objects in the Wonderland, allowing for polymorphic behavior while hiding implementation details.
// By declaring the ActivateMagic and Rotate methods as abstract, the class enforces that all derived classes must provide their own specific implementations for these behaviors, demonstrating abstraction by focusing on what the objects do rather than how they do it in the Wonderland project.
public abstract class WonderladObject : MonoBehaviour
{
    public abstract void ActivateMagic();

    public abstract void Rotate();
}