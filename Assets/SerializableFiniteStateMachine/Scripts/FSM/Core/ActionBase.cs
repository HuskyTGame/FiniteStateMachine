/****************************************************
	文件：ActionBase.cs
	作者：HuskyT
	邮箱：1005240602@qq.com
	日期：2020/3/20 16:23:4
	功能：AI 的最小行为单元（抽象基类）
*****************************************************/

namespace FiniteStateMachine
{
    /*
     *  AI 的最小行为单元（抽象基类）
     *  作用：将 AI 行为尽可能拆分、模块化，便于拓展、复用。
     */
    public abstract class ActionBase
    {
        public abstract void Act(StateController controller);
    }
}
