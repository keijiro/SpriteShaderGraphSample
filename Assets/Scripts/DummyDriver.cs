using UnityEngine;

public sealed class DummyDriver : MonoBehaviour
{
    [field:SerializeField] public bool Running = false;

    void Start()
    {
        var anim = GetComponent<Animator>();
        anim.SetBool("grounded", true);
        anim.SetFloat("velocityX", Running ? 1 : 0);
    }
}
