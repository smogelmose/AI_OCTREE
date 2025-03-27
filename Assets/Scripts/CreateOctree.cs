using UnityEngine;

public class CreateOctree : MonoBehaviour
{
    public GameObject[] worldObjects;
    Octree ot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ot = new Octree(worldObjects, 1);
        Debug.Log(ot.boundsD);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDrawGizmos()
    {
        if(Application.isPlaying)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireCube(ot.boundsD.center, ot.boundsD.size);
        }
    }
}
