﻿/* Copyright (C) 2018 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IBLibrary.Messages
{
  public class TickSnapshotEndMessage
  {
    public TickSnapshotEndMessage(int tickerId)
    {
      TickerId = tickerId;
    }

    public int TickerId { get; set; }
  }
}
