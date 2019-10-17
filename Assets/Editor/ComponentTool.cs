using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ComponentTool : MonoBehaviour
{
    //Task 7
    //create a menu item that is attatched to the SphereAttributes component which will show on right click
    [MenuItem("CONTEXT/SphereAttributes/Make Big")]
    public static void MakeBig(MenuCommand command)
    {
        //make sphere editable
        SphereAttributes sphere = (SphereAttributes)command.context;
        //change sphere scale
        sphere.sphereTrans.localScale = new Vector3(5,5,5);
    }

    [MenuItem("CONTEXT/SphereAttributes/Make Small")]
    public static void MakeSmall(MenuCommand command)
    {
        SphereAttributes sphere = (SphereAttributes)command.context;
        sphere.sphereTrans.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    [MenuItem("CONTEXT/SphereAttributes/Make Default")]
    public static void MakeDefault(MenuCommand command)
    {
        SphereAttributes sphere = (SphereAttributes)command.context;
        sphere.sphereTrans.localScale = new Vector3(1, 1, 1);
    }
}
