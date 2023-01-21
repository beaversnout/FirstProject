using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    /// <summary>
    /// MonoBehavior �� ��ӹ��� ������Ʈ���� �����ڸ����ؼ� �����ϸ� �ȵ�
    /// You gotta activate the game object for it to instantiate
    /// ������ ������� ����� (�����ڿ� ���ٴ°��� �ƴ�). �ɹ��������� �ʱ�ȭ�� �ؾ��ҋ� �ַ� Awake���� ��)
    /// </summary>
    // Start is called before the first frame update
    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    private void Reset()
    {
        Debug.Log("Reset");
    }

    void Start()
    {
        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"[Movement] : {other.name} triggered");
    }

    private void OnTriggerStay(Collider other)
    { 
    
    }

    private void OnTriggerExit(Collider other)
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"[Movement] : {collision.gameObject.name} collided");
    }

    private void OnMouseDown()
    {
        Debug.Log($"[Movement] : {gameObject.name} mouse down");
    }

    private void OnMouseDrag()
    {
        Debug.Log($"[Movement] : {gameObject.name} mouse drag");
    }

    private void OnMouseOver()
    {
        Debug.Log($"[Movement] : {gameObject.name} mouse over");
    }

    private void OnMouseExit()
    {
        Debug.Log($"[Movement] : {gameObject.name} mouse exit");
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }

    private void LateUpdate()
    { 
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(Vector3.zero, 2.0f);
    }
}
