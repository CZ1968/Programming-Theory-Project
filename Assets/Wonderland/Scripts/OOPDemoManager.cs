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
using System.Collections;
using TMPro;

public class OOPDemoManager : MonoBehaviour
{
    public GameObject abstractionObj;
    public GameObject encapsulationObj;
    public GameObject inheritanceObj;
    public GameObject inheritanceChild;
    public GameObject polymorphismObj;

    public GameObject abstractionText;
    public GameObject encapsulationText;
    public GameObject inheritanceText;
    public GameObject polymorphismText;
    public GameObject helpText;

    public float rotationSpeed = 50f;
    private int polyState = 0;

    //private Color lastColor = Color.white;
    private Color lastColor = Color.black;

    private void Update()
    {
        if (encapsulationObj.activeSelf)
        {
            encapsulationObj.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }
        if (inheritanceObj.activeSelf)
        {
            inheritanceObj.transform.Rotate(0, 0, 50f * Time.deltaTime);
            inheritanceChild.transform.Rotate(0, 0, 50f * Time.deltaTime);
        }
        if (polymorphismObj.activeSelf && polyState == 1)
        {
            polymorphismObj.transform.Rotate(80f * Time.deltaTime, 40f * Time.deltaTime, 50f * Time.deltaTime);
        }
    }

    private void HideAll()
    {
        abstractionObj.SetActive(false);
        encapsulationObj.SetActive(false);
        inheritanceObj.SetActive(false);
        inheritanceChild.SetActive(false);
        polymorphismObj.SetActive(false);
        abstractionText.SetActive(false);
        encapsulationText.SetActive(false);
        inheritanceText.SetActive(false);
        polymorphismText.SetActive(false);
        helpText.SetActive(false);
    }

    public void ShowAbstraction()
    {
        HideAll();
        abstractionObj.SetActive(true);
        abstractionText.SetActive(true);
        abstractionObj.transform.localPosition += new Vector3(0, 0.2f, 0);
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
        inheritanceChild.SetActive(true);
        inheritanceText.SetActive(true);
    }

    public void ShowPolymorphism()
    {
        HideAll();
        polymorphismObj.SetActive(true);
        polymorphismText.SetActive(true);
        polyState++;
        if (polyState > 4)
            polyState = 1;
        ApplyPolymorphismBehavior();
    }

    public void ExitApp()
    {
        Application.Quit();
        Debug.Log("Exit pressed");
    }

    private void ApplyPolymorphismBehavior()
    {
        switch (polyState)
        {
            case 1:
                // Rotazione
                polymorphismObj.transform.rotation = Quaternion.identity;
                break;

            case 2:
                // Scala diversa
                polymorphismObj.transform.localScale = new Vector3(1f, 2f, 1f);
                break;

            case 3:
                Renderer r = polymorphismObj.GetComponent<Renderer>();
                Material m = r.material; // istanza privata del materiale

                Color newColor;

                do
                {
                    newColor = new Color(Random.value, Random.value, Random.value);
                }
                while (newColor == lastColor);

                m.color = newColor;
                lastColor = newColor;
                break;

            case 4:
                // Emission diversa
                polymorphismObj.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.cyan * 2f);
                break;
        }
    }
}