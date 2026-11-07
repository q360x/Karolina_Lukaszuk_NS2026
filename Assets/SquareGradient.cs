using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteColorChanger : MonoBehaviour
{
    public Gradient colorGradient;
    public SpriteRenderer targetSprite;

    // Pocz¹tkowa wysokoœæ (dla 0% gradientu)
    public float minY = 0f;

    // Zmieniamy maksymaln¹ wysokoœæ na 100 zgodnie z treœci¹ zadania!
    public float maxY = 100f;

    void Update()
    {
        if (targetSprite != null)
        {
            Sprite(targetSprite);
        }
    }

    public void Sprite(SpriteRenderer sprite)
    {
        float posY = sprite.transform.position.y;

        // Mathf.InverseLerp przeliczy pozycjê od minY (0) do maxY (100) na zakres od 0 do 1
        float t = Mathf.InverseLerp(minY, maxY, posY);

        // Pobieramy kolor z gradientu
        sprite.color = colorGradient.Evaluate(t);
    }
}