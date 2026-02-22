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

public class OOPDemoManager : MonoBehaviour
{
    public void ShowAbstraction()
    {
        Debug.Log("ABSTRACTION: Mostro solo ciò che serve, nascondo i dettagli interni.");
    }

    public void ShowEncapsulation()
    {
        Debug.Log("ENCAPSULATION: Proteggo i dati e li gestisco tramite metodi controllati.");
    }

    public void ShowInheritance()
    {
        Debug.Log("INHERITANCE: Una classe figlia eredita proprietà e metodi dalla classe padre.");
    }

    public void ShowPolymorphism()
    {
        Debug.Log("POLYMORPHISM: Lo stesso metodo può comportarsi in modi diversi a seconda dell’oggetto.");
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game premuto");
        Application.Quit();
    }
}