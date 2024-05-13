using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// ���׸� Ŭ���� ������ �̱���,
/// �ش� �̱����� ��ӹް� instance�� Type�� ������ �ϴ� ������ Type�� instance�� ����,
/// �� Monobehaviour�� ������ ��ӹް� ��.
/// </summary>
/// <typeparam name="T">�̱������� �������� �ν��Ͻ��� Ÿ�� �Է�.</typeparam>
public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType(typeof(T)) as T;

                if (instance == null)
                {
                    Debug.LogError("�ش��ϴ� " + typeof(T) + "Ÿ���� Ŭ������ �ش� ���� �������� ����");
                }
            }
            return instance;
        }
    }

/*    protected virtual void Awake()
    {
        if (instance != default(T))
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this as T;
        }
    }*/
}