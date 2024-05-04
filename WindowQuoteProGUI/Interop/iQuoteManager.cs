using System.Runtime.InteropServices;

namespace WindowQuoteProGUI.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pfnHaveQuotes(int length, [In, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] sQuote[] data);

    /// <summary>The COM interface that's passed to C++ code</summary>
    [Guid("98DA7DE7-7A0F-4DE5-881C-0CFDCFCC3221"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface iQuoteManager
    {
        void createQuote([In, MarshalAs(UnmanagedType.LPWStr)] string quoteName, [In, MarshalAs(UnmanagedType.LPWStr)] string customerName, eDoorMaterial material, eDoorSize size, out sQuote qoute);
        void getQuote(int id, out sQuote qoute);
        void updateQuote(sQuote qoute);
        void deleteQuote(int id);
        void getAllQuotes(pfnHaveQuotes pfnResult);
    }
}
