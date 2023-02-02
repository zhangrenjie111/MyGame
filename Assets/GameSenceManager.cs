using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameSenceManager : MonoBehaviour
{
    /// <summary>
    /// ���ʱ����ǰ����Ϊ��һ��������Ϸ����Ϊ�ڶ��������������Ϊ��󳡾��������ģ����Ч��
    /// ���ʱ����ǰ����Ϊ��һ��������Ϸ����Ϊ�ڶ��������������Ϊ��󳡾��������ģ����Ч��
    /// ���ʱ����ǰ����Ϊ��һ��������Ϸ����Ϊ�ڶ��������������Ϊ��󳡾��������ģ����Ч��
    /// </summary>
    /// 

    private int SenceNum;
    void Start()
    {
        //��ȡ���
        SenceNum = SceneManager.GetActiveScene().buildIndex;
        //��ȡ���� 
        //string name = SceneManager.GetActiveScene().name;

    }

    public void GameStartBtnFunc()     //��Ϸ��ʼ��������Ϸ���ݳ���
    {
        SceneManager.LoadScene(SenceNum + 1);
    }

    public void GameReplayBtnFunc()     //��Ϸ��������ť���¼�����Ϸ������йؿ���ǡ�ü����ϸ��ؿ���1���ؿ��ͼ����Ǹ��ؿ���
    {
        SceneManager.LoadScene(SenceNum - 1);
    }

    public void GoGameoverSenceFunc()  //�������������������������               ���������ʵ����Ϸ���������ʱ����
    {
        SceneManager.LoadScene("GameOverSence");
    }

    /*
    һ��ʵ�ֵ��÷�����3�֣�

    //1. �����ýű�����Ϊstatic���ͣ�����ʱֱ���� �ű���.������()
    //2. GameObject.Find(���ű����ڵ���������֡�).SendMessage(����������); //�ܵ���public��private���ͺ���
    //3. GameObject.Find(���ű����ڵ���������֡�).GetComponent<�ű���>().������(); //ֻ�ܵ���public���ͺ���
    //4. ����
    */

    

}
