/****************************************************
	文件：Transition.cs
	作者：HuskyT
	邮箱：1005240602@qq.com
	日期：2020/3/20 16:44:21
	功能：转换条件
*****************************************************/

namespace FiniteStateMachine
{
    /*
     * 转换条件
     * 每个转换条件由：一个转换决策、一个转换成功后指向的状态 组成
     */
    public class Transition
    {
        private DecisionBase mDecision;
        private StateBase mTargetState;
        public DecisionBase Decision { get => mDecision; }
        public StateBase TargetState { get => mTargetState; }
        public Transition(DecisionBase decision, StateBase targetState)
        {
            mDecision = decision;
            mTargetState = targetState;
        }
    }
}
