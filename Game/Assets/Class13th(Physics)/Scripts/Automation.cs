using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class automation : MonoBehaviour
{
    [SerializeField] bool state;
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] Vector3 direction;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            state = true;
        }
    }

    private void Start()
    {
        StartCoroutine(Coroutine());
    }

    private void FixedUpdate()
    {
        // ForceMode.Force : 매 프레임마다 지속적인 힘을 가하는 함수 입니다. (Mass) - 0

        // ForceMode.Impulse : 순간적인 힘을 가합니다. (Mass) - 0

        // ForceMode.Acceleration : 지속적인 가속도를 적용하는 함수입니다. (Mass) - x

        // ForceMode.VelocityChange : 순간적인 속도변경을 적용하는 함수입니다. (Mass) - x

        if (state)
        {
            rigidbody.AddForce(direction, ForceMode.Impulse);

            state = false;
        }      

    }

    IEnumerator Coroutine()
    {
        Debug.Log("Coroutine Start");

        yield return new WaitForSeconds(5);

        Debug.Log("Coroutine Exit");
    }

}
