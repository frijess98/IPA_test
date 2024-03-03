/// <summary>
/// General Settings for InfoCheking
/// </summary>
public class InfoCheckSettings
{
    /// <summary>
    /// Determines whether request can be performed again after success attempt
    /// </summary>
    public bool CanServicingReSubmit { get; set; }

    /// <summary>
    /// Default Info Checker Partner Key
    /// </summary>
    public string DefaultSpInfoCheckPartnerKey { get; set; }

    /// <summary>
    /// Determines whether the Info Checking feature is visible for the user
    /// </summary>
    public bool IsSpInfoCheckerVisible { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="canServicingReSubmit">Determines whether request can be performed again after success attempt</param>
    /// <param name="defaultSpInfoChecker">Default Info Checker Partner Key</param>
    /// <param name="isSpInfoCheckerVisible">Determines whether the Info Checking feature is visible for the user</param>
    public InfoCheckSettings(bool canServicingReSubmit, string defaultSpInfoChecker, bool isSpInfoCheckerVisible)
    {
        CanServicingReSubmit = canServicingReSubmit;
        DefaultSpInfoCheckPartnerKey = defaultSpInfoChecker;
        IsSpInfoCheckerVisible = isSpInfoCheckerVisible;
    }
}
