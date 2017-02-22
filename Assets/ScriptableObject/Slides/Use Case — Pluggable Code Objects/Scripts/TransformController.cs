using UnityEngine;

public class TransformController : MonoBehaviour
{

	public Transformer Transformer;

	private void Update () 
	{
		if (Transformer == null) return;
		Transformer.TransformObject(transform, Time.deltaTime);
	}
}
