using System.Collections.Generic;
using UnityEngine;

//Polymorphism
// The WonderladManager class manages a collection of WonderladObjects, allowing for polymorphic behavior by treating all objects as instances of the base class while invoking their specific implementations of magic activation and rotation without needing to know their concrete types.
// The ActivateAllMagic method demonstrates polymorphism by calling the ActivateMagic method on each WonderladObject, which will execute the appropriate behavior based on the actual type of the object (e.g., WonderladSphere or WonderladCube) without requiring any changes to the manager's code.
public class WonderladManager : MonoBehaviour
{
    private WonderladObject[] objects;

    private void Start()
    {
        objects = FindObjectsByType<WonderladObject>(FindObjectsSortMode.None);
    }

    private void Update()
    {
        foreach (var obj in objects)
            obj.Rotate();
    }

    public void ActivateAllMagic()
    {
        foreach (var obj in objects)
            obj.ActivateMagic();
    }

    [ContextMenu("Activate All Magic")]
    private void ActivateAllMagicContextMenu()
    {
        ActivateAllMagic();
    }
}