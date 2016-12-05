﻿using System;
using UBT.Core.Model.Core;
using UBT.Core.Model.Nodes.Leafs;
using UBT.Core.Runtime.Core;

namespace UBT.Core.Runtime.Nodes.Leafs
{
    public abstract class LeafNode : BaseNode
    {
        public LeafNode(BaseNodeModel model, BTExecutor executor, BaseNode parent) : base(model, executor, parent)
        {
            if (!(model is LeafNodeModel))
            {
                throw new ArgumentException(
                    string.Format(
                        "This NodeModel must be subclass of {0}, but it inherits from {1}", typeof(LeafNodeModel).FullName, model.GetType().FullName));
            }
        }
    }
}
