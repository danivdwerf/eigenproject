﻿public static class Controller
{
    private static string triangle = "";
    public static string Triangle { get { return triangle; } }
    private static string square = "";
	public static string Square { get { return square; } }
    private static string cross = "";
    public static string Cross { get { return cross; } }
    private static string circle = "";
    public static string Circle { get { return circle; } }
    private static string leftStickX = "";
    public static string LeftStickX { get { return leftStickX; } }
    private static string leftStickY = "";
    public static string LeftStickY { get { return leftStickY; } }
    private static string rightStickX = "";
    public static string RightStickX { get { return rightStickX; } }
    private static string rightStickY = "";
    public static string RightStickY { get { return rightStickY; } }
    private static string l1 = "";
    public static string L1 { get { return l1; } }
    private static string r1 = "";
    public static string R1 { get { return r1; } }
    private static string l2 = "";
    public static string L2 { get { return l2; } }
    private static string r2 = "";
    public static string R2 { get { return r2; } }
    private static string leftThumb = "";
    public static string LeftThumb { get { return leftThumb; } }
    private static string rightThumb = "";
    public static string RightThumb { get { return rightThumb; } }
    private static string dpadX = "";
    public static string DpadX { get { return dpadX; } }
    private static string dpadY = "";
    public static string DpadY { get { return dpadY; } }

    public static void setController(ControllerType controller, OperationSystem os)
    {
        if (controller == ControllerType.none)
        {
            setKeyInput();
            return;
        }

        if (os == OperationSystem.mac)
        {
            setMacController(controller);
            return;
        }

        if (os == OperationSystem.windows)
        {
            setMacController(controller);
            return;
        }
    }

    private static void setKeyInput()
    {
        leftStickX = "Horizontal";
        leftStickY = "Vertical";
        cross = "Use";
        circle = "Cancel";
        rightStickY = "MouseLookY";
        rightStickX = "MouseLookX";
    }

    private static void setMacController(ControllerType controller)
    {
        if (controller == ControllerType.playstation)
        {
            triangle = "psTriangleMac";
            square = "psSquareMac";
            cross = "psXMac";
            circle = "psOMac";
            leftStickX = "psLeftStickXMac";
            leftStickY = "psLeftStickYMac";
            l1 = "psL1Mac";
            r1 = "psR1Mac";
            l2 = "psL2Mac";
            r2 = "psR2Mac";
            leftThumb = "psL3Mac";
            rightThumb = "psR3Mac";
            dpadX = "psDpadXMac";
            dpadY = "psDpadYMac";
            rightStickX = "psRightStickXMac";
            rightStickY = "psRightStickYMac";
            return;
        }

        if (controller == ControllerType.xbox)
        {
            triangle = "xboxYMac";
            square = "xboxXMac";
            cross = "xboxAMac";
            circle = "xboxBMac";
            leftStickX = "xboxLeftStickXMac";
            leftStickY = "xboxLeftStickYMac";
            rightStickX = "xboxRightStickXMac";
            rightStickY = "xboxRightStickYMac";
            l1 = "xboxLBMac";
            r1 = "xboxRBMac";
            l2 = "xboxLTMac";
            r2 = "xboxRTMac";
            leftThumb = "xboxLeftThumbMac";
            rightThumb = "xboxRightThumbMac";
            return;
        }
    }

    private static void setWinController(ControllerType controller)
    {
        if (controller == ControllerType.playstation)
        {
            triangle = "psTriangle";
            square = "psSquare";
            cross = "psCross";
            circle = "psCircle";
            leftStickX = "psLeftStickX";
            leftStickY = "psLeftStickY";
            l1 = "psL1";
            r1 = "psR1";
            l2 = "psL2";
            r2 = "psR2";
            leftThumb = "psLeftThumb";
            rightThumb = "psRightThumb";
            dpadX = "psDpadX";
            dpadY = "psDpadY";
            rightStickX = "psRightStickXWin";
            rightStickY = "psRightStickYWin";
            return;
        }

        if (controller == ControllerType.xbox)
        {
            triangle = "xboxYWin";
            square = "xboxXWin";
            cross = "xboxAWin";
            circle = "xboxBWin";
            leftStickX = "xboxLeftStickXWin";
            leftStickY = "xboxLeftStickYWin";
            rightStickX = "xboxRightStickXWin";
            rightStickY = "xboxRightStickYWin";
            l1 = "xboxLBWin";
            r1 = "xboxRBWin";
            l2 = "xboxLTWin";
            r2 = "xboxRTWin";
            leftThumb = "xboxLeftThumbWin";
            rightThumb = "xboxRightThumbWin";
            dpadX = "xboxDpadXWin";
            dpadY = "xboxDpadYWin";
            return;
        }
    }
}
