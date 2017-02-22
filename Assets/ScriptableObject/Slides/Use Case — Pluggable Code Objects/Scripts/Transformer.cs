using UnityEngine;

public abstract class Transformer : ScriptableObject
{

	public abstract void TransformObject(Transform transform, float deltaTime);

}