//
// Copyright (c) 2010-2018 Antmicro
//
// This file is licensed under the MIT License.
// Full license text is available in 'licenses/MIT.txt'.
//
#if !PLATFORM_WINDOWS
using Antmicro.Renode.Core;
using Antmicro.Renode.Peripherals.IRQControllers;
using Endianess = ELFSharp.ELF.Endianess;

namespace Antmicro.Renode.Peripherals.CPU
{
    [GPIO(NumberOfInputs = 12)]
    public partial class RiscV64 : BaseRiscV
    {
        public RiscV64(CoreLevelInterruptor clint, string cpuType, Machine machine, uint hartId = 0, PrivilegeArchitecture privilegeArchitecture = PrivilegeArchitecture.Priv1_10, Endianess endianness = Endianess.LittleEndian) : base(clint, hartId, cpuType, machine, privilegeArchitecture, endianness, CpuBitness.Bits64)
        {
        }

        public override string Architecture { get { return "riscv64"; } }
    }
}
#endif