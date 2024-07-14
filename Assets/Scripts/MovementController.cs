using UnityEngine;
using UnityEngine.AI;

public class MovementController : MonoBehaviour
{
    [SerializeField] private Transform _goal;
    [SerializeField] private Camera _camera;
    private Transform _transform;
    private NavMeshAgent _navMeshAgent;
    private Vector3 _destination;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        // Перемещаем персонажа в направлении _destination.
        _destination = _goal.position;
        _navMeshAgent.SetDestination(_destination);

        if (Input.GetMouseButtonDown(0))
        {
            var ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            Physics.Raycast(ray, out hitInfo);
            var position = hitInfo.transform.position;
            _goal.position = position;
            Debug.Log($"x={position.x}, y={position.y}, z={position.z}");
        }
    }
}