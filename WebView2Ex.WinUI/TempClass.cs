﻿//// Code mostly generated by https://bing.com/chat with minor modification
//using Windows.Win32.Graphics.Direct2D;
//using Windows.Win32.Graphics.Direct3D;
//using Windows.Win32.Graphics.Direct3D11;
//using Windows.Win32.Graphics.Dxgi;
//using Windows.Win32.Graphics.Dxgi.Common;
//using Windows.Win32.Graphics.DirectComposition;
//using Windows.Win32;
//using Windows.Win32.Foundation;

//using System.Runtime.InteropServices;
//namespace WebView2Ex.UI;

//partial class WebView2Ex {
//    unsafe (IDCompositionVisual visual, IDXGISwapChain1 swapchain) CreateSwapChainAndVisual()
//    {
//        // Create a Direct3D device
//        PInvoke.D3D11CreateDevice(null, D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_HARDWARE, default, D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_BGRA_SUPPORT, null, 0, PInvoke.D3D11_SDK_VERSION, out var d3dDevice, null, out _);
//        var dxgiDevice = (IDXGIDevice)d3dDevice;
//        dxgiDevice.GetAdapter(out var dXGIAdapter);
//        var dxgifactoryguid = typeof(IDXGIFactory2).GUID;
//        dXGIAdapter.GetParent(typeof(IDXGIFactory2).GUID, out var factoryuncasted);
//        IDXGIFactory2 factory = (IDXGIFactory2)factoryuncasted;
        
//        // Create a DirectComposition device

//        PInvoke.D2D1CreateDevice(dxgiDevice, default(D2D1_CREATION_PROPERTIES), out var d2dDevice);
//        PInvoke.DCompositionCreateDevice3(d2dDevice, typeof(IDCompositionDevice).GUID, out var deviceuncasted);
//        IDCompositionDevice device = (IDCompositionDevice)deviceuncasted;


//        // Create a visual
//        device.CreateVisual(out var visual);

        
//        // Create a swap chain
//        DXGI_SWAP_CHAIN_DESC1 swapChainDesc = new()
//        {
//            Width = 640,
//            Height = 480,
//            Format = DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM,
//            Stereo = false,
//            SampleDesc =
//            {
//                Count = 1,
//                Quality = 0
//            },
//            BufferUsage = DXGI_USAGE.DXGI_USAGE_RENDER_TARGET_OUTPUT,
//            BufferCount = 2,
//            Scaling = DXGI_SCALING.DXGI_SCALING_STRETCH,
//            SwapEffect = DXGI_SWAP_EFFECT.DXGI_SWAP_EFFECT_FLIP_SEQUENTIAL,
//            Flags = 0,
//        };

//        swapChainDesc.SampleDesc.Count = 1;

//        factory.CreateSwapChainForComposition(d3dDevice, in swapChainDesc, null, out var swapChain);
//        // swapChain.ResizeBuffers

//        // Set the swap chain as the content of the visual
//        visual.SetContent(swapChain);

//        device.Commit();

//        return (visual, swapChain);
//    }
//}
//[ComImport, Guid("63aad0b8-7c24-40ff-85a8-640d944cc325"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
//interface ISwapChainPanelNative
//{
//    [PreserveSig]
//    HRESULT SetSwapChain(IDXGISwapChain swapChain);
//}