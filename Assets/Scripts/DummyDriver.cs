using UnityEngine;

public sealed class DummyDriver : MonoBehaviour
{
    void Start()
    {
        var anim = GetComponent<Animator>();
        anim.SetBool("grounded", true);
        anim.SetFloat("velocityX", 1);
    }
}
