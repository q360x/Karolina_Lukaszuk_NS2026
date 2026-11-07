using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<int> dane = new List<int> { 1, 3, 3, 1, 2, 2, 3, 1, 3, 2 };
        List<int> jedynki = new List<int>();
        List<int> dwojki = new List<int>();
        List<int> trojki = new List<int>();

        // Przechodzimy przez ka¿dy element w liœcie 'dane' za pomoc¹ foreach
        foreach (int cyfra in dane)
        {
            if (cyfra == 1)
            {
                jedynki.Add(cyfra);
            }
            else if (cyfra == 2)
            {
                dwojki.Add(cyfra);
            }
            else if (cyfra == 3)
            {
                trojki.Add(cyfra);
            }
        }

        // Skoro wszystkie elementy zosta³y skopiowane, czyszczymy listê 'dane', 
        // ¿eby by³a ca³kowicie pusta (zgodnie z poleceniem)
        dane.Clear();

        // Wypisanie wyników w konsoli Unity dla weryfikacji
        Debug.Log("Liczba elementów w 'dane': " + dane.Count); // Powinno wynosiæ 0
        Debug.Log("Liczba dosta³ych jedynek: " + jedynki.Count);
        Debug.Log("Liczba dosta³ych dwójek: " + dwojki.Count);
        Debug.Log("Liczba dosta³ych trójek: " + trojki.Count);
    }

    // Update is called once per frame
    void Update()
    {

    }
}