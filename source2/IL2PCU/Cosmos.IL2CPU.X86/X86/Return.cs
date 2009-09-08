﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cosmos.IL2CPU.X86 {
    [OpCode("ret")]
	public class Return: InstructionWithDestination {
        public static void InitializeEncodingData(Instruction.InstructionData aData) {
            aData.EncodingOptions.Add(new InstructionData.InstructionEncodingOption {
                OpCode = new byte[] { 0xC2 },
                DestinationImmediate=true,
                DestinationImmediateSize=InstructionSize.Word
            });
        }

        public Return() {
            DestinationValue = 0;
        }
    }
}