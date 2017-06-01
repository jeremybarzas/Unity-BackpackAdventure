using UnityEngine;
using UnityEngine.Events;

public class PlayerBehaviour : MonoBehaviour
{
    public static OnPlayerLoaded onPlayerLoaded = new OnPlayerLoaded();
    public Player playerConfig;

    private void Start()
    {
        onPlayerLoaded.Invoke(this);
    }

    public class OnPlayerLoaded : UnityEvent<PlayerBehaviour>
    {
    }
}