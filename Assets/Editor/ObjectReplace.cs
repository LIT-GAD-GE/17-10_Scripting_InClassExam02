using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ObjectReplace : ScriptableWizard
{
    //Task 8
    //open a variable that can hold a game object. this is the object that you want to replace the selected objects
    public GameObject replacementObject;

    //make an array variable to hold the selected objects
    private GameObject[] selectedObjects;

    //create a tools menu item Object Replace and make priority 23(this adds divider bar)
    [MenuItem("Tools/Object Replace", false, 23)]
    public static void objectReplace()
    {
        //create an openable window that has a function
        ScriptableWizard.DisplayWizard<ObjectReplace>("Object Replace", "Change Selected Object");
    }

    private void OnWizardCreate()
    {
        //when create is pressed on the scriptable wizard trigger replace all function
        ReplaceAll();
    }

    void ReplaceAll()
    {
        //the selected objects array is equal to the game objects that are selected
        selectedObjects = Selection.gameObjects;

        //loop for each of the game objects in the selection array
        foreach (GameObject go in selectedObjects)
        {
            //save variables for the object in arrays' transform, rotate and scale
            Vector3 objTrans = go.transform.position;
            Quaternion objRotate = go.transform.rotation;
            Vector3 objScale = go.transform.localScale;

            //make the replacements objects scale equal to the scale of the object in the array
            replacementObject.transform.localScale = objScale;

            //create a new replacement object with the same position and rotation of the object in the array
            Instantiate(replacementObject, objTrans, objRotate);

            //destroy the object in the array
            DestroyImmediate(go);
        }
    }
}
