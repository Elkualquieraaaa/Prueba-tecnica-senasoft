using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class Navmeshcontroller : MonoBehaviour
{
    NavMeshSurface navmesh;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        navmesh = GetComponent<NavMeshSurface>();
        Buildmesh();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Buildmesh()
    {
        navmesh.RemoveData();
        navmesh.BuildNavMesh();
    }
}
