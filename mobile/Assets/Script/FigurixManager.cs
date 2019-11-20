using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigurixManager : MonoBehaviour
{
    public GameObject bg;
    public GameObject border;
    public GameObject figure;

    private SpriteRenderer bgSprite;
    private CardState figureState;
    private SpriteRenderer borderSprite;
    // Start is called before the first frame update
    void Start()
    {
        figureState = figure.GetComponent<CardState>();
        figureState.display = Enum.GetName(typeof(CardState.SpriteNames), 3);

        bgSprite = bg.GetComponent<SpriteRenderer>();
        borderSprite = border.GetComponent<SpriteRenderer>();
        //Set the GameObject's Color quickly to a set Color (blue)
        SetBackround(Color.red);
        SetBorder(Color.white);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetBorder(Color color)
    {
        borderSprite.color = color;
    }

    public void SetBackround(Color color)
    {
        bgSprite.color = color;
    }

    public void SetFigure(string name)
    {
        figureState.display = name;
    }

}
