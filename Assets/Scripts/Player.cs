using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    private NavMeshAgent ai;
    public Camera camara;
    public Canvas canva;

    void Start()
    {
        ai = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        RaycastHit location;
        if(Input.GetMouseButton(0) && ai && camara && Physics.Raycast(camara.ScreenPointToRay(Input.mousePosition), out location))
        {
            ai.SetDestination(location.point);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
            Destroy(gameObject);

        else if (collision.gameObject.CompareTag("Finish"))
        {
            if (canva) canva.GetComponent<Menu>().win();
        }
    }
}
