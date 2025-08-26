using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemycontroller : MonoBehaviour
{
    NavMeshAgent navmeshcontroller;
    [SerializeField] Transform objetive;
    [SerializeField] float velocity;

    private void Start()
    {
        navmeshcontroller = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        navmeshcontroller.SetDestination(objetive.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(0);   
        }
    }
}
