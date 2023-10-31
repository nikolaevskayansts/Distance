using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    [SerializeField] private Sprite[] houses;
    [SerializeField] private Sprite[] schemes;
    [SerializeField] private Sprite[] nothings;

    private SpriteRenderer renderer;
    private int counter = 1;
    public int spritesSetNum = 0;

    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        spritesSetNum = Random.Range(0, houses.Length);
        renderer.sprite = houses[spritesSetNum];
    }

    private void OnMouseDown()
    {
        if (counter == 0)
        {
            spritesSetNum = Random.Range(0, houses.Length);
            renderer.sprite = houses[spritesSetNum];
        }
        if (counter == 1)
        {
            renderer.sprite = schemes[spritesSetNum];
        }
        if (counter == 2)
        {
            renderer.sprite = nothings[spritesSetNum];
        }
        counter++;
        if (counter == 3)
        {
            counter = 0;
        }
        
    }
}
