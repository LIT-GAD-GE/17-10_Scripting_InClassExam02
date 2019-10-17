using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ToolMenu : MonoBehaviour
{
    //Task 4 + 6
    //create a tool menu with a menu item # of Selected Objects and make it 2nd priority
    [MenuItem("Tools/# of Selected Objects", false, 2)]
    public static void SelectedObjects()
    {
        //output the number of objects selected
        Debug.Log("# of Selected Objects: " + Selection.objects.Length);
    }

    //to make the menu item # of Selected Objects visible/true
    [MenuItem("Tools/# of Selected Objects", true)]
    public static bool ShowObjectValidator()
    {
        //if theres less than one objects selected make menu item invalid
        if (Selection.objects.Length < 1)
        {
            return (false);
        }
        //if one or more then make menu item valid
        else
        {
            return (true);
        }
    }

    //Task 5
    //create a tool menu with a menu item Deselect Objects and make it 1st priority
    [MenuItem("Tools/Deselect Objects", false, 1)]
    public static void DeslectObjects()
    {
        //deselevt all selected objects
        Selection.activeObject = null;
    }
}
