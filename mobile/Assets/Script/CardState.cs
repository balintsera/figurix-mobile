using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class CardState : MonoBehaviour
{
    SpriteRenderer sr;

    public string state;

    public string SpriteSheetName = "figurix-sprites";
    // The dictionary containing all the sliced up sprites in the sprite sheet
    private Dictionary<string, Sprite> spriteSheet;
    // The name of the currently loaded sprite sheet
    private string LoadedSpriteSheetName;
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
        if (state == "bg")
        {
            sr.sprite = spriteSheet["figurix-sprites-f-2"];
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Loads the sprites from a sprite sheet
    private void LoadSpriteSheet()
    {
        // Load the sprites from a sprite sheet file (png). 
        // Note: The file specified must exist in a folder named Resources
        var sprites = Resources.LoadAll<Sprite>(this.SpriteSheetName);
        this.spriteSheet = sprites.ToDictionary(x => x.name, x => x);

        // Remember the name of the sprite sheet in case it is changed later
        this.LoadedSpriteSheetName = this.SpriteSheetName;
    }
}