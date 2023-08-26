using UnityEngine;

public class ConfirmButtonBehaviour : MonoBehaviour
{
    void OnMouseDown()
    {
        GameManager.Instance.UIManager.OnClickRestartButton();
        Destroy(GameObject.FindGameObjectWithTag("AlertBox"));
    }
}
