/****************************************************
	文件：ActiveStateDecision.cs
	作者：HuskyT
	邮箱：1005240602@qq.com
	日期：2020/3/20 18:37:25
	功能：
*****************************************************/

using System;
using UnityEngine;

namespace FiniteStateMachine.Example1
{
    public class InactiveStateDecision : DecisionBase
    {
        public override bool Decide(StateController controller)
        {
            //检测目标是否 处于非激活状态
            return false;
        }
    }
}
