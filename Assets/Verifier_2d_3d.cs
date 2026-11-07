using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectChecker : MonoBehaviour
{
    // Zbiór (tablica) GameObjectów z poprzedniego zadania
    public GameObject[] gameObjectsList;

    void Start()
    {
        CheckObjectsType();
    }

    // G³ówna funkcja sprawdzaj¹ca (zgodnie z prawym schematem na slajdzie)
    public void CheckObjectsType()
    {
        if (gameObjectsList == null) return;

        foreach (GameObject obj in gameObjectsList)
        {
            if (obj != null)
            {
                // Sprawdzamy czy to obiekt 2D (posiada SpriteRenderer)
                SpriteRenderer spriteRend = obj.GetComponent<SpriteRenderer>();
                if (spriteRend != null)
                {
                    // U¿ywamy naszej nowej funkcji dla 2D (punkt 2)
                    DebugSprite2D(spriteRend);
                }
                // Sprawdzamy czy to obiekt 3D (posiada MeshRenderer)
                else if (obj.GetComponent<MeshRenderer>() != null)
                {
                    // Pobieramy Transform obiektu 3D
                    Transform objTransform = obj.transform;
                    // U¿ywamy naszej nowej funkcji dla 3D (punkt 2)
                    DebugTransform3D(objTransform);
                }
            }
        }
    }

    // Punkt 1.2 oraz dolna ga³¹Ÿ schematu: Funkcja przyjmuj¹ca klasê SpriteRenderer
    public void DebugSprite2D(SpriteRenderer spriteRenderer)
    {
        Debug.Log(spriteRenderer.gameObject.name + " to obiekt 2D (SpriteRenderer)");
    }

    // Punkt 1.1 oraz dolna ga³¹Ÿ schematu: Funkcja przyjmuj¹ca klasê Transform
    public void DebugTransform3D(Transform objTransform)
    {
        Debug.Log(objTransform.gameObject.name + " to obiekt 3D (Transform)");
    }
}
