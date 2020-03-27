/****************************************************
	文件：LookDecision.cs
	作者：HuskyT
	邮箱：1005240602@qq.com
	日期：2020/3/20 18:37:7
	功能：
*****************************************************/

using System;
using UnityEngine;

namespace FiniteStateMachine.Example1
{
    public class LookDecision : DecisionBase
    {
        public override bool Decide(StateController controller)
        {
            //检测视野内是否存在目标
            return false;
        }
    }
}
