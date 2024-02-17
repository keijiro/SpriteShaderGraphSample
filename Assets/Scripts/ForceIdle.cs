using UnityEngine;

public sealed class ForceIdle : MonoBehaviour
{
    void Start()
      => GetComponent<Animator>().SetBool("grounded", true);
}
