using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public class SOWindow : EditorWindow 
{

	static SOWindow()
	{
		EditorApplication.update += doShow;
	}

	[MenuItem("Custom/Open Window", false, 0)]
	private static void createWindow()
	{
		EditorWindow window = GetWindow<SOWindow>(true, "Hi there!", true);
		window.maxSize = new Vector2(500, 500);
		window.minSize = new Vector2(500, 500);

		window.Show();
	}

	private static void doShow() 
	{
		EditorApplication.update -= doShow;

		var sos = Resources.FindObjectsOfTypeAll<SO>();
		if (sos.Length == 0)   
		{
			var so = ScriptableObject.CreateInstance<SO>(); 
			so.hideFlags = HideFlags.HideAndDontSave;
			createWindow();
		}
	}

	private void OnGUI()
	{
		var style = new GUIStyle();
		style.alignment = TextAnchor.MiddleCenter;
		EditorGUILayout.LabelField("Hi there!", style, GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
	}

	private class SO : ScriptableObject
	{
	}

}
