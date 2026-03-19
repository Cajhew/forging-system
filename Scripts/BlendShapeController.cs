
using UdonSharp;
using UnityEngine;

public class BlendShapeController : UdonSharpBehaviour
{
    public SkinnedMeshRenderer mesh;
    public int shapeIndex;

    public void UpdateShape(float progress)
    {
        mesh.SetBlendShapeWeight(shapeIndex, progress * 100f);
    }
}
