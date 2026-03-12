using UnityEngine;

public class AgentModeñl : MonoBehaviour
{
    [SerializeField] private AgentController _agentController;

     void Start()
    {
        _agentController = GetComponent<AgentController>();
    }
}
