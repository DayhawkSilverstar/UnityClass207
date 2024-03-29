using UnityEditor;
using UnityEngine;

public class MyWindow : EditorWindow
{
    // Add menu item named "My Window" to the Window menu
    [MenuItem("Custom/RigidObject/Set Mass")]
    public static void SetMass()
    {
		foreach (Transform transform in Selection.transforms)
		{
			GameObject gObject = transform.gameObject;
			if (gObject.rigidbody == null)
			{
				gObject.AddComponent<Rigidbody>();
			}
						
			Vector3 size = gObject.renderer.bounds.size;			
			gObject.rigidbody.mass = size.magnitude;
			
		}
    }
}