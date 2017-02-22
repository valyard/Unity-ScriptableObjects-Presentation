using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.Linq;
using System;

public class ListSO : MonoBehaviour 
{
	void Start() 
	{
		var sos = Array.ConvertAll(
			Resources.FindObjectsOfTypeAll<ScriptableObject>(),
			s => s.GetType().FullName);
		GetComponent<Text>().text = 
			string.Format("{0} ScriptableObjects found.", sos.Length);
		
		Array.Sort(sos);
		var sb = new StringBuilder();
		foreach (var so in sos) sb.AppendLine(so);
		Debug.Log(sb.ToString());
	}
}
