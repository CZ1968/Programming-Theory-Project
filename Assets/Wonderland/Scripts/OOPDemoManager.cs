/*
 * OOP Principles
 *
 * The OOPDemoManager class serves as a demonstration of the four fundamental principles of Object-Oriented Programming (OOP): Abstraction, Encapsulation,
 * Inheritance, and Polymorphism. Each method in the class provides a brief explanation of one of these principles, allowing developers to understand how they
 * can be applied in their own code to create more modular, maintainable, and flexible software designs.
 * By calling the respective methods, developers can see how each principle contributes to the overall structure and behavior of an object-oriented system,
 * making it easier to manage complexity and promote code reuse.

*/

using UnityEngine;
using TMPro;

public class OOPDemoManager : MonoBehaviour
{
    public GameObject abstractionObj;
    public GameObject encapsulationObj;
    public GameObject inheritanceObj;
    public GameObject polymorphismObj;

    public GameObject abstractionText;
    public GameObject encapsulationText;
    public GameObject inheritanceText;
    public GameObject polymorphismText;

    private void HideAll()
    {
        abstractionObj.SetActive(false);
        encapsulationObj.SetActive(false);
        inheritanceObj.SetActive(false);
        polymorphismObj.SetActive(false);
        abstractionText.SetActive(false);
        encapsulationText.SetActive(false);
        inheritanceText.SetActive(false);
        polymorphismText.SetActive(false);
    }

    public void ShowAbstraction()
    {
        HideAll();
        abstractionObj.SetActive(true);
        abstractionText.SetActive(true);
    }

    public void ShowEncapsulation()
    {
        HideAll();
        encapsulationObj.SetActive(true);
        encapsulationText.SetActive(true);
    }

    public void ShowInheritance()
    {
        HideAll();
        inheritanceObj.SetActive(true);
        inheritanceText.SetActive(true);
    }

    public void ShowPolymorphism()
    {
        HideAll();
        polymorphismObj.SetActive(true);
        polymorphismText.SetActive(true);
    }

    public void ExitApp()
    {
        Application.Quit();
        Debug.Log("Exit pressed");
    }
}