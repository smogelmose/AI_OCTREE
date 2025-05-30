using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.UIElements;

public class Octree
{
    public OctreeNode rootNode;
    public Octree(GameObject[] worldObjects,float minNodeSize)
    {
        Bounds bounds = new Bounds();
        foreach (GameObject go in worldObjects)
        {
            bounds.Encapsulate(go.GetComponent<Collider>().bounds);
        }
       
        float maxSize = Mathf.Max(new float[] { bounds.size.x, bounds.size.y, bounds.size.z });
        Vector3 sizeVector = new Vector3(maxSize, maxSize, maxSize) * 0.5f;
        bounds.SetMinMax(bounds.center - sizeVector, bounds.center + sizeVector);

        rootNode = new OctreeNode(bounds, minNodeSize); 
    }
}
