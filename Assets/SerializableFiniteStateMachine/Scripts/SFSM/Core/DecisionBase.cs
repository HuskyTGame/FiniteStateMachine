/****************************************************
	文件：DecisionBase.cs
	作者：HuskyT
	邮箱：1005240602@qq.com
	日期：2020/3/18 22:8:33
	功能：转换决策（抽象基类）
*****************************************************/

using UnityEngine;

namespace SerializableFiniteStateMachine
{
    /*
     * 转换决策
     * 抽象基类，子类可序列化为 Asset 资产对象
     * 作用：为转换条件 Transition 的核心组成部分，用于处理状态之间转换的核心逻辑
     */
    public abstract class DecisionBase : ScriptableObject
    {
        public abstract bool Decide(StateController controller);
    }
}
