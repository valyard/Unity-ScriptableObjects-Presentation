using UnityEngine;

[CreateAssetMenu(fileName = "Scale Transformer", menuName = "Transformers/Scale Transformer")]
public class ScaleTransformer : Transformer
{

	public float MaxScale = 2;
	public float Period = 10;

	private float time;

	public override void TransformObject(Transform transform, float deltaTime)
	{
		time += deltaTime;
		if (Period == 0) return;

		var scale = 1 + (Mathf.Sin(time/Period) + 1) * .5f * (MaxScale - 1);
		transform.localScale = new Vector3(scale, scale, scale);
	}

}
