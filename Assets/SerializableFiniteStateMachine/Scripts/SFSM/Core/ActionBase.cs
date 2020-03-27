/****************************************************
	文件：ActionBase.cs
	作者：HuskyT
	邮箱：1005240602@qq.com
	日期：2020/3/18 22:7:18
	功能：AI 的最小行为单元（抽象基类）
*****************************************************/

using UnityEngine;

namespace SerializableFiniteStateMachine
{
    /*
     * AI 的最小行为单元
     * 抽象基类，子类可序列化为 Asset 资产对象
     * 作用：将 AI 行为尽可能拆分、模块化，便于拓展、复用。
     */
    public abstract class ActionBase : ScriptableObject
    {
        public abstract void Act(StateController controller);
    }
}
