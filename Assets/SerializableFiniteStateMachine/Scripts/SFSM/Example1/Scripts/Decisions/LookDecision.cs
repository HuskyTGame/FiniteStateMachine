/****************************************************
	文件：LookDecision.cs
	作者：HuskyT
	邮箱：1005240602@qq.com
	日期：2020/3/18 23:59:56
	功能：看 转换决策
*****************************************************/

using System;
using UnityEngine;

namespace SerializableFiniteStateMachine.Example1
{
    [CreateAssetMenu(fileName = "LookDecision", menuName = "SerializableFiniteStateMachine/Decisions/LookDecision")]
    public class LookDecision : DecisionBase
    {
        public override bool Decide(StateController controller)
        {
            return Look(controller);
        }
        private bool Look(StateController controller)
        {
            //看的逻辑
            return false;
        }
    }
}
