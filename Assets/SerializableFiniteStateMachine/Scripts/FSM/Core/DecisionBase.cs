/****************************************************
	文件：DecisionBase.cs
	作者：HuskyT
	邮箱：1005240602@qq.com
	日期：2020/3/20 16:23:26
	功能：转换决策（抽象基类）
*****************************************************/

namespace FiniteStateMachine
{
    /*
     * 转换决策（抽象基类）
     * 作用：为转换条件 Transition 的核心组成部分，用于处理状态之间转换的核心逻辑
     */
    public abstract class DecisionBase
    {
        public abstract bool Decide(StateController controller);
    }
}
