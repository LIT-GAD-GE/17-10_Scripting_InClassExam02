using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAttributes : MonoBehaviour
{
    //hold transform of cube
    public Transform cubeTrans;

    //create a context menu item on the right click of the variable in inspector
    [ContextMenuItem("Make Color: Red", "MakeCubeRed")]
    [ContextMenuItem("Make Color: Blue", "MakeCubeBlue")]
    [ContextMenuItem("Make Color: Green", "MakeCubeGreen")]
    [ContextMenuItem("Make Color: White", "MakeCubeWhite")]
    public Material cubeMat;
    //hold material of cube

    //Task 2
    //ccreate a context menu item on the right click of the script component
    [ContextMenu("Make Scale: Large")]
    protected void MakeCubeLarge()
    {
        //change the scale of the cube
        cubeTrans.localScale = new Vector3(5,5,5);
        Debug.Log("Cube Scale: Large");
    }

    [ContextMenu("Make Scale: Small")]
    protected void MakeCubeSmall()
    {
        cubeTrans.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        Debug.Log("Cube Scale: Small");
    }

    [ContextMenu("Make Scale: Default")]
    protected void MakeCubeDefault()
    {
        cubeTrans.localScale = new Vector3(1, 1, 1);
        Debug.Log("Cube Scale: Default");
    }


    //Task 3
    protected void MakeCubeRed()
    {
        //change the colour of the cube
        cubeMat.color = new Color(1, 0, 0);
        Debug.Log("Cube Color: Red");
    }
    protected void MakeCubeBlue()
    {
        cubeMat.color = new Color(0, 0, 1);
        Debug.Log("Cube Color: Blue");
    }
    protected void MakeCubeGreen()
    {
        cubeMat.color = new Color(0, 1, 0);
        Debug.Log("Cube Color: Green");
    }
    protected void MakeCubeWhite()
    {
        cubeMat.color = new Color(1, 1, 1);
        Debug.Log("Cube Color: White");
    }
}
    