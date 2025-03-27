using UnityEngine;

public class CreateOctree : MonoBehaviour
{
    public GameObject[] worldObjects;
    Octree ot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ot = new Octree(worldObjects, 1);
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDrawGizmos()
    {
        if(Application.isPlaying)
        {
            ot.rootNode.Draw();
        }
    }
}
