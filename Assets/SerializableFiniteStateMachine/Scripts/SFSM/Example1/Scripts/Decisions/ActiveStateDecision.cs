/****************************************************
	文件：ActiveStateDecision.cs
	作者：HuskyT
	邮箱：1005240602@qq.com
	日期：2020/3/19 0:0:24
	功能：目标是否存活 转换决策
*****************************************************/

using System;
using UnityEngine;

namespace SerializableFiniteStateMachine.Example1
{
    [CreateAssetMenu(fileName = "ActiveStateDecision", menuName = "SerializableFiniteStateMachine/Decisions/ActiveStateDecision")]
    public class ActiveStateDecision : DecisionBase
    {
        public override bool Decide(StateController controller)
        {
            return CheckTargetActiveState(controller);
        }
        private bool CheckTargetActiveState(StateController controller)
        {
            //目标是否存活（激活中）
            return false;
        }
    }
}
