﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpCV
{
    internal partial class cv2_native_api
    {
        [DllImport(OpenCvDllName)]
        internal static extern void imgproc_cvtColor(IntPtr src, IntPtr dst, int code, int dstCnt);
        [DllImport(OpenCvDllName)]
        internal static extern void imgproc_threshold(IntPtr src, IntPtr dst, double thresh, double maxval, int type, out double output);
        [DllImport(OpenCvDllName)]
        internal static extern void imgproc_resize(IntPtr src, IntPtr dst, Size dsize, double fx, double fy, int interpolation);
        [DllImport(OpenCvDllName)]
        internal static extern void imgproc_getRotationMatrix2D(Point center, double angle, double scale, out IntPtr output);
        [DllImport(OpenCvDllName)]
        internal static extern void imgproc_warpAffine(IntPtr src, IntPtr dst, IntPtr m, Size dsize, int flags, int borderMode, Scalar borderValue);
        [DllImport(OpenCvDllName)]
        internal static extern void imgproc_adaptiveThreshold(IntPtr src, IntPtr dst, double maxValue, int method, int type, int blockSize, double delta);
        [DllImport(OpenCvDllName)]
        internal static extern void imgproc_pyrUp(IntPtr src, IntPtr dst, Size dstsize, int borderType);
        [DllImport(OpenCvDllName)]
        internal static extern void imgproc_pyrDown(IntPtr src, IntPtr dst, Size dstsize, int borderType);
        [DllImport(OpenCvDllName)]
        internal static extern void imgproc_calcBackProject(IntPtr[] images, int nimages, int[] channels, IntPtr hist, IntPtr backProject, IntPtr[] ranges, int uniform);
        [DllImport(OpenCvDllName)]
        internal static extern void imgproc_rectangle_InputOutputArray(IntPtr img, Point pt1, Point pt2, Scalar color, int thickness, LineTypes lineType, int shift);

        [DllImport(OpenCvDllName, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern void imgproc_putText(IntPtr img, string text, Point org,
            int fontFace, double fontScale, Scalar color,
            int thickness, int lineType, int bottomLeftOrigin);
        [DllImport(OpenCvDllName, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern void imgproc_getTextSize(string text, int fontFace,
            double fontScale, int thickness, out int baseLine, out Size returnValue);
    }
}
