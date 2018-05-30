﻿/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2009-2012 Michael Möller <mmoeller@openhardwaremonitor.org>
	Copyright (C) 2010 Paul Werelds
  Copyright (C) 2011 Roland Reinl <roland-reinl@gmx.de>
	
*/

using System.Runtime.InteropServices;

namespace OpenHardwareMonitor.Hardware.HDD
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct DriveCommandParameter
    {
        public uint BufferSize;
        public CommandBlockRegisters Registers;
        public byte DriveNumber;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] Reserved;
    }
}