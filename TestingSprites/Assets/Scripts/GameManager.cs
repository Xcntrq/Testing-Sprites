using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject m_pfTree;
    [SerializeField] private Transform m_objTrees;

    private void Start()
    {
        for (int i = -4; i <= 4; i += 4)
        {
            Instantiate(m_pfTree, m_objTrees).transform.Translate(Vector3.right * i);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
