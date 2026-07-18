using UnityEditor.Build.Content;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int playerScore;
    public int PlayerScore { get { return playerScore; } set { playerScore = value; } }

    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
      
    }

    void Update()
    {
        
    }
}
