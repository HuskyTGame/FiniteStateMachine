/****************************************************
	文件：Transition.cs
	作者：HuskyT
	邮箱：1005240602@qq.com
	日期：2020/3/18 22:8:44
	功能：转换条件
*****************************************************/

using UnityEngine;

namespace SerializableFiniteStateMachine
{
    /*
     * 转换条件
     * 每个转换条件由：一个转换决策、一个转换成功后指向的状态、一个转换失败后指向的状态  组成
     * 说明：加上可序列化标签是便于在 Unity 编辑模式下进行配置
     */
    [System.Serializable]
    public class Transition
    {
        [Tooltip("转换决策")]
        public DecisionBase Decision;
        [Tooltip("转换成功后指向的状态")]
        public State TrueState;
        [Tooltip("转换失败后指向的状态")]
        public State FalseState;
    }
}
