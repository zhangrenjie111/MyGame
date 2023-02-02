using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameSenceManager : MonoBehaviour
{
    /// <summary>
    /// 打包时，当前场景为第一场景，游戏内容为第二场景，玩家死亡为最后场景；否则此模板无效。
    /// 打包时，当前场景为第一场景，游戏内容为第二场景，玩家死亡为最后场景；否则此模板无效。
    /// 打包时，当前场景为第一场景，游戏内容为第二场景，玩家死亡为最后场景；否则此模板无效。
    /// </summary>
    /// 

    private int SenceNum;
    void Start()
    {
        //获取编号
        SenceNum = SceneManager.GetActiveScene().buildIndex;
        //获取名称 
        //string name = SceneManager.GetActiveScene().name;

    }

    public void GameStartBtnFunc()     //游戏开始，加载游戏内容场景
    {
        SceneManager.LoadScene(SenceNum + 1);
    }

    public void GameReplayBtnFunc()     //游戏结束，按钮从新加载游戏（如果有关卡，恰好加载上个关卡，1个关卡就加载那个关卡）
    {
        SceneManager.LoadScene(SenceNum - 1);
    }

    public void GoGameoverSenceFunc()  //玩家死亡方法，加载死亡场景               这个方法在实际游戏中玩家死亡时调用
    {
        SceneManager.LoadScene("GameOverSence");
    }

    /*
    一：实现调用方法有3种：

    //1. 被调用脚本函数为static类型，调用时直接用 脚本名.函数名()
    //2. GameObject.Find(“脚本所在的物体的名字”).SendMessage(“函数名”); //能调用public和private类型函数
    //3. GameObject.Find(“脚本所在的物体的名字”).GetComponent<脚本名>().函数名(); //只能调用public类型函数
    //4. 单例
    */

    

}
