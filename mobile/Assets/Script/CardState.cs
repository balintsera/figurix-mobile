using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class CardState : MonoBehaviour
{
    SpriteRenderer sr;
    enum spriteNames
    {
        bg,
        border,
        f0,
        f1,
        f2,
        f3
    }
    public string active = Enum.GetName(typeof(spriteNames), 0);
    private string cache;

    public string SpriteSheetName = "figurix-sprites";
    // The dictionary containing all the sliced up sprites in the sprite sheet
    private Dictionary<string, Sprite> spriteSheet;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        Debug.Log(sr.sprite);
        //sr.sprite = GetComponent<SpriteRenderer>("figurix-sprites_border");
        LoadSpriteSheet();
        foreach(var keyValuePair in spriteSheet)
        {
            Debug.Log(keyValuePair.Key);
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        var fullName = "figurix-sprites-" + active;
        if (active != cache && spriteSheet.ContainsKey(fullName))
        {
            sr.sprite = spriteSheet[fullName];
            cache = fullName;
        }        
    }


    // Loads the sprites from a sprite sheet
    private void LoadSpriteSheet()
    {
        // Load the sprites from a sprite sheet file (png). 
        // Note: The file specified must exist in a folder named Resources
        var sprites = Resources.LoadAll<Sprite>(this.SpriteSheetName);
        spriteSheet = sprites.ToDictionary(x => x.name, x => x);
    }
}