using UnityEngine;

[CreateAssetMenu(fileName = "Rotation Transformer", menuName = "Transformers/Rotation Transformer")]
public class RotationTransformer : Transformer
{

	public float Speed = 1;

	public override void TransformObject(Transform transform, float deltaTime)
	{
		transform.Rotate(0, deltaTime * Speed, 0);
	}

}
