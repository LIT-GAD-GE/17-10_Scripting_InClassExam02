using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//AssetPostprocessor allows you to script during the importing of assets
public class SpriteImportTool : AssetPostprocessor
{
    //Task 1
    //function that passes in Texture2D objects
    private void OnPostprocessTexture(Texture2D texture)
    {
        Debug.Log("Texture Imported");
        //get the asset path of the object
        string lowerCaseAssetPath = assetPath.ToLower();
        //make a bool to see if asset is in sprites folder
        bool isInSpriteDirectory = lowerCaseAssetPath.IndexOf("/sprites/") != -1;

        //if asset is in sprites folder
        if (isInSpriteDirectory)
        {
            Debug.Log("Texture Imported: To sprites");
            //modify the texture
            TextureImporter textureImporter = (TextureImporter)assetImporter;
            //make the texture type sprite
            textureImporter.textureType = TextureImporterType.Sprite;
        }
    }
}
