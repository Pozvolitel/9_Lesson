using UnityEngine;
using UnityEngine.UI;

public class ButtonStart : MonoBehaviour
{
    private Button _button;
    [SerializeField] private Rigidbody _rig;
    [SerializeField] private FixedJoint _fixJoint;

    private void Start()
    {
        _button = GetComponent<Button>();

        _button.onClick.AddListener(StartGame);
    }

    private void StartGame()
    {
        _fixJoint.connectedBody = _rig;
        gameObject.SetActive(false);
    }
}
