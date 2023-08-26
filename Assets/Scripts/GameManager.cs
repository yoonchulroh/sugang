using UnityEngine;

public class GameManager: MonoBehaviour
{
    public static GameManager Instance { get; private set; } // Singleton
    
    public ApplyManager applyManager { get; private set; }
    public TimeManager timeManager { get; private set; }
    public UIManager UIManager {get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }

        Instance = this;

        applyManager = GetComponentInChildren<ApplyManager>();
        timeManager = GetComponentInChildren<TimeManager>();
        UIManager = GetComponentInChildren<UIManager>();
    }
}
