namespace Evergine.Bindings.WebGPU;

[Flags]
public enum WGPUBufferUsage : ulong
{
    None = 0x0000000000000000,
    MapRead = 0x0000000000000001,
    MapWrite = 0x0000000000000002,
    CopySrc = 0x0000000000000004,
    CopyDst = 0x0000000000000008,
    Index = 0x0000000000000010,
    Vertex = 0x0000000000000020,
    Uniform = 0x0000000000000040,
    Storage = 0x0000000000000080,
    Indirect = 0x0000000000000100,
    QueryResolve = 0x0000000000000200,
}

[Flags]
public enum WGPUColorWriteMask : ulong
{
    None = 0x0000000000000000,
    Red = 0x0000000000000001,
    Green = 0x0000000000000002,
    Blue = 0x0000000000000004,
    Alpha = 0x0000000000000008,
    All = 0x000000000000000F,
}

[Flags]
public enum WGPUMapMode : ulong
{
    None = 0x0000000000000000,
    Read = 0x0000000000000001,
    Write = 0x0000000000000002,
}

[Flags]
public enum WGPUShaderStage : ulong
{
    None = 0x0000000000000000,
    Vertex = 0x0000000000000001,
    Fragment = 0x0000000000000002,
    Compute = 0x0000000000000004,
}

[Flags]
public enum WGPUTextureUsage : ulong
{
    None = 0x0000000000000000,
    CopySrc = 0x0000000000000001,
    CopyDst = 0x0000000000000002,
    TextureBinding = 0x0000000000000004,
    StorageBinding = 0x0000000000000008,
    RenderAttachment = 0x0000000000000010,
}

[Flags]
public enum WGPUInstanceBackend : ulong
{
    All = 0x00000000,
    Vulkan = 1 << 0,
    GL = 1 << 1,
    Metal = 1 << 2,
    DX12 = 1 << 3,
    DX11 = 1 << 4,
    BrowserWebGPU = 1 << 5,
    Primary = (1 << 0) | (1 << 2) | (1 << 3) | (1 << 5),
    Secondary = (1 << 1) | (1 << 4),
    Force32 = 0x7FFFFFFF,
}

[Flags]
public enum WGPUInstanceFlag : ulong
{
    Default = 0x00000000,
    Debug = 1 << 0,
    Validation = 1 << 1,
    DiscardHalLabels = 1 << 2,
    Force32 = 0x7FFFFFFF,
}