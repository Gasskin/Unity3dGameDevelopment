using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ExtendEditor : MonoBehaviour
{
    [MenuItem("Assets/MyTools/Tool1",false,2)]
    private static void MyTools1()
    {
        Debug.Log("right mouse");
    }
    
    [MenuItem("Assets/MyTools/Tool2",false,1)]
    private static void MyTools2()
    {
        Debug.Log("right mouse");
    }

    [MenuItem("GameObject/Extend/Test1",true)]
    private static bool ValidateTest1()
    {
        return Selection.activeObject != null;
    }
    
    [MenuItem("GameObject/Extend/Test1",false)]
    private static void Test1()
    {
        Debug.Log(Selection.gameObjects.Length);
    }
}
